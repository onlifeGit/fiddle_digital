using AutoMapper;
using fiddle_digital.Infrustructure;
using fiddle_digital.Models;
using fiddle_digital.Models.DBModels;
using fiddle_digital.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace fiddle_digital.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProjectController : Controller
    {
        private SqlContext _db;
        private IMapper _mapper;
        private FileManager _fileManager;
        private IHostingEnvironment _appEnvironment;

        public ProjectController(SqlContext context, IMapper mapper, FileManager fileManager, IHostingEnvironment appEnvironment)
        {
            _db = context;
            _mapper = mapper;
            _fileManager = fileManager;
            _appEnvironment = appEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var projectList = await _db.Projects.ToListAsync();

            return View(_mapper.Map<IEnumerable<ProjectVM>>(projectList));
        }

        [HttpGet]
        public IActionResult Create()
        {
            var project = new ProjectCVM();

            return View(project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProjectCVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Project project = _mapper.Map<Project>(model);

                    _db.Projects.Add(project);
                    await _db.SaveChangesAsync();

                    if (model.BannerPhotoFile != null)
                        project.BannerPhotoPath = await _fileManager.UploadFile(_appEnvironment.WebRootPath, project.Id.ToString(), model.BannerPhotoFile);

                    if (model.PreviewPhotoFile != null)
                        project.PreviewPhotoPath = await _fileManager.UploadFile(_appEnvironment.WebRootPath, project.Id.ToString(), model.PreviewPhotoFile);

                    if (model.VideoFile != null)
                        project.VideoLink = await _fileManager.UploadFile(_appEnvironment.WebRootPath, project.Id.ToString(), model.VideoFile);

                    _db.Projects.Update(project);

                    await _db.SaveChangesAsync();

                    return RedirectToAction(nameof(List));
                }

                return RedirectToAction(nameof(Create));
            }
            catch (Exception e)
            {
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var project = await _db.Projects.FirstOrDefaultAsync(t => t.Id == id);

            return View(_mapper.Map<ProjectCVM>(project));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProjectCVM project)
        {
            try
            {
                var record = _mapper.Map<Project>(project);

                if (project.BannerPhotoFile != null)
                {
                    string oldBannerPath = record.BannerPhotoPath;

                    record.BannerPhotoPath = await _fileManager.UploadFile(_appEnvironment.WebRootPath, record.Id.ToString(), project.BannerPhotoFile);

                    if (!string.IsNullOrWhiteSpace(oldBannerPath))
                        _fileManager.DeleteFile(_appEnvironment.WebRootPath, oldBannerPath);
                }

                if (project.PreviewPhotoFile != null)
                {
                    string oldPreviewPath = record.PreviewPhotoPath;

                    record.PreviewPhotoPath = await _fileManager.UploadFile(_appEnvironment.WebRootPath, record.Id.ToString(), project.PreviewPhotoFile);

                    if (!string.IsNullOrWhiteSpace(oldPreviewPath))
                        _fileManager.DeleteFile(_appEnvironment.WebRootPath, oldPreviewPath);
                }

                if (project.VideoFile != null)
                {
                    string oldVideoLink = record.VideoLink;

                    record.VideoLink = await _fileManager.UploadFile(_appEnvironment.WebRootPath, record.Id.ToString(), project.VideoFile);

                    if (!string.IsNullOrWhiteSpace(oldVideoLink))
                        _fileManager.DeleteFile(_appEnvironment.WebRootPath, oldVideoLink);
                }

                _db.Projects.Update(record);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(List));
            }
            catch (Exception e)
            {
                return View(project);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var record = await _db.Projects.FirstOrDefaultAsync(t => t.Id == id);

                _db.Projects.Remove(record);
                await _db.SaveChangesAsync();

                _fileManager.DeleteFolder(_appEnvironment.WebRootPath, record.BannerPhotoPath);
                _fileManager.DeleteFolder(_appEnvironment.WebRootPath, record.PreviewPhotoPath);

                return RedirectToAction(nameof(List));
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(List));
            }
        }
    }
}