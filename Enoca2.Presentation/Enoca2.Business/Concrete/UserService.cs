using Enoca2.Business.Abstract;
using Enoca2.Business.Helpers;
using Enoca2.DataAccess.Abstract;
using Enoca2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IStringHelper _stringHelper;

        public UserService(IUserDal userDal, IStringHelper stringHelper)
        {
            _userDal = userDal;
            _stringHelper = stringHelper;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User AdminLogin(string username, string password)
        {
            password = _stringHelper.ToMd5(password);
            var result = _userDal.Query(x => x.Email == username && x.Password == password && x.IsAdmin == true).FirstOrDefault();
            if (result==null)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public User GetById(int userId)
        {
            return _userDal.Get(x => x.Id == userId);
        }

        public List<User> List()
        {
            return _userDal.List();
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
