using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ShoppingChartRepository : Repository<ShoppingChart>, IShoppingChartRepository
    {
        private ApplicationDbContext _db;
        public ShoppingChartRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

    }
}
