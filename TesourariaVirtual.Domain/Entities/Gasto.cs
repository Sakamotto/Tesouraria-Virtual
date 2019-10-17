using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesourariaVirtual.Domain.Entities
{
    public class Gasto
    {
        [Key]
        public int Id { get; set; }

        public int TipoGastoId { get; set; }

        [ForeignKey("TipoGastoId")]
        public TipoGasto TipoGasto { get; private set; }

        public decimal Valor { get; private set; }

        public DateTime DataEntrada { get; set; }
    }
}
