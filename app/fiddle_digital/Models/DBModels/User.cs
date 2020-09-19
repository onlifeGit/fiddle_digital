using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.Models.DBModels
{
    public class User
    {
        public Guid Id { set; get; }

        public string FName { set; get; }

        public string LName { set; get; }

        public string Login { set; get; }

        public string Password { set; get; }

        public string Email { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime? IsDisabled { set; get; }

        public int SOrder { set; get; }
    }
}
