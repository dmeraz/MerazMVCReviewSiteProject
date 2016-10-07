using System.Web;
using System.Web.Mvc;

namespace MerazMVCReviewSiteProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
