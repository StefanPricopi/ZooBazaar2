using DataAccess;
using Logic.DTO;
using Logic.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Layer.Pages
{
    [Authorize(Policy = "MustBeVisitor")]
    public class VisitorProfile : PageModel
    {
        public VisitorDTO userProfile;

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
                        VisitorDTO updatedVisitor = new VisitorDTO
                        {
                            // Visitor Information
                            UserID = userID,
                            Username = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedUsername"]) ? currentVisitor.Username : Request.Form["updatedProfile.modifiedUsername"],
                            Email = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedEmail"]) ? currentVisitor.Email : Request.Form["updatedProfile.modifiedEmail"],

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

    }

}
