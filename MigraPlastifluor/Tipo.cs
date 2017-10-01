﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigraPlastifluor
{
    public class Tipo
    {
        public int TipoId { get; set; }

        [StringLength(1)]
        public string Apelido { get; set; }

        [StringLength(50)]
        public string Descricao { get; set; }

    }
}