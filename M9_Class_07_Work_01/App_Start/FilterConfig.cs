﻿using System.Web;
using System.Web.Mvc;

namespace M9_Class_07_Work_01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
