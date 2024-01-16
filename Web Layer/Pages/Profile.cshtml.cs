using DataAccess;
using Logic.DTO;
using Logic.Managers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Web_Layer.Pages
{
    [Authorize(Policy = "MustBeEmployee")]
    public class ProfileModel : PageModel
    {
        public EmpProfileDTO userProfile;

        // Add the ActiveCard property
        public string ActiveCard { get; set; }

        public IActionResult OnGet()
        {
            try
            {
                var userIdClaim = User.FindFirst("EmployeeId");
                if (userIdClaim != null)
                {
                    var userIdValue = userIdClaim.Value;
                    if (int.TryParse(userIdValue, out int userId))
                    {
                        EmpProfileManager userProfileManager = new EmpProfileManager(new EmpProfileRepository());
                        userProfile = userProfileManager.GetActualProfileByID(userId);
                        if (userProfile != null)
                        {
                            // Set the default card type
                            ActiveCard = "personal";
                            return Page();
                        }
                    }
                }
                return Redirect("Index");
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
                var userIdClaim = User.FindFirst("EmployeeId");
                if (userIdClaim != null)
                {
                    var userIdValue = userIdClaim.Value;
                    if (int.TryParse(userIdValue, out int userId))
                    {
                        EmpProfileManager userProfileManager = new EmpProfileManager(new EmpProfileRepository());
                        EmpProfileDTO currentProfile = userProfileManager.GetActualProfileByID(userId);

                        // Retrieve the updated profile data from the form submission
                        EmpProfileDTO updatedProfile = new EmpProfileDTO
                        {
                            // Personal Information
                            employeeID = userId,
                            firstName = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedFirstName"]) ? currentProfile.firstName : Request.Form["updatedProfile.modifiedFirstName"],
                            lastName = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedLastName"]) ? currentProfile.lastName : Request.Form["updatedProfile.modifiedLastName"],
                            phoneNumber = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedPhoneNumber"]) ? currentProfile.phoneNumber : Request.Form["updatedProfile.modifiedPhoneNumber"],
                            dateOfBirth = DateTime.TryParse(Request.Form["updatedProfile.modifiedDateOfBirth"], out DateTime modifiedDateOfBirth)
                                ? modifiedDateOfBirth
                                : currentProfile.dateOfBirth,
                            email = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedEmail"]) ? currentProfile.email : Request.Form["updatedProfile.modifiedEmail"],

                            // Address Information
                            street = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedStreet"]) ? currentProfile.street : Request.Form["updatedProfile.modifiedStreet"],
                            zipcode = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedZipCode"]) ? currentProfile.zipcode : Request.Form["updatedProfile.modifiedZipCode"],
                            city = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedCity"]) ? currentProfile.city : Request.Form["updatedProfile.modifiedCity"],
                            country = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedCountry"]) ? currentProfile.country : Request.Form["updatedProfile.modifiedCountry"],

                            // Spouse Information
                            partnerFirstName = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedPartnerFirstName"]) ? currentProfile.partnerFirstName : Request.Form["updatedProfile.modifiedPartnerFirstName"],
                            partnerLastName = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedPartnerLastName"]) ? currentProfile.partnerLastName : Request.Form["updatedProfile.modifiedPartnerLastName"],
                            partnerPhoneNumber = string.IsNullOrEmpty(Request.Form["updatedProfile.modifiedPartnerPhoneNumber"]) ? currentProfile.partnerPhoneNumber : Request.Form["updatedProfile.modifiedPartnerPhoneNumber"],
                        };

                        // Call the method to update the profile
                        EmpProfileDTO updatedProfileResult = userProfileManager.UpdateProfile(updatedProfile);
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
        public IActionResult OnPostCancel()
        {
            // Add logic to handle cancellation, e.g., redirect to the index page
            return Redirect("Index");
        }
    }
}
