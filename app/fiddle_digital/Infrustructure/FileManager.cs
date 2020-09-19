using fiddle_digital.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace fiddle_digital.Infrustructure
{
    public class FileManager
    {
        public async Task<string> UploadFile(string rootDirectory, string recordFolderName, IFormFile file)
        {
            var format = file.Headers["Content-Type"];
            string directory = string.Empty;
            string path = string.Empty;

            if (format == "application/pdf")
            {
                path = $"/Files/Presentation/file.pdf";

                //check on existing file and delete old file
                File.Delete(rootDirectory + path);
            }
            else
            {
                directory = $"/Files/{recordFolderName}";
                path = $"{directory}/{file.FileName}";

                if (!Directory.Exists(rootDirectory + directory))
                    Directory.CreateDirectory(rootDirectory + directory);
            }

            try
            {
                //save file into folder                                      
                using (var filestream = new FileStream(rootDirectory + path, FileMode.Create))
                    await file.CopyToAsync(filestream);

                return path;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }

        public void DeleteFile(string rootPath, string filePath)
        {
            string path = $"{rootPath}/{filePath}";

            if (File.Exists(path))
                File.Delete(path);
        }

        public void DeleteFolder(string rootPath, string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                string path = $"{rootPath}/{filePath}";

                int idx = path.LastIndexOf('/');

                if (idx != -1)
                {
                    var dir = new DirectoryInfo(path.Substring(0, idx));
                    dir.Delete(true);
                }
            }
        }
    }
}
