using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    /// <summary>
    /// This is User claim class, inherited from Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim.
    /// For changing Id from string to int.
    /// </summary>
    public class UserClaim : IdentityUserClaim<long> { }
   
}
