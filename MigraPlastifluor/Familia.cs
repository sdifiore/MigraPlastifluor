﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigraPlastifluor
{
    public class Familia
    {
        public int FamiliaId { get; set; }

        [StringLength(3)]
        public string Apelido { get; set; }

        [StringLength(50)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}