using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.ViewModels
{
    public class ProjectVM
    {
        [ScaffoldColumn(false)]
        public Guid? Id { set; get; }

        public string Title { set; get; }

        [DataType(DataType.MultilineText)]
        public string Description { set; get; }

        public string ProjectLink { set; get; }

        public string ProjectLinkTitle { set; get; }

        public string VideoLink { set; get; }

        public string BehanceLink { set; get; }

        [Display(Name = "Banner Photo")]
        public string BannerPhotoPath { set; get; }

        [Display(Name = "Preview Photo")]
        public string PreviewPhotoPath { set; get; }

        [DataType(DataType.DateTime)]
        public DateTime ReleaseYear { set; get; }

        [ScaffoldColumn(false)]
        public DateTime CreatedOn { set; get; }

        public bool IsDisabled { set; get; }

        public int? SOrder { set; get; } 
    }
}
