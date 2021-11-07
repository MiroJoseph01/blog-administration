using Lab_2.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Lab_2.EF.Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public long GetAuthorIdByName(string name)
        {
            var nameSurname = name.Split(' ', 2);
            var authorId = _dbContext.Set<Author>()
                .Where(y => y.Name == nameSurname[0] && y.Surname == nameSurname[1])
                .First().Id;

            return authorId;
        }
    }
}
