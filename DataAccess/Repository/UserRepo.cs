using DataAccess.Context;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public  class UserRepo : IUserRepo   
    {
        private readonly AppDbContext _dbContext;

        public UserRepo(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Users Add(Users Users)
        {


            _dbContext.Users.Add(Users);
            _dbContext.SaveChanges();
            return Users ;
        }

        public List<Users> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public Users GetUsers(int Id)
        {
            return _dbContext.Users.Find(Id);

        }

        public Users LoggedInUser(string username, string password)
        {

            var user = _dbContext.Users.FirstOrDefault (e=>e.Username == username && e.Password==password);
            return user;

        }


        }
    }


