using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.ViewModels
{
    public class ProjectSVM
    {
        public Guid? Id { set; get; }

        public string Title { set; get; }

        public string PreviewPhotoPath { set; get; }

        public DateTime ReleaseYear { set; get; }
    }
}
