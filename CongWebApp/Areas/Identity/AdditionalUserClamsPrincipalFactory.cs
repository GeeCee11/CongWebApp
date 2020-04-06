using CongWebApp.Areas.Identity.Data;
using IdentityModel;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace CongWebApp.Areas.Identity
{
    public class AdditionalUserClamsPrincipalFactory : UserClaimsPrincipalFactory<CongWebAppUser, IdentityRole>
    {
        public AdditionalUserClamsPrincipalFactory(
            UserManager<CongWebAppUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> optionsAccessor)
            :base(userManager, roleManager, optionsAccessor)
        { }
		
		public async override Task<ClaimsPrincipal> CreateAsync(CongWebAppUser user)
		{
			var principal = await base.CreateAsync(user);
			var identity = (ClaimsIdentity)principal.Identity;

		var claims = new List<Claim>();
			if (user.IsAdmin)
			{
				claims.Add(new Claim(JwtClaimTypes.Role, "admin"));
			}
			else
			{
				claims.Add(new Claim(JwtClaimTypes.Role, "user"));
			}
			
			identity.AddClaims(claims);
			return principal;
		}
    }
}