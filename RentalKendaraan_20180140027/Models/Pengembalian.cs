using System;
using System.Collections.Generic;

namespace RentalKendaraan_20180140027.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaaman { get; set; }
        public int? IdKondisi { get; set; }
        public int? Denda { get; set; }
    }
}
