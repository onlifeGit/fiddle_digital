using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.ViewModels
{
    public class ArticleSVM
    {
        public Guid? Id { set; get; }

        public string Title { set; get; }

        public DateTime CreatedOn { set; get; }

    }
}
