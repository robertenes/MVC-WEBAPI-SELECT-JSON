﻿using System.Web;
using System.Web.Mvc;

namespace MVC_WEBAPI_SELECT_JSON
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
