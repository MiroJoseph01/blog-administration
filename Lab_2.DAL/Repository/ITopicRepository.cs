using Lab_2.DAL.Entities;

namespace Lab_2.DAL.Repository
{
    public interface ITopicRepository : IRepository<Topic>
    {
        long GetTopicIdByName(string Name);
    }
}
