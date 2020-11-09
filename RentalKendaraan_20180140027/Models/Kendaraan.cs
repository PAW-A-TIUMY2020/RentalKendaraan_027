using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140027.Models
{
    public partial class Kendaraan
    {
        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama kendaraan tidak boleh kosong")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "No polisi  wajib di isi")]
        public string NoPolisi { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "stnk hanya boleh di isi dengan angka")]
        public string NoStnk { get; set; }


        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "ketersediaan  wajib di isi")]
        public string Ketersediaan { get; set; }
    }
}
