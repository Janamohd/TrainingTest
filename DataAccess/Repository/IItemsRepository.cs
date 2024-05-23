using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IItemsRepository
    {
        List<Items> GetAll();
        Items Add(Items item);
        Items Delete(int id);
        Items Update(Items item);
    }
}
