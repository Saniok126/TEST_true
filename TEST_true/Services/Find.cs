using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST_true.Models;

namespace TEST_true.Services
{
    public class Find : IFind
    {
        Database db;
        public Find ( Database context)
        {
            db = context;
            
        }
        public post GetPost_with(int post_Id)
        {          
            var post1 = db.Posts.Where(x => x.ID == post_Id).Single();
            post1.comments = new List<comment>();
            post1.comments.AddRange(db.Comments.Where(x => x.post_ID == post_Id).ToList());
            return post1;
        }
        public List<post> GetNoCommentPosts()
        {
  
            List <int> PostsWithCommentsIds = db.Comments.Select(x => x.post_ID).ToList();
            var PostsWithoutComments = db.Posts.Where(post => !PostsWithCommentsIds.Contains(post.ID));
            return PostsWithoutComments.ToList();
        }
        public List<post> GetCommentPosts()
        {         
            List <int> PostsWithCommentsIds = db.Comments.Select(x => x.post_ID).ToList();
            var PostsWithComments = db.Posts.Where(post => PostsWithCommentsIds.Contains(post.ID));
            foreach (post commented_post in PostsWithComments)
            {
                commented_post.comments = new List<comment>();
                commented_post.comments.AddRange(db.Comments.Where(x => x.post_ID == commented_post.ID).ToList());
            }
            return PostsWithComments.ToList();
        }
    }
}
