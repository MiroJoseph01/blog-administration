using Lab_2.EF.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2.EF.Repository
{
    public interface ITopicRepository : IRepository<Topic>
    {
        long GetTopicIdByName(string Name);
    }
}
