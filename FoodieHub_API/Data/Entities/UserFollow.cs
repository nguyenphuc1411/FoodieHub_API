using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieHub_API.Data.Entities
{
    public class UserFollow
    {
        public DateTime Created_At { get; set; }= DateTime.Now;

        // Foreign Key Property
        [Column(TypeName = "nvarchar(450)")]
        public string FollowerID { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string FollowedID { get; set; }

        // Foreign Key Link

        public ApplicationUser Follower { get; set; }
        public ApplicationUser Followed { get; set; }
    }
}
