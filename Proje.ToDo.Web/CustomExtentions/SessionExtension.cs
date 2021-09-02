using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.CustomExtentions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object deger)
        {
            string gelenData = JsonConvert.SerializeObject(deger);
            session.SetString(key, gelenData);
        }
        public static Tugce GetObject<Tugce>(this ISession session, string key)
            where Tugce : class, new()
        {
            string gelenData = session.GetString(key);
            if (gelenData != null)
            {
                return JsonConvert.DeserializeObject<Tugce>(gelenData);
            }
            return null;
        }
    }
}
