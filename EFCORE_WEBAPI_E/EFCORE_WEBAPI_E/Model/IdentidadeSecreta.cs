﻿using EFCORE.WEBAPI_E.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCORE_WEBAPI_E.Model
{
    public class IdentidadeSecreta
    {
        public int Id { get; set; }
        public string NomeReal { get; set; }
        public int HeroiId { get; set; }
        public Heroi heroi { get; set; }
    }
}