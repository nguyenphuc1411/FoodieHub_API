namespace FoodieHub_API.DTOs
{
    public class APIResponse<T>
    {
        public bool Success { get; set; }

        public string Message { get; set; } // Thông điệp trả về

        public T? Data { get; set; } // Dữ liệu trả về

        public int StatusCode {  get; set; } // Status Code trả về. Trả về đúng status theo trường hợp.

    }
}
