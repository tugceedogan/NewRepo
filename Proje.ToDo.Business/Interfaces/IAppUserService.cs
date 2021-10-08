using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Interfaces
{
    public interface IAppUserService
    {
        List<AppUser> GetNotAdmin();
        List<AppUser> GetNotAdmin(out int toplamSayfa, string aranacakKelime, int aktifSayfa = 1);
    }
}
