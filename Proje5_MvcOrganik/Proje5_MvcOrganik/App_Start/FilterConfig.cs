using System.Web;
using System.Web.Mvc;

namespace Proje5_MvcOrganik
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
