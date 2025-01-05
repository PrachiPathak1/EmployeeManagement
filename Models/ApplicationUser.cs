using Microsoft.AspNetCore.Identity;

namespace EmployeeManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        // You can extend the ApplicationUser class to include additional properties, e.g.:
        public string FullName { get; set; }
    }
}
