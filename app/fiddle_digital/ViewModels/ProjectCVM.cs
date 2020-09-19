using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.ViewModels
{
    public class ProjectCVM
    {
        public ProjectCVM()
        {
            ReleaseYear = DateTime.Now;
        }

        [ScaffoldColumn(false)]
        public Guid? Id { set; get; }

        [Required]
        public string Title { set; get; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { set; get; }

        [Required]
        [Url]
        public string ProjectLink { set; get; }

        public string ProjectLinkTitle { set; get; }

        [Url]
        public string VideoLink { set; get; }

        public IFormFile VideoFile { set; get; }

        [Required]
        [Url]
        public string BehanceLink { set; get; }
        
        public IFormFile BannerPhotoFile { set; get; }

        [Display(Name = "Banner Photo")]
        public string BannerPhotoPath { set; get; }

        public IFormFile PreviewPhotoFile { set; get; }
        
        [Display(Name = "Preview Photo")]
        public string PreviewPhotoPath { set; get; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseYear { set; get; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedOn { set; get; }

        public bool IsDisabled { set; get; }

        public int? SOrder { set; get; }
    }
}
