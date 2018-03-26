using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEST_true.Models;

namespace TEST_true.Services
{
    public interface IFind
    {
        post GetPost_with(int post_Id);
        List<post> GetNoCommentPosts();
        List<post> GetCommentPosts();
    };
}
