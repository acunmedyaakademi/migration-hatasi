using System.Globalization;

namespace BasicBlogCms.Models
{
    public class HeaderPartialModel
    {
        public string Title { get; set; }   
        public string Desc { get; set; }
        public string ImageUrl { get; set; } = "/assets/img/home-bg.jpg";
        public bool IsPost { get; set; }
        public DateTime PostDate { get; set; }
        public string? Usarname { get; set; }
        public int UserId { get; set; }
    }
}
