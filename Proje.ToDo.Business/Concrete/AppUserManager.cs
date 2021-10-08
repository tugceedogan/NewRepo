using Proje.ToDo.Business.Interfaces;
using Proje.ToDo.DataAccess.Interfaces;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _userDal;
        public AppUserManager(IAppUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<AppUser> GetNotAdmin()
        {
            return _userDal.GetNotAdmin();
        }

        public List<AppUser> GetNotAdmin(out int toplamSayfa,string aranacakKelime, int aktifSayfa )
        {
            return _userDal.GetNotAdmin(out toplamSayfa, aranacakKelime, aktifSayfa);
        }
    }
}
