using DataAccess.Context;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly AppDbContext _dbContext;

        public ItemsRepository(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Items Add(Items item)
        {
            _dbContext.Item.Add(item);
            _dbContext.SaveChanges();
            return item;
        }

        public Items Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List <Items> GetAll()
        {
            return _dbContext.Item.ToList();
        }

        public Items GetItems(int id)
        {
            return _dbContext.Item.Find(id);
        }

        public Items Update(Items item)
        {
            throw new NotImplementedException();
        }
    }
}
