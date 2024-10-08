﻿using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieHub_API.Data.Entities
{
    public class RecipeReport
    {
        public DateTime Created_At { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(255)")]
        public string ReportContext { get; set; }

        public bool IsRead { get; set; } = false;

        [Column(TypeName = "varchar(20)")]
        public string Status { get; set; } = "proccess";

        public DateTime? Handled_At { get; set; }

        // Foreign Key Property
        [Column(TypeName = "nvarchar(450)")]
        public string ReporterID { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string? HandlerID { get; set; }

        public int RecipeID { get; set; }

        // Foreign Key Link

        public Recipe Recipe { get; set; }

        public ApplicationUser Reporter { get; set; }

        public ApplicationUser? Handler { get; set; }
    }
}
