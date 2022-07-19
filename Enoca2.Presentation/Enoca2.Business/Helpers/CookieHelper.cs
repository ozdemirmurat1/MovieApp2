﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enoca2.Business.Helpers
{
    public class CookieHelper : ICookieHelper
    {
        public void Add(CookieTypes name, string value, DateTime expiredDate, HttpResponse response)
        {
            response.Cookies.Append(name.ToString(), value, new CookieOptions()
            {
                Expires=DateTime.Now.AddYears(10)

            });
        }

        public void Delete(CookieTypes name, HttpResponse response)
        {
            Add(name, "", DateTime.Now.AddYears(-10), response);
        }

        public string Get(CookieTypes name, HttpRequest request)
        {
            try
            {
                return request.Cookies[name.ToString()];
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
