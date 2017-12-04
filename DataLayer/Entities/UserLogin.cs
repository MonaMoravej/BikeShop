using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{

    /// <summary>
    /// This is User Login class, inherited from Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin.
    /// For changing Id from string to int.
    /// </summary>
    public class UserLogin : IdentityUserLogin<long> { }
}
