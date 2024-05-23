using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepo
    {

        Users GetUsers(int Id);
        Users Add(Users Users);

        List<Users> GetAll();
        Users LoggedInUser(string username, string password);
    }

        
}
