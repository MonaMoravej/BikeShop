using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Data.Entities
{
   
    public class User : IdentityUser<long, UserLogin, UserRole, UserClaim>
    {
       
        public string FullName { get; set; }

        
        public string AlternateEmail { get; set; }

        /// <summary>
        /// Every user can select one langusge from the list of languages SheJool system supports. if it's null, the default language is en-Us( English).
        /// </summary>
        public string SelectedCulture { get; set; }


        #region methods

        /// <summary>
        /// This method used for careting User with cookie.
        /// </summary>
        /// <param name="manager"></param>
        /// <returns></returns>
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(SheJoolUserManager manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        #endregion
    }
}
