using RistoranteMVC.Contracts;
using RistoranteMVC.Models;

namespace RistoranteMVC.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(RistoranteMVCDbContext dbContext) : base(dbContext)
        {

        }
    }
}
