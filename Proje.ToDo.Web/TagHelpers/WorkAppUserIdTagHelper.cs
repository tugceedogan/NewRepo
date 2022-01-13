using Microsoft.AspNetCore.Razor.TagHelpers;
using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.TagHelpers
{
    [HtmlTargetElement("getirGorevAppUserId")]
    public class WorkAppUserIdTagHelper: TagHelper
    {
        private readonly IWorkService _workService;
        public WorkAppUserIdTagHelper(IWorkService workService)
        {
            _workService = workService;
        }
        public int AppUserId { get; set; }
        public virtual void Process(TagHelperContext context, TagHelperOutput output)
        {
            List<Work> works= _workService.GetirileAppUserId(AppUserId);
            int tamamlananGorevSayisi= works.Where(I => I.State).Count();
            int ustundeCalistigiGorevSayisi = works.Where(I => !I.State).Count();

            string htmlString = $"<strong> Tamamlandığı görev sayısı: </strong> ${tamamlananGorevSayisi} <br> <strong>Üstünde çalıştığı görev sayısı:</strong>{ustundeCalistigiGorevSayisi}";
            output.Content.SetHtmlContent(htmlString);
        }
    }
}
