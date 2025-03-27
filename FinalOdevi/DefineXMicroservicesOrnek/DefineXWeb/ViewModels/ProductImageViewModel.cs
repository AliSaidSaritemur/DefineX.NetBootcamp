namespace DefineXWeb.ViewModels
{
    public class ProductImageViewModel
    {
        public int image_id { get; set; }
        public int id { get; set; }
        public string alt { get; set; }
        public string src { get; set; }
        public int[] variant_id { get; set; }
        public string base64 { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
