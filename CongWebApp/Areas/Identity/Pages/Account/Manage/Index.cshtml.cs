using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CongWebApp.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CongWebApp.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<CongWebAppUser> _userManager;
        private readonly SignInManager<CongWebAppUser> _signInManager;

        public IndexModel(
            UserManager<CongWebAppUser> userManager,
            SignInManager<CongWebAppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [PersonalData]
            [StringLength(20)]
            public string FirstName { get; set; }
            [PersonalData]
            [StringLength(20)]
            public string LastName { get; set; }
            [PersonalData]
            [DataType(DataType.Date)]
            public DateTime DOB { get; set; }
            [Phone]
            [Display(Name = "Mobile number")]
            public string MobileNumber { get; set; }
        }

        private async Task LoadAsync(CongWebAppUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var mobileNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                LastName = user.LastName,
                FirstName = user.FirstName,
                DOB = user.DOB,
                MobileNumber = mobileNumber
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var mobileNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.MobileNumber != mobileNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.MobileNumber);
                if (!setPhoneResult.Succeeded)
                {
                    var userId = await _userManager.GetUserIdAsync(user);
                    throw new InvalidOperationException($"Unexpected error occurred setting phone number for user with ID '{userId}'.");
                }
            }

            if(Input.FirstName != user.FirstName)
            {
                user.FirstName = Input.FirstName;
            }

            if(Input.LastName != user.LastName)
            {
                user.LastName = Input.LastName;
            }

            if(Input.DOB != user.DOB)
            {
                user.DOB = Input.DOB;
            }

            await _userManager.UpdateAsync(user);

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
