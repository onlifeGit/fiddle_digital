using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.Models.DBModels
{
    public class ContactForm
    {
        public Guid Id { set; get; }

        public string Name { set; get; }

        public string Phone { set; get; }

        public string Email { set; get; }

        public string Message { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime? IsDisabled { set; get; }

        public int SOrder { set; get; }
    }
}
