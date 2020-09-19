using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using fiddle_digital.Infrustructure;
using fiddle_digital.Models;
using fiddle_digital.Models.DBModels;
using fiddle_digital.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fiddle_digital.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ArticleController : Controller
    {
        private SqlContext _db;
        private IMapper _mapper;
        private FileManager _fileManager;
        private IHostingEnvironment _appEnvironment;

        public ArticleController(SqlContext context, IMapper mapper, FileManager fileManager, IHostingEnvironment appEnvironment)
        {
            _db = context;
            _mapper = mapper;
            _fileManager = fileManager;
            _appEnvironment = appEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var articleList = await _db.Articles.ToListAsync();

            return View(_mapper.Map<IEnumerable<ArticleVM>>(articleList));
        }

        [HttpGet]
        public IActionResult Create()
        {
            var project = new ArticleCVM();

            return View(project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArticleCVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var article = _mapper.Map<Article>(model);

                    _db.Articles.Add(article);
                    await _db.SaveChangesAsync();
                }

                return RedirectToAction(nameof(List));
            }
            catch (Exception e)
            {
                return View(model);
            }
        }

        [HttpPost]
        public async Task<string> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string path = "/Files/" + uploadedFile.FileName.Replace(' ','_');
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                return path;
            }

            return string.Empty;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var article = await _db.Articles.FirstOrDefaultAsync(t => t.Id == id);

            return View(_mapper.Map<ArticleCVM>(article));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ArticleCVM model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var article = _mapper.Map<Article>(model);

                    _db.Articles.Update(article);
                    await _db.SaveChangesAsync();
                }

                return RedirectToAction(nameof(List));
            }
            catch (Exception e)
            {
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var article = await _db.Articles.FirstOrDefaultAsync(t => t.Id == id);

                _db.Articles.Remove(article);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(List));
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(List));
            }
        }
    }
}