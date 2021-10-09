using System.Web;
using System.Web.Mvc;

namespace BaiTap3_61133644
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
