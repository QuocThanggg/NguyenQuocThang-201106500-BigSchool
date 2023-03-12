using System.Web;
using System.Web.Mvc;

namespace NguyenQuocThang_201106500
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
