using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesourariaVirtual.Domain.Entities
{
    public class Renda
    {
        [Key]
        public int Id { get; set; }

        
        public int TipoRendaId { get; set; }

        [ForeignKey("TipoRendaId")]
        public TipoRenda TipoRenda { get; private set; }

        public decimal Valor { get; private set; }

        public DateTime DataEntrada { get; set; }

    }
}
