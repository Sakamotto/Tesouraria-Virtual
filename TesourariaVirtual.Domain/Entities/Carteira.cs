using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TesourariaVirtual.Domain.Entities;
using TesourariaVirtual.Domain.Enums;

namespace TesourariaVirtual.Domain.Entities
{
    public class Carteira
    {

        public Carteira(string nome, string descricao)
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }

        [Key]
        public int Id { get; set; }

        public string Nome { get; private set; }

        public string Descricao { get; private set; }

        public decimal? ValorInicial { get; set; }

        public string HexColor { get; private set; } = "#AAA";

        public EnumTipoCarteira TipoCarteira { get; set; }

        public ICollection<Renda> Rendas { get; set; }

        public ICollection<Gasto> Gastos { get; set; }

        public DateTime DataCriacao { get; set; }

    }
}
