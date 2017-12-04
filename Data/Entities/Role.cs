
using Microsoft.AspNet.Identity.EntityFramework;

namespace Data.Entities
{
    /// <summary>
    /// This is a class for all Roles we have in SheJool System (This is Role class), inherited from Microsoft.AspNet.Identity.EntityFramework.IdentityRole.
    /// For changing Id from string to int, and having extra fields we need in SheJool.
    /// OldName :Tbl_UserRole
    /// </summary>
    public class Role : IdentityRole<long, UserRole> 
    {


        /// <summary>
        /// This is a description about every Role we have in SheJool system. 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// This is a bool shows this Role is default role or not, by default all roles are not the default role.
        /// </summary>
        public bool IsDefaultRole { get; set; } = false;

        /// <summary>
        /// This is a bool shows this Role is enable or not, by default all roles are enable.
        /// </summary>
        public bool IsEnabled { get; set; } = true;
 
    }
}
