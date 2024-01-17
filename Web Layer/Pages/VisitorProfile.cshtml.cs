using DataAccess;
using Logic.DTO;
using Logic.Entities;
using Logic.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    [Authorize(Policy = "MustBeVisitor")]
    public class VisitorProfile : PageModel
    {
        public VisitorDTO userProfile;
        UserManager user = new UserManager(new UserRepository());
        [BindProperty]
        public string CurrentPassword { get; set; }

        [BindProperty]
        public string NewPassword { get; set; }

        [BindProperty]
        public string ConfirmNewPassword { get; set; }

        // Add the ActiveCard property
        public string ActiveCard { get; set; }

        public IActionResult OnGet()
        {
            try
            {
                var userIdClaim = User.FindFirst("UserID");
                if (userIdClaim != null)
                {
                    var userIdValue = userIdClaim.Value;
                    if (int.TryParse(userIdValue, out int userId))
                    {
                        VisitorProfileManager userProfileManager = new VisitorProfileManager(new VisitorProfileRepository());
                        userProfile = userProfileManager.GetActualProfileByID(userId);
                        if (userProfile != null)
                        {
                            // Set the default card type
                            ActiveCard = "visitor";
                            return Page();
                        }
                    }
                }
                return Redirect("/Index");
            }
            catch (Exception ex)
            {
                return Redirect($"/Index?message={ex.Message}");
            }
        }
        public IActionResult OnPostUpdateProfile()
        {
            try
            {
                var visitorIdClaim = User.FindFirst("UserID");
                if (visitorIdClaim != null)
                {
                    var visitorIdValue = visitorIdClaim.Value;
                    if (int.TryParse(visitorIdValue, out int userID))
                    {
                        VisitorProfileManager userProfileManager = new VisitorProfileManager(new VisitorProfileRepository());
                        VisitorDTO currentVisitor = userProfileManager.GetActualProfileByID(userID);

                        // Retrieve the updated visitor data from the form submission
                        string modifiedUsername = Request.Form["updatedProfile.modifiedUsername"];
                        string modifiedEmail = Request.Form["updatedProfile.modifiedEmail"];

                        // Check if the new username already exists
                        if (!string.IsNullOrEmpty(modifiedUsername) && modifiedUsername != currentVisitor.Username)
                        {
                            bool isUsernameUnique = userProfileManager.IsUsernameUnique(modifiedUsername);

                            if (!isUsernameUnique)
                            {
                                ModelState.AddModelError("updatedProfile.modifiedUsername", "Username already exists. Please choose a different one.");
                                return Page(); // Return to the page with the error message
                            }
                        }

                        // Check if the new email already exists
                        if (!string.IsNullOrEmpty(modifiedEmail) && modifiedEmail != currentVisitor.Email)
                        {
                            bool isEmailUnique = userProfileManager.IsEmailUnique(modifiedEmail);

                            if (!isEmailUnique)
                            {
                                ModelState.AddModelError("updatedProfile.modifiedEmail", "Email already exists. Please choose a different one.");
                                return Page(); // Return to the page with the error message
                            }
                        }

                        // Continue with updating the visitor profile
                        VisitorDTO updatedVisitor = new VisitorDTO
                        {
                            // Visitor Information
                            UserID = userID,
                            Username = string.IsNullOrEmpty(modifiedUsername) ? currentVisitor.Username : modifiedUsername,
                            Email = string.IsNullOrEmpty(modifiedEmail) ? currentVisitor.Email : modifiedEmail,

                            // Add other visitor information fields as needed
                        };

                        // Call the method to update the visitor profile
                        VisitorDTO updatedVisitorResult = userProfileManager.UpdateVisitorInformation(updatedVisitor);
                    }
                }
                return Redirect("Index");
            }
            catch (Exception ex)
            {
                // Handle the error and return an appropriate response
                return Redirect("Index");
            }
        }


        public IActionResult OnPostCancelVisitorProfile()
        {
            // Add logic to handle cancellation for visitor profile, e.g., redirect to the index page
            return Redirect("Index");
        }
        public IActionResult OnPostUpdatePassword()
        {
            try
            {
                var userIdClaim = User.FindFirst("UserID");

                if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int userId))
                {
                    string currentPassword = Request.Form["currentPassword"];
                    string newPassword = Request.Form["newPassword"];
                    string confirmNewPassword = Request.Form["confirmNewPassword"];

                    // Validate the form data
                    if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmNewPassword))
                    {
                        ModelState.AddModelError(string.Empty, "All password fields are required.");
                        return Page();
                    }

                    // Call the user's ChangePassword method
                    user.ChangePassword(userId, currentPassword, newPassword, confirmNewPassword);

                    // Redirect upon successful password update
                    return RedirectToPage("/Index");
                }

                // Handle the case where the user ID claim is not found or parsing fails
                ModelState.AddModelError(string.Empty, "Unable to determine the user.");
                return Page();
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log, display an error message)
                ModelState.AddModelError(string.Empty, "Error updating password. Please try again.");
                return Page();
            }
        }
    }

}
