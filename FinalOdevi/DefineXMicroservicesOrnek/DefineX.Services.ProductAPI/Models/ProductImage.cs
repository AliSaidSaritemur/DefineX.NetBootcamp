﻿using System.ComponentModel.DataAnnotations;

namespace DefineX.Services.ProductAPI.Models
{
    public class ProductImage
    {
        [Key]
        public int image_id { get; set; }
        public int id { get; set; }
        public string alt { get; set; }
        public string src { get; set; }
        public int[] variant_id { get; set; }
        public string base64 { get; set; }
    }
}
