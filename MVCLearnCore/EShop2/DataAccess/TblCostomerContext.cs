using Microsoft.EntityFrameworkCore;
using EShop2.Models;

namespace EShop2.DataAccess
{
    public class TblCostomerContext :DbContext
    {
        public TblCostomerContext(DbContextOptions<TblCostomerContext> options) : base(options)
        {



        }

        public DbSet<TBLCUSTOMER> Tblcustomer { get; set; }
    }
}
