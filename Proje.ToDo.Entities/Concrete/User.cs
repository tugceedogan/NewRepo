using System.Collections.Generic;

namespace Proje.ToDo.Entities.Concrete
{
    public class User
    {
        public int Id { get; set; }
        public int Ad { get; set; }
        public int Soyad { get; set; }
        public int  Email { get; set; }
        public int Telefon { get; set; }

        public List<Work> Works { get; set; }


    }
}
