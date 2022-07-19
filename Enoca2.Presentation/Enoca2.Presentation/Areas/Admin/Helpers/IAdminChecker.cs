using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enoca2.Presentation.Areas.Admin.Helpers
{
    public interface IAdminChecker
    {
        bool Check(HttpRequest request);
    }
}
