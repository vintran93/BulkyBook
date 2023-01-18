﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyBookWeb.Models;
public class Category
{
        [Key]
        public int Id { get; set; } // primary key
        [Required] // not nullable
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage = "Display Order must be between 1 and 100 only!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}

