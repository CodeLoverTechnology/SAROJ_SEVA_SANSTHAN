using System.Web;
using System.Web.Mvc;

namespace SAROJ_SEVA_SANSTHAN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
