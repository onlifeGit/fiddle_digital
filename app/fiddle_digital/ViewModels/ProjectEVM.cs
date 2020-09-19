using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.ViewModels
{
    public class ProjectEVM
    {
        public ProjectVM Project { set; get; }

        public Guid? NextProjectId { set; get; }

        public Guid? PreviousProjectId { set; get; }
    }
}
