﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AluguerCarros.Models.AlugarCarros
{
    public class Pedido_Aluguer
    {
        [Key]
        public int PedidoID { get; set; }
        public string Cliente { get; set; }
        public string Estado { get; set; }
        public bool aval_Cli { get; set; }
        public bool aval_Dono { get; set; }
        public bool aval_Carro { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataInicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataFim { get; set; }

        public int CarroID { get; set; }
        public virtual Carro Veiculo { get; set; }
    }
}