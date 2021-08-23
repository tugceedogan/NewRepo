using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.TagHelpers
{
    [HtmlTargetElement("deneme")]
    public class Paragraf : TagHelper
    {
        public string GelenData { get; set; } = "tuğçe doğan";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string data = string.Empty;
            data = "<p> <b>" +GelenData + "</b> </p>";
            output.Content.SetHtmlContent(data);
            base.Process(context, output);
        }
    }
}
