using AutoMapper;
using fiddle_digital.Models.DBModels;
using fiddle_digital.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.Infrustructure
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            #region Project

            CreateMap<Project, ProjectVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn))
                .ForMember(dest => dest.IsDisabled, opt => opt.MapFrom(src => src.IsDisabled.HasValue));

            CreateMap<ProjectCVM, Project>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.HasValue ? src.Id.Value : Guid.NewGuid()))
                .ForMember(dest => dest.IsDisabled, opt => opt.MapFrom(src => src.IsDisabled ? DateTime.Now : new DateTime?()))
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn.HasValue ? src.CreatedOn.Value : DateTime.Now));

            CreateMap<Project, ProjectCVM>()
                .ForMember(dest => dest.IsDisabled, opt => opt.MapFrom(src => src.IsDisabled.HasValue));
            #endregion

            #region ServiceEmail

            CreateMap<ServiceEmail, ServiceEmailVM>()
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn))
                .ForMember(dest => dest.IsDisabled, opt => opt.MapFrom(src => src.IsDisabled.HasValue));

            CreateMap<ServiceEmailCVM, ServiceEmail>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.HasValue ? src.Id.Value : Guid.NewGuid()))
                .ForMember(dest => dest.IsDisabled, opt => opt.MapFrom(src => src.IsDisabled ? DateTime.Now : new DateTime?()))
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn.HasValue ? src.CreatedOn.Value : DateTime.Now));

            CreateMap<ServiceEmail, ServiceEmailCVM>()
                .ForMember(dest => dest.IsDisabled, opt => opt.MapFrom(src => src.IsDisabled.HasValue));
            #endregion

            #region ContactForm

            CreateMap<ContactFormVM, ContactForm>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.HasValue ? src.Id.Value : Guid.NewGuid()))
                .ForMember(dest => dest.IsDisabled, opt => opt.MapFrom(src => src.IsDisabled ? DateTime.Now : new DateTime?()))
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn.HasValue ? src.CreatedOn.Value : DateTime.Now));
            #endregion

            #region Article
            CreateMap<Article, ArticleVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn))
                .ForMember(dest => dest.IsDisabled, opt => opt.MapFrom(src => src.IsDisabled.HasValue));

            CreateMap<ArticleCVM, Article>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.HasValue ? src.Id.Value : Guid.NewGuid()))
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => src.CreatedOn.HasValue ? src.CreatedOn.Value : DateTime.Now))
                .ForMember(dest => dest.IsDisabled, opt => opt.MapFrom(src => src.IsDisabled ? DateTime.Now : new DateTime?()));

            #endregion
        }
    }
}
