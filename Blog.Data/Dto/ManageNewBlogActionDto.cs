
using System.ComponentModel.DataAnnotations;

namespace Blog.Data.Dto
{
    public class ManageNewBlogActionDto
    {
        [Required]
        public int CategoryId { get; set; }
        [Required,MinLength()]
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
