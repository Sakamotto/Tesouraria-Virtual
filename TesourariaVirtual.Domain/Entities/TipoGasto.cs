using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesourariaVirtual.Domain.Entities
{
    public class TipoGasto
    {

        public TipoGasto(string nome, string hexColor)
        {
            this.Nome = nome;
            this.HexColor = hexColor;
        }

        [Key]
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string HexColor { get; private set; } = "#FFF";
    }
}
