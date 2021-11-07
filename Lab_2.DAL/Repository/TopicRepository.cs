using Lab_2.DAL.Entities;
using System.Linq;

namespace Lab_2.DAL.Repository
{
    public class TopicRepository : Repository<Topic>, ITopicRepository
    {
        public long GetTopicIdByName(string name)
        {
            return _dbContext.Set<Topic>().Where(y => y.Name == name).First().Id;
        }
    }
}
