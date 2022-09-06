using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IShoppingChartRepository : IRepository<ShoppingChart>
    {
        int IncrementCount(ShoppingChart shoppingChart, int count);
        int DecrementCount(ShoppingChart shoppingChart, int count);

    }
}
