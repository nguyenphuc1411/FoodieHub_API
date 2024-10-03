using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieHub_API.Data.Entities
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Message { get; set; }
        public bool IsRead { get; set; } = false;
        public DateTime Created_At { get; set; }=DateTime.Now;


        // Foreign Key Property
        [Column(TypeName = "nvarchar(450)")]
        public string UserID {  get; set; }

        // Foreign Key Link

        public ApplicationUser User { get; set; }
    }
}
