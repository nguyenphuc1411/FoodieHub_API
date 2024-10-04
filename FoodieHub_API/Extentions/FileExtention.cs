namespace FoodieHub_API.Extentions
{
    public static class FileExtention
    {
        // Các định dạng hình ảnh hỗ trợ
        private static readonly string[] AllowedImageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff" };

        // Phương thức mở rộng kiểm tra file ảnh
        public static bool IsImage(this IFormFile file)
        {
            // Kiểm tra xem file có null không
            if (file == null || file.Length == 0)
                return false;

            // Kiểm tra định dạng phần mở rộng
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (AllowedImageExtensions.Contains(extension))
                return true;
            return false;
        }
    }
}
