using Lab_2.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2.EF.Repository
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
