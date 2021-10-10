using RistoranteMVC.Contracts;
using RistoranteMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RistoranteMVC.Repositories
{
    public class CouponRepository : BaseRepository<Coupon>, ICouponRepository
    {
        public CouponRepository(RistoranteMVCDbContext dbContext) : base(dbContext)
        {

        }
    }
}
