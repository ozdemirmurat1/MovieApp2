using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Business.Helpers
{
    public interface ICacheManager
    {
        T Get<T>(string key);

        void Set(string key, object data);

        void Delete(string key);

        void Clear();

        void Clear(string header);
    }
}
