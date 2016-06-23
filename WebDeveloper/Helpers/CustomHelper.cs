using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        public static IHtmlString DisplayPriceStatic(double price)
        {
            //if (price == 0.0)
            //    return new HtmlString("<span>: Free!!!</span>");
            //else
            //    return new HtmlString(String.Format("<span>: {0}</span>",price));

            //var result = string.Empty;
            //if (price == 0.0)
            //    result = "<span>Free!!!</span>";
            //else
            //    result = $"<span>{price}</span>";
            //return new HtmlString(result);  
            
            //var result = (price == 0.0)? "<span>: Free!!!</span>" : $"<span>{price}</span>";
            //return new HtmlString(result);

            return new HtmlString(GetHtmlPrice(price));
        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            //var result = string.Empty;
            //if (price == 0.0)
            //    result = "<span>Free!!!</span>";
            //else
            //    result = $"<span>{price}</span>";
            //return new HtmlString(result);

            //var result = (price == 0.0) ? "<span>: Free!!!</span>" : $"<span>{price}</span>";
            //return new HtmlString(result);

            return new HtmlString(GetHtmlPrice(price));
        }

        public static IHtmlString DisplayDateOrNullStatic(DateTime? date)
        {
            //var result = (date == null) ? $"<span>None</span>" : $"<span>{date}</span>";
            //return new HtmlString(result);

            return new HtmlString(GetHtmlDate(date));
        }

        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? date)
        {
            //var result = string.Empty;
            //if (date == null)
            //    result = $"<span>None</span>";
            //else
            //    result = $"<span>{date}</span>";
            //return new HtmlString(result);

            //var result = (date == null) ? $"<span>None</span>" : $"<span>{date}</span>";
            //return new HtmlString(result);

            return new HtmlString(GetHtmlDate(date));
        }

        private static string GetHtmlPrice(double price)
        {            
            return (price == 0.0) ? "<span>: Free!!!</span>" : $"<span>{price}</span>"; 
        }
        private static string GetHtmlDate(DateTime? date)
        {           
            return (date == null) ? $"<span>None</span>" : $"<span>{date}</span>";
        }

    }
}
