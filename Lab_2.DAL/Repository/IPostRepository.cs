using Lab_2.DAL.Entities;
using System.Collections.Generic;

namespace Lab_2.DAL.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetPostListByAuthorId(long authorId);

        IEnumerable<Post> GetPostListByTopicId(long topicId);

    }
}
