using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test1.Common
{
    public static class CustomHelpers
    {
        public static MvcHtmlString StripHtml(this HtmlHelper html, string input)
        {
            return new MvcHtmlString(System.Text.RegularExpressions.Regex.Replace(input, "<.*?>", string.Empty));
        }
    }
}