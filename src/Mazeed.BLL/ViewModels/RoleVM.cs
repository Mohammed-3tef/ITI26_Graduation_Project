using System.ComponentModel.DataAnnotations;

namespace Mazeed.BLL.ViewModels
{
    public class RoleVM
    {
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = "Role name is required.")]
        [Display(Name = "Role Name")]
        public string Name { get; set; } = string.Empty;

        public int UsersCount { get; set; }
    }
}
