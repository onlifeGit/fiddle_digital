using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.Models.DBModels
{
    public class Article
    {
        public Guid Id { set; get; }

        public string Title { set; get; }

        public string Body { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime? IsDisabled { set; get; }

        public int SOrder { set; get; }
    }
}
