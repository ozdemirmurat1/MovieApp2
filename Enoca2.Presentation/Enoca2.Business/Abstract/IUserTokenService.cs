using Enoca2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Business.Abstract
{
    public interface IUserTokenService
    {
        void Add(string token, int userId);

        int GetTokenUserId(string token);

        UserToken Get(string token);

        List<UserToken> List();

        UserToken GetById(int Id);

        void Delete(UserToken userToken);
    }
}
