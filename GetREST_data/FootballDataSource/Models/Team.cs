﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDataSource.Models
{
    public class Team
    {
        public Team()
        {
        }

        //{
        //            "id": 66,
        //            "name": "Manchester United FC",
        //            "shortName": "ManU",
        //            "squadMarketValue": "377,250,000 €",
        //            "crestUrl": "http://upload.wikimedia.org/wikipedia/de/d/da/Manchester_United_FC.svg"
        //        },

        public int? id { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string squadMarketValue { get; set; }
        public string crestUrl { get; set; }
    }
}
