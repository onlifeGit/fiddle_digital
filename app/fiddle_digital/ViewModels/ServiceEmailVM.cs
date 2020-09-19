using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.ViewModels
{
    public class ServiceEmailVM
    {
        [ScaffoldColumn(false)]
        public Guid? Id { set; get; }

        public string Email { set; get; }

        public string Password { set; get; }

        public DateTime? CreatedOn { set; get; }

        public bool IsDisabled { set; get; }

        public int? SOrder { set; get; }
    }
}
