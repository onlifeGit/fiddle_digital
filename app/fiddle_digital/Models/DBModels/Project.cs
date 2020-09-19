using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.Models.DBModels
{
    public class Project
    {
        public Guid Id { set; get; }

        public string Title { set; get; }

        public string Description { set; get; }

        public string ProjectLink { set; get; }

        public string ProjectLinkTitle { set; get; }

        public string VideoLink { set; get; }

        public string BehanceLink { set; get; }

        public string BannerPhotoPath { set; get; }

        public string PreviewPhotoPath { set; get; }

        public DateTime ReleaseYear { set; get; }

        public DateTime CreatedOn { set; get; }

        public DateTime? IsDisabled { set; get; }

        public int? SOrder { set; get; }
    }
}
