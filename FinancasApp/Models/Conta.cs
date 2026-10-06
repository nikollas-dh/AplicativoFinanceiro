using System;
using System.Collections.Generic;
using System.Text;

namespace FinancasApp.Models
{
    internal class Conta
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public decimal SaldoInicial { get; set; }

        public bool Ativa { get; set; } = true;

        public DateTime DataCriacao { get; set; } = DateTime.Now;
    }
}
