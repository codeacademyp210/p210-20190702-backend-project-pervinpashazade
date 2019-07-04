using System.Web;
using System.Web.Mvc;

namespace BackendProject_03._07._2019_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
