

namespace Blog.Data.Dto
{
   public class BlogAddCommentDto
    {
        public int BlogId { get; set; }
        public int? ParetnCommentId { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
    }
}
