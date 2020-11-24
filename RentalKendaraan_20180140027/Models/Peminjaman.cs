﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140027.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdPeminjaman { get; set; }

        [Required(ErrorMessage = "Tgl peminjaman wajib diisi")]
        public DateTime? TglPeminjaman { get; set; }

        [Required(ErrorMessage = "Biaya wajib diisi")]
        public int? Biaya { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJaminan { get; set; }

        public Customer IdCustomerNavigation { get; set; }
        public Jaminan IdJaminanNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
