using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.Detection.Services;

namespace Mobile_Redirection_Subfolder
{
    public class MobileRedirectAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var path = filterContext.HttpContext.Request.Path.ToString();
            if (IsMobile())
            {
                filterContext.HttpContext.Response.Redirect("/mobile" + path);
            }

            bool IsMobile()
            {
                //istegin mobile olup olmadigi bilgisi user-agent'tan alinabilir. ama her cihaz icin mobil bilgisini farkli sekilde almak gerekiyor. 
                //nugette pauni yuksek bir kutuphane olan Wangkanai.Detection ile bu kismi sadelestirdim.
                var service = (DetectionService)filterContext.HttpContext.RequestServices.GetService(typeof(IDetectionService));
                var deviceType= service.Device.Type;
                return deviceType == Wangkanai.Detection.Models.Device.Mobile;
            }
        }
    }
}
