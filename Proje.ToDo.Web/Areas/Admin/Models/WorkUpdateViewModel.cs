﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.ToDo.Web.Areas.Admin.Models
{
    public class WorkUpdateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "ad alanı gereklidir")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Lütfen profil seçiniz")]
        public int ProfilId { get; set; }
    }
}
