using Lab_2.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2.DAL.Repository
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public override IEnumerable<Post> GetAll()
        {
            return _dbContext.Set<Post>()
                .Include(x => x.Author)
                .Include(x => x.Topic)
                    .ToList();
        }

        public override Post Get(long id)
        {
            return _dbContext.Set<Post>()
                .Include(x => x.Author)
                .Include(x => x.Topic)
                    .FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Post> GetPostListByAuthorId(long authorId)
        {
            return _dbContext.Set<Post>()
                .Include(x => x.Author)
                .Include(x => x.Topic)
                    .Where(x => x.AuthorId == authorId).ToList();
        }

        public IEnumerable<Post> GetPostListByTopicId(long topicId)
        {
            return _dbContext.Set<Post>()
                .Include(x => x.Author)
                .Include(x => x.Topic)
                    .Where(x => x.TopicId == topicId)
                        .ToList();
        }
    }
}
