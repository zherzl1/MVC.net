﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EvidencijaRacunaObrta.Models.ObrtModels
{
    [Table("ObrtStavka")]
    public class ObrtStavka : ModelBase<int>
    {
        public int RacunId { get; set; }
        public ObrtRacun Racun { get; set; }
        public string UslugaOpis { get; set; }
        public decimal Cijena { get; set; }
        public int Kolicina { get; set; }
        public string Jedinica { get; set; } = "kom";
        public decimal UkupnoCijena { get { return Cijena * Kolicina; } }
    }
}