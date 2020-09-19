using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiddle_digital.Helpers
{
    public static class StringHelper
    {
        public static string CutController(this string controllerName)
        {
            return controllerName.ToLower().Split("controller")[0];
        }

        public static string URIBuilder(string areaName, string controllerName, string actionName)
        {
            var sb = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(areaName))
                sb.Append($"/{areaName.ToLower()}");

            if (!string.IsNullOrWhiteSpace(controllerName))
                sb.Append($"/{controllerName.CutController()}");

            if (!string.IsNullOrWhiteSpace(actionName))
                sb.Append($"/{actionName.CutController()}");

            return sb.ToString();
        }
    }
}
