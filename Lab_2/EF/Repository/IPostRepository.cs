using Lab_2.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2.EF.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetPostListByAuthorId(long authorId);

        IEnumerable<Post> GetPostListByTopicId(long topicId);

    }
}
