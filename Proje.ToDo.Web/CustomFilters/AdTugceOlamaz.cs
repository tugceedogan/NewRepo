using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Proje.ToDo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.CustomFilters
{
    public class AdTugceOlamaz:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionaryGelen = context.ActionArguments.Where(I => I.Key == "model").FirstOrDefault();
            var model = (KullaniciKayitViewModel)dictionaryGelen.Value;
            if (model.Ad.ToLower() == "tugce")
            {
                context.Result = new RedirectResult("\\Home\\Error");
            }
        }
    }
}
