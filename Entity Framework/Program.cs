using Entity_Framework.DAL;
using Entity_Framework.Exceptionss;
using Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AddPost();
            // GetAllPosts();
            // EditPostTitle(1,"");
            // DeletePost(1);
            GetPostById(null);
        }
        static void AddPost()
        {
            Post post = new Post()
            {
                Title = "How to write stronger blog post titles",
                Content = "Avoid words that sound like spam",
                Image = "better-blog-post-titles-learn-something-new-1.png"
            };
            using (AppDbContext dbContext=new AppDbContext())
            {
                dbContext.Posts.Add(post);
                dbContext.SaveChanges();
            }
            Console.WriteLine($"{post.Posts} created");
        }
        static void GetAllPosts()
        {
            using (AppDbContext dbContext = new AppDbContext())
            {
               List<Post>posts= dbContext.Posts.ToList();
                Console.WriteLine($"Post list:");
                foreach (var item in posts)
                {
                    Console.WriteLine($"{item.Id}{". "}{item.Title}{"!   "}{item.Content}{"!   "}{item.Image}");
                }
            }
        }
        static void EditPostTitle(int?Id,string title)
        {
            if (Id==null)
            {
                throw new System.NullReferenceException("Id null ola bilmez!!!");
            }
            using (AppDbContext dbContext = new AppDbContext())
            {
                Post dbPost=dbContext.Posts.FirstOrDefault(x => x.Id == Id);
                if (dbPost==null)
                {
                    throw new NotFoundException("Post tapilmadi....");
                }
                dbPost.Title = "The title value has changed";
                dbContext.SaveChanges();
                Console.WriteLine($"{dbPost.Title} PROCESS SUCCESSFUL....");


            }
        }
        static void DeletePost(int? Id)
        {
            if (Id == null)
            {
                throw new System.NullReferenceException("Id null ola bilmez!!!");
            }
            using (AppDbContext dbContext = new AppDbContext())
            {
                Post dbPost = dbContext.Posts.FirstOrDefault(x => x.Id == Id);
                if (dbPost == null)
                {
                    throw new NotFoundException("Post tapilmadi....");
                }
                dbContext.Posts.Remove(dbPost);
                dbContext.SaveChanges ();
                Console.WriteLine($"{dbPost.Title} Removed....");
            }
        }
        static void GetPostById(int? Id)
        {
            if (Id == null)
            {
                throw new System.NullReferenceException("Id null ola bilmez!!!");
            }
            using (AppDbContext dbContext = new AppDbContext())
            {
                Post dbPost = dbContext.Posts.FirstOrDefault(x => x.Id == Id);
                if (dbPost == null)
                {
                    throw new NotFoundException("Post tapilmadi....");
                }
               
                dbContext.SaveChanges();
                Console.WriteLine($"{dbPost.Title}{"  "}{dbPost.Content}{"  "}{dbPost.Image} PROCESS SUCCESSFUL....");

            }
        }
    }
}
