using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkEntityFramework.Models
{
   public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public void AddPost(Post post)
        {
            using (BlogContext blog = new BlogContext())
            {
                blog.Posts.Add(post);
                blog.SaveChanges();
            }
            Console.WriteLine("Yeni post elave olundu");
        }
    }
}
