using Logic.Managers;
using Logic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animals;
using Logic.Interfaces;
using Employees;
using Microsoft.Data.SqlClient;
using DataAccess;
using Logic.DTO;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Desktop
{
    public partial class Login : Form
    {
        IAnimal animalRepository = new AnimalRepository();
        ILocation locationRepository = new LocationRepository();

        private readonly UserManager userManager;

        static SerialPort serialPort;

        public Login()

        {

            InitializeComponent();

            serialPort = new SerialPort("COM8", 9600, Parity.None, 8, StopBits.One);
            serialPort.Open();
            timer1.Start();


            userManager = new UserManager(new UserRepository());





        }



        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IUser userRepository = new UserRepository();
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;

            User currentUser = userRepository.Login(email, password);


            if (currentUser != null)
            {
                string position = userManager.RetrievePositionInformation(email);

                if (position == "Admin")
                {
                    Form openfrom = new Form1();
                    openfrom.ShowDialog();
                }
                if (position == "Caretaker")
                {
                    Form addAnimalForm = new CaretakerForm(animalRepository, locationRepository);
                    addAnimalForm.ShowDialog();
                }
                if (position == "1")
                {

                    MainForm addEmployeeForm = new MainForm(1);
                    this.Hide();
                    addEmployeeForm.FormClosed += (e, args) => this.Close();
                    addEmployeeForm.Show();
                }
                if (position == "2")
                {
                    MainForm addEmployeeForm = new MainForm(2);
                    this.Hide();
                    addEmployeeForm.FormClosed += (e, args) => this.Close();
                    addEmployeeForm.Show();
                }
                if (position == "3")
                {
                    MainForm addAnimalForm = new MainForm(3);
                    this.Hide();
                    addAnimalForm.FormClosed += (e, args) => this.Close();
                    addAnimalForm.Show();



                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Create an instance of UserRepository (assuming it implements IUser)
            IUser userRepository = new UserRepository();

            UserDTO dummyUser = new UserDTO
            {
                Username = "test@example.com",
                Password = "password",
                Email = "Test User"

            };

            // Call the InsertDummyUser method on the userRepository instance
            bool insertionResult = userRepository.InsertDummyUser(dummyUser);

            if (insertionResult)
            {
                Console.WriteLine("Dummy user inserted successfully.");
            }
            else
            {
                Console.WriteLine("Failed to insert dummy user.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                if (serialPort.BytesToRead > 0)
                {
                    string input = serialPort.ReadLine();
                    input = input.Trim();

                    MessageBox.Show(input);

                    try
                    {
                        User loggedin = userManager.GetUserByRfid(input);

                        if (loggedin != null)
                        {
                            string position = userManager.RetrievePositionInformation(loggedin.Username);

                            if (position == "Admin")
                            {
                                Form openfrom = new Form1();
                                openfrom.ShowDialog();
                            }
                            if (position == "Caretaker")
                            {
                                Form addAnimalForm = new CaretakerForm(animalRepository, locationRepository);
                                addAnimalForm.ShowDialog();
                            }
                            if (position == "1")
                            {

                                MainForm addEmployeeForm = new MainForm(1);
                                this.Hide();
                                addEmployeeForm.FormClosed += (e, args) => this.Close();
                                addEmployeeForm.Show();
                            }
                            if (position == "2")
                            {
                                MainForm addEmployeeForm = new MainForm(2);
                                this.Hide();
                                addEmployeeForm.FormClosed += (e, args) => this.Close();
                                addEmployeeForm.Show();
                            }
                            if (position == "3")
                            {
                                MainForm addAnimalForm = new MainForm(3);
                                this.Hide();
                                addAnimalForm.FormClosed += (e, args) => this.Close();
                                addAnimalForm.Show();



                            }
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Nu existi!");
                    }
                }
            }
        }
    }
}
