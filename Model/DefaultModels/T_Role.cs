using System.ComponentModel.DataAnnotations;
using LogisticsAPI.Models;

namespace Model
{
    public class T_Role
    {
        [Key]
        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public static void Init(LogisticsContext db)
        {
            string[] Roles = {"Admin", "Manager", "Employee"};
            foreach (var roleName in Roles)
            {
                var role = new T_Role();
                role.RoleName = roleName;
                db.T_Roles.Add(role);
            }
            db.SaveChanges();
        }
    }
}