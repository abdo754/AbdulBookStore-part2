using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AbdulBooks.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Category")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
