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

namespace fiddle_digital.Areas.Admin.Controllers
{
    [Area("Admin")]
    [ApiController]
    [Route("/api")]
    public class ApiController : ControllerBase
    {
        private SqlContext _db;
        private FileManager _fileManager;
        private IHostingEnvironment _appEnvironment;
        private IMapper _mapper;

        public ApiController(SqlContext db, FileManager fileManager, IHostingEnvironment appEnvironment, IMapper mapper)
        {
            _db = db;
            _fileManager = fileManager;
            _appEnvironment = appEnvironment;
            _mapper = mapper;
        }

        /// <summary>
        /// Uploads pdf file
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///      Post/uploadpdf:
        ///      {
        ///         "file": file
        ///      }
        /// </remarks>
        /// <param name="file"></param>
        [Authorize]
        [HttpPost("uploadpdf")]
        public async Task<IActionResult> UploadPDF(IFormFile file)
        {
            try
            {
                if (file != null && file.Headers["Content-Type"] == "application/pdf")
                {
                    await _fileManager.UploadFile(_appEnvironment.WebRootPath, file.FileName, file);
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }

                return BadRequest();
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Opens file in the new tab
        /// </summary>
        /// <returns></returns>
        [HttpGet("get_presentation")]
        public string GetPresentations()
        {
            return "/Files/Presentation/file.pdf";
        }

        /// <summary>
        /// Sends feedback to service email
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     model:
        ///     {
        ///         "Name":"TestName",
        ///         "Phone": "777",
        ///         "Email":"someemail@gmail.com",
        ///         "Message": "Test msg lol"            
        ///     }
        ///     
        /// </remarks>
        /// <param name="model"></param>
        [HttpPost("send_mail")]
        public async Task<IActionResult> SendMail([FromBody]ContactFormVM model)
        {
            //choose service email
            var serviceEmail = _db.ServiceEmails.FirstOrDefault(t => t.IsDisabled == null);
            string messageBody = $"Name: {model.Name}<br>Phone: {model.Phone}<br>Email: {model.Email}<br><br> {model.Message}";

            //save contactform info 
            var contactForm = _mapper.Map<ContactForm>(model);

            _db.ContactForms.Add(contactForm);
            await _db.SaveChangesAsync();

            Mailler mailler = new Mailler();

            await mailler.SendMailAsync(serviceEmail.Email, serviceEmail.Password, "Customer", messageBody);
            return Ok();
        }
    }
}
