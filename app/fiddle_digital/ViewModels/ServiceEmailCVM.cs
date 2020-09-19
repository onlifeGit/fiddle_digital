using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.ViewModels
{
    public class ServiceEmailCVM
    {
        [ScaffoldColumn(false)]
        public Guid? Id { set; get; }

        public string Email { set; get; }

        public string Password { set; get; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedOn { set; get; }

        public bool IsDisabled { set; get; }

        public int? SOrder { set; get; }
    }
}
