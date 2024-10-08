﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodieHub_API.Data.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string CategoryName {  get; set; }

        [Column(TypeName = "varchar(255)")]
        public string ImageURL {  get; set; }

        public bool Status { get; set; } = false;

        public bool IsDeleted { get; set; } = false;

        // Collection Link
        public ICollection<Recipe> Recipes { get; set; }
    }
}
