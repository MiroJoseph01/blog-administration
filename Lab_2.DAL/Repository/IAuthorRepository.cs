using Lab_2.DAL.Entities;

namespace Lab_2.DAL.Repository
{
    public interface IAuthorRepository : IRepository<Author>
    {
        long GetAuthorIdByName(string Name);
    }
}
