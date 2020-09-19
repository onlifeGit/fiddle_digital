using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Login required!!!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password required!!!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
