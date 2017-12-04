using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    /// <summary>
    /// This is User Role class, inherited from Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole.
    /// For changing Id from string to int, and having extra fields we need in SheJool.
    /// Please notice every User can have several Roles and every Role can assign to several Users. 
    /// This is a new class for supporting the feature of having more than one Role for User.
    /// </summary>
    public class UserRole : IdentityUserRole<long>
    {
  
    }
}
