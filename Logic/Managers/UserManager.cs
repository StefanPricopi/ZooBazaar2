using Logic.DTO;
using Logic.Entities;
using Logic.Interfaces;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;

namespace Logic.Managers
{
    public class UserManager
    {
        private readonly IUser userRepo;

        public UserManager() { }
        public void UpdateNewPassword(string password, string token)
        {
            userRepo.UpdateNewPassword(password, token);
        }
        public bool receivedResetTokenMatch(string token)
        {
            var RetrievedToken = userRepo.RetrieveResetTokenFromToken(token);
            if (RetrievedToken.Item1 != null && RetrievedToken.Item2 == false)
            {
                return true;
            }
            return false;
        }
        public void SendResetEmail(User user)
        {
            
            string senderEmail = "ruuvolt@gmail.com";
            string subject = "Verification Email(do not reply)";
            var token = Guid.NewGuid().ToString();
            string messageBody = $"Click on this link to reset your password:https://localhost:7281/NewPassword?token={token}";
            MailMessage mail = new MailMessage(senderEmail, user.Email);
            mail.Subject = subject;
            mail.Body = messageBody;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, "ybud uxim diox razv"),
                EnableSsl = true,
            };
            smtpClient.Send(mail);
            userRepo.AddResetToken(token, user.UserID);
        }

        public UserManager(IUser user)
        {
            this.userRepo = user ?? throw new ArgumentNullException(nameof(user));
        }
        public bool InsertDummyUser(UserDTO userDTO)
        {
            // Call the repository method to insert the dummy user
            return userRepo.InsertDummyUser(userDTO);
        }

        public User Login(string username, string password)
        {
            User currentUser = userRepo.GetCurrentUserByUsername(username); // Call the method via IUser

            if (username == currentUser.Username && currentUser.Password == password)
            {
                return currentUser;
            }

            return null;
        }

        public User GetUserByRfid(string rfid)
        {
            return new User(userRepo.LoginByRfid(rfid));
        }
        public string RetrievePositionInformation(string username)
        {
            return userRepo.RetrievePositionInformation(username);
        }


        public bool CreateAccount(UserDTO userDTO)
        {
            return userRepo.CreateAccount(userDTO);
        }

        public List<User> GetAllAccounts()
        {
            List<User> users = new List<User>();
            foreach (UserDTO userDTO in userRepo.GetAllAccounts())
            {
                users.Add(new User(userDTO.UserID, userDTO.Username, userDTO.Password, userDTO.Email, userDTO.Salt, userDTO.Rfid));
            }
            return users;
        }

        public bool UpdateAccount(UserDTO userDTO)
        {
            return userRepo.UpdateAccount(userDTO);
        }
        public static string HashedPassword(string password)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashedPasswordBytes = hash.ComputeHash(passwordBytes);
                return Convert.ToHexString(hashedPasswordBytes);
            }
        }
        public bool IsLoginValid(string username, string password)
        {

            User Obj = userRepo.GetCurrentUserByUsername(username);
            if (Obj != null)
            {

                var userhashedpass = HashedPassword($"{password}{Obj.Salt.Trim()}");
                Console.WriteLine(Obj.Salt);
                if (userhashedpass == Obj.Password)
                {
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
        

        public UserDTO IsLoginEmployeeOrVisitor(string username, string password)
        {

            UserDTO Obj = userRepo.FindUserByProvidedUsername(username);
            if (Obj != null)
            {
                
                    var userhashedpass = HashedPassword($"{password}{Obj.Salt.Trim()}");
                    Console.WriteLine(Obj.Salt);
                    if (userhashedpass == Obj.Password)
                    {
                    return Obj;
                    }
                    else { return null; }
                
            }
            else { return null; }
        }
        public bool CreateVisitor(UserDTO userDtO)
        {
            return userRepo.CreateVisitor(userDtO);
        }
        public User GetCurrentUserByUsername(string username)
        {
            return userRepo.GetCurrentUserByUsername(username);
        }
        public int GetEmpIDbyUserId(int id)
        {
            return userRepo.GetEmpIDbyUserId(id);
        }
        public void ChangePassword(int userId, string oldPassword, string newPassword, string confirmNewPassword)
        {
            this.userRepo.ChangePassword(userId, oldPassword, newPassword, confirmNewPassword);
        }
        public string GetHashedPassword(int userId, string password)
        {
            return userRepo.GetHashedPassword(userId, password);
        }
        public string GetUserPassword(int userId)
        {
            return this.userRepo.GetUserPassword(userId);
        }
    }
}
