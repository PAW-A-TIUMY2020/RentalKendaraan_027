using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140027.Models
{
    public partial class Jaminan
    {
        public int IdJaminan { get; set; }

        [Required(ErrorMessage = "Nama Jaminan tidak boleh kosong")]
        public string NamaJaminan { get; set; }
    }
}
