using Lab4_23.Data;
using Lab4_23.Helpers.Extensions;
using Lab4_23.Models;
using Lab4_23.Repositories.GenericRepository;
using Lab4_23.Repositories.UserRepository;

namespace Lab4_23.Repositories.CarsRepository
{
    public class CarsRepository : GenericRepository<Cars>, IUserRepository
    {
    }
}
