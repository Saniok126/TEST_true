using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST_true.Models;

namespace TEST_true
{
    public class SampleData
    {
        public static void Initialize(Database context)
        {
            if (!context.Posts.Any())
            {
                context.Posts.AddRange(
                    new post
                    {
                        name = "Hello world",
                        author = "Alex",
                        text = "Hello world"
                    },
                    new post
                    {
                        name = "Hello again",
                        author = "Sasha",
                        text = "Hello friends"
                    },
                    new post
                    {
                        name = "Good Luck",
                        author = "Kate",
                        text = "Welcome back"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Comments.Any())
            {
                context.Comments.AddRange(
                    new comment
                    {
                        post_ID = 1,
                        author = "Alex",
                        text = "Impressive!"
                    },
                    new comment
                    {
                        post_ID = 2,
                        author = "Sasha",
                        text = "Awesome!"
                    },
                     new comment
                     {
                         post_ID = 1,
                         author = "Dima",
                         text = "That`s good!"
                     }
                );
                context.SaveChanges();
            }
        }
        
    }
}
