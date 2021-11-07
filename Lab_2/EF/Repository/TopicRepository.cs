using Lab_2.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_2.EF.Repository
{
    public class TopicRepository : Repository<Topic>, ITopicRepository
    {
        public long GetTopicIdByName(string name)
        {
            return _dbContext.Set<Topic>().Where(y => y.Name == name).First().Id;
        }
    }
}
