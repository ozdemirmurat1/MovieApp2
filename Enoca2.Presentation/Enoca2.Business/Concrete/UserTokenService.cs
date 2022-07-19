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
    public class UserTokenService : IUserTokenService
    {
        private readonly IUserTokenDal _userTokenDal;
        private readonly ICacheManager _cacheManager;

        public UserTokenService(IUserTokenDal userTokenDal, ICacheManager cacheManager)
        {
            _userTokenDal = userTokenDal;
            _cacheManager = cacheManager;
        }

        public void Add(string token, int userId)
        {
            var tokenData = new UserToken()
            {
                CreateDate = DateTime.Now,
                TokenKey = token,
                Status = true,
                UserId = userId
            };
            _userTokenDal.Add(tokenData);
        }

        public void Delete(UserToken userToken)
        {
            _userTokenDal.Delete(userToken);
        }

        public UserToken Get(string token)
        {
            var userToken = _userTokenDal.Get(x => x.TokenKey == token);
            return userToken;
        }

        public UserToken GetById(int Id)
        {
            return _userTokenDal.Get(x => x.Id == Id);
        }

        public int GetTokenUserId(string token)
        {
            var tokenData = _userTokenDal.Get(x => x.TokenKey == token && x.Status != false);

            if (tokenData == null)
            {
                return 0;
            }
            else
            {
                return tokenData.UserId;
            }
        }

        public List<UserToken> List()
        {
            var cacheData = _cacheManager.Get<List<UserToken>>("userToken.list");
            if (cacheData==null)
            {
                var data = _userTokenDal.List();
                _cacheManager.Set("userToken.list", data);
                return data;
            }
            else
            {
                return cacheData;
            }
        }
    }
}
