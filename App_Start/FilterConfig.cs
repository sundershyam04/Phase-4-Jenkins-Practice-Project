using System.Web;
using System.Web.Mvc;

namespace Phase_4_Jenkins_Practice_Project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
