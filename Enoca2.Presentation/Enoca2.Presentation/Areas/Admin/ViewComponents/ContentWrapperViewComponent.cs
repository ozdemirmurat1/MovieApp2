﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enoca2.Presentation.Areas.Admin.ViewComponents
{
    public class ContentWrapperViewComponent:ViewComponent
    {
       public ContentWrapperViewComponent()
        {

        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
