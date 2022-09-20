using Microsoft.EntityFrameworkCore;
using EShop2.Models;


namespace EShop2.DataAccess
{
    //Dbcontext ได้มาจาก Microsoft.EntityFrameworkCore ทำหน้าที่ประมวลผล Query และออกมาในรูปของ Entity Framework
    public class TblUserContext : DbContext
    {

        public TblUserContext(DbContextOptions<TblUserContext> options) :base(options)
        {
        }

        public DbSet<TBLUSER> Tbluser { get; set; }
    }
}
