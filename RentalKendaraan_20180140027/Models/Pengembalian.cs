using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140027.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }

        [Required(ErrorMessage = "Tgl peminjaman wajib diisi")]
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaaman { get; set; }
        public int? IdKondisi { get; set; }

        [Required(ErrorMessage = "Denda wajib diisi")]
        public int? Denda { get; set; }
    }
}
