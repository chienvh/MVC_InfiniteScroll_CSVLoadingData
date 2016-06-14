using System.Web.Mvc;

namespace MVC_InfiniteScroll_CSVLoadingData.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}