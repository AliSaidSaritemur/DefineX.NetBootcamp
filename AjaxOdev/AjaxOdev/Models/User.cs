﻿using System.ComponentModel.DataAnnotations;

namespace AjaxOdev.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Surname { get; set; }
        
    }
}
