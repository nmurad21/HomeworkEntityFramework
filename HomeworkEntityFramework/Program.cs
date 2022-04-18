using HomeworkEntityFramework.Exceptions;
using HomeworkEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using NullReferenceException = HomeworkEntityFramework.Exceptions.NullReferenceException;

namespace HomeworkEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Post post = new Post();
            //post.Content = "Salam";
            //post.Image = "image5.pgn";
            //post.Title = "Xos geldiz";
            //post.AddPost(post);
           // GetAllPosts();
        }
        public void AddPost(Post post)
        {
            using (BlogContext blog = new BlogContext())
            {
                blog.Posts.Add(post);
                blog.SaveChanges();
            }
            Console.WriteLine("Yeni post elave olundu");
        }
        public void EditPostTitle(int? Id, string title)
        {
            if (Id == null)
            {
                throw new NullReferenceException("Null ola bilmez");
            }
            using (BlogContext blog = new BlogContext())
            {
                Post post = blog.Posts.FirstOrDefault(post => post.Id == Id);
                if (post!=null)
                {
                    post.Title = title;
                    blog.SaveChanges();
                    Console.WriteLine("Deyisildi");
                    return;
                }
                else
                {
                    throw new NotFoundException("Error");
                }
            }
        }
        public void GetPostById(int? Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException("Null ola bilmez");
            }
            using (BlogContext blog = new BlogContext())
            {
                Post post = blog.Posts.FirstOrDefault(post => post.Id == Id);
                if (post != null)
                {
                    Console.WriteLine($"{post.Id} {post.Content} {post.Image} {post.Title}");
                    return;
                }
                else
                {
                    throw new NotFoundException("Error");
                }
            }
        }
        public static void GetAllPosts()
        {
            using (BlogContext blog = new BlogContext())
            {
                List<Post> posts = blog.Posts.ToList();
                foreach (var item in posts)
                {
                    Console.WriteLine($" {item.Id} {item.Content} {item.Image} {item.Title}");
                }
            }
        }
        public static void DeletePost(int? Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException("Null ola bilmez");
            }
            using (BlogContext blog = new BlogContext())
            {
                Post post = blog.Posts.FirstOrDefault(post => post.Id == Id);
                if (post != null)
                {
                    blog.Posts.Remove(post);
                    blog.SaveChanges();
                    Console.WriteLine("Delete olundu");
                    return;
                }
                else
                {
                    throw new NotFoundException("Error");
                }
            }
        }
    }
}
