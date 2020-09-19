using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using fiddle_digital.Models;
using AutoMapper;
using fiddle_digital.Infrustructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using fiddle_digital.ViewModels;
using Newtonsoft.Json;

namespace fiddle_digital.Controllers
{
    public class HomeController : Controller
    {
        private SqlContext _db;
        private IMapper _mapper;
        private FileManager _fileManager;
        private IHostingEnvironment _appEnvironment;

        public HomeController(SqlContext db, IMapper mapper, FileManager fileManager, IHostingEnvironment appEnvironment)
        {
            _db = db;
            _mapper = mapper;
            _fileManager = fileManager;
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View(); 
        }

        /// <summary>
        /// Gets all projects in dictionary
        /// </summary>
        /// <remarks>
        /// Response: projects
        /// </remarks>
        /// <returns>projects</returns>
        [HttpGet("/home/get_projects")]
        public async Task<JsonResult> GetProjects()
        {
            var projectListDB = await _db.Projects
                .Where(t => !t.IsDisabled.HasValue)
                .ToListAsync();

            var projectListVM = _mapper.Map<IEnumerable<ProjectSVM>>(projectListDB).ToList();

            Dictionary<int, List<ProjectSVM>> projects = projectListVM.GroupBy(t => t.ReleaseYear.Year)
                                                                        .OrderByDescending(t => t.Key)
                                                                        .ToDictionary(t => t.Key, t => t.ToList());

            return Json(projects);
        }

        /// <summary>
        /// Gets details of project by id
        /// </summary>
        /// <remarks>
        /// Response: project
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>project</returns>
        [HttpPost("/home/get_project_details")]
        public async Task<JsonResult> GetProjectDetails(Guid id)
        {
            var projectListDB = await _db.Projects
                .Where(t => !t.IsDisabled.HasValue)
                .OrderByDescending(t => t.ReleaseYear)
                .ToListAsync();

            if(projectListDB == null || projectListDB.Count == 0)
                return Json(string.Empty);

            var projectList = projectListDB
                .TakeWhile((e, i) => i >= 2 ? projectListDB[i - 2].Id != id : true)
                .Reverse()
                .Take(3)
                .ToList();

            var projectListVM = _mapper.Map<IEnumerable<ProjectVM>>(projectList);

            var currentProject = projectListVM.FirstOrDefault(t => t.Id == id);

            ProjectEVM project = new ProjectEVM()
            {
                Project = currentProject,
                NextProjectId = projectListVM.FirstOrDefault(t => t.ReleaseYear > currentProject.ReleaseYear)?.Id,
                PreviousProjectId = projectListVM.FirstOrDefault(t => t.ReleaseYear < currentProject.ReleaseYear)?.Id
            };

            return Json(project);
        }

        /// <summary>
        /// Gets last project by date
        /// </summary>
        /// <remarks>
        /// Response: lastProject
        /// </remarks>
        /// <returns>lastProject</returns>
        [HttpGet("/home/get_last_project")]
        public async Task<JsonResult> GetLastProject()
        {
            var lastProjectDB = await _db.Projects
                .Where(t => !t.IsDisabled.HasValue)
                .OrderByDescending(t => t.ReleaseYear)
                .FirstOrDefaultAsync();

            var lastProject = _mapper.Map<ProjectVM>(lastProjectDB);

            return Json(lastProject);
        }

        /// <summary>
        /// Gets article by id
        /// </summary>
        /// <remarks>
        /// Response: article
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>article</returns>
        [HttpPost("/home/get_article")]
        public async Task<JsonResult> GetArticle(Guid id)
        {
            var articleDB = await _db.Articles.FirstOrDefaultAsync(t => t.Id == id);

            var article = _mapper.Map<ArticleVM>(articleDB);

            return Json(article);
        }

        /// <summary>
        /// Gets all projects group by date in dictionary
        /// </summary>
        /// <remarks>
        /// Response: articles
        /// </remarks>
        /// <returns>articles</returns>
        [HttpGet("/home/get_articles")]
        public async Task<JsonResult> GetArticles()
        {
            var articlesDB = await _db.Articles
                .Where(t => !t.IsDisabled.HasValue)
                .ToListAsync();

            var articlesVM = _mapper.Map<IEnumerable<ArticleSVM>>(articlesDB);

            Dictionary<int, List<ArticleSVM>> articles = articlesVM.GroupBy(t => t.CreatedOn.Year)
                                                                   .OrderByDescending(t => t.Key)
                                                                   .ToDictionary(t => t.Key, t => t.ToList());

            return Json(articles);
        }
    }
}
