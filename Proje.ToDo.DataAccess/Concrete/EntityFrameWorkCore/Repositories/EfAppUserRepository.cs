using Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Contexts;
using Proje.ToDo.DataAccess.Interfaces;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Repositories
{
    public class EfAppUserRepository : EfGenericRepository<AppUser>, IAppUserDal
    {
        public List<AppUser> GetNotAdmin()
        {
            using var context = new ToDoContext();
            return context.Users.Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
            {
                user = resultUser,
                userRole = resultUserRole
            }).Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id, (resultTable, resultRole) => new
            {
                user = resultTable.user,
                userRoles = resultTable.userRole,
                roles = resultRole
            }).Where(I => I.roles.Name == "Member").Select(I => new AppUser()
            {
                Id = I.user.Id,
                Name = I.user.Name,
                Surname = I.user.Surname,
                Picture = I.user.Picture,
                Email = I.user.Email,
                UserName = I.user.UserName
            }).ToList();
        }
        public List<AppUser> GetNotAdmin(out int toplamSayfa,string aranacakKelime,int aktifSayfa=1)
        {
            using var context = new ToDoContext();
            var result = context.Users.Join(context.UserRoles, user => user.Id, userRole => userRole.UserId, (resultUser, resultUserRole) => new
            {
                user = resultUser,
                userRole = resultUserRole
            }).Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id, (resultTable, resultRole) => new
            {
                user = resultTable.user,
                userRoles = resultTable.userRole,
                roles = resultRole
            }).Where(I => I.roles.Name == "Member").Select(I => new AppUser()
            {
                Id = I.user.Id,
                Name = I.user.Name,
                Surname = I.user.Surname,
                Picture = I.user.Picture,
                Email = I.user.Email,
                UserName = I.user.UserName
            });

            toplamSayfa =(int)Math.Ceiling((double) result.Count()/3);

            if (!string.IsNullOrWhiteSpace(aranacakKelime))
            {
                result=result.Where(I=>I.Name.ToLower().Contains(aranacakKelime.ToLower()) || I.Surname.ToLower().Contains(aranacakKelime.ToLower()));
                toplamSayfa = (int)Math.Ceiling((double)result.Count() / 3);
            }

            result= result.Skip((aktifSayfa - 1) * 3).Take(3);
            return result.ToList();

        }

    }
    //class ThreeModel
    //{
    //    public AppUser AppUser { get; set; }
    //    public AppRole AppRole { get; set; }
    //}
}
