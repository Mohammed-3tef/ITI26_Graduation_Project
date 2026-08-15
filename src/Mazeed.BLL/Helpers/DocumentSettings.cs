using Microsoft.AspNetCore.Http;

namespace Mazeed.BLL.Helpers
{
    public static class DocumentSettings
    {
        public static string UploadFile(IFormFile file, string folderName)
        {
            // 1. Get folder path: wwwroot/assets/images/{folderName}
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "images", folderName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // 2. Generate unique file name
            string fileName = $"{Guid.NewGuid()}_{Path.GetFileName(file.FileName)}";
            string filePath = Path.Combine(folderPath, fileName);

            // 3. Save file to disk
            using var fileStream = new FileStream(filePath, FileMode.Create);
            file.CopyTo(fileStream);

            return fileName;
        }

        public static void DeleteFile(string fileName, string folderName)
        {
            if (string.IsNullOrEmpty(fileName)) return;

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "images", folderName, fileName);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
