using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using fiddle_digital.Models;
using fiddle_digital.Models.DBModels;
using fiddle_digital.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fiddle_digital.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ServiceEmailController : Controller
    {
        private SqlContext _db;
        private IMapper _mapper;

        public ServiceEmailController(SqlContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var list = await _db.ServiceEmails.ToListAsync();

            return View(_mapper.Map<IEnumerable<ServiceEmailVM>>(list));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var serviceEmail = await _db.ServiceEmails.FirstOrDefaultAsync(t => t.Id == id);

            return View(_mapper.Map<ServiceEmailCVM>(serviceEmail));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ServiceEmailCVM model)
        {
            try
            {
                var record = _mapper.Map<ServiceEmail>(model);

                _db.ServiceEmails.Update(record);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(List));
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Edit));
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            var serviceEmail = new ServiceEmailCVM();

            return View(serviceEmail);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ServiceEmailCVM model)
        {
            try
            {
                ServiceEmail serviceEmail = _mapper.Map<ServiceEmail>(model);

                _db.ServiceEmails.Add(serviceEmail);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(List));
            }
            catch (Exception e)
            {
                return RedirectToAction(nameof(Create));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var record = await _db.ServiceEmails.FirstOrDefaultAsync(t => t.Id == id);

                _db.ServiceEmails.Remove(record);
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