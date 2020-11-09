using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140027.Models
{
    public partial class Peminjaman
    {
        public int IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Tgl peminjaman wajib diisi")]
        public DateTime? TglPeminjaman { get; set; }

        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }

        [Required(ErrorMessage = "Biaya wajib diisi")]
        public int? Biaya { get; set; }
    }
}
