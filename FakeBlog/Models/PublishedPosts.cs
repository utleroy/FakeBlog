using System.ComponentModel.DataAnnotations;

namespace FakeBlog.Models
{
    public class PublishedPosts
    {
        [Key]
        public int idPublishedPosts { get; set; }

        public string Title { get; set; }
    }
}