using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Conta
    {
        private int idConta;

        public int IdConta
        {
            get { return idConta; }
            set { idConta = value; }
        }
        private int idMesa;

        public int IdMesa
        {
            get { return idMesa; }
            set { idMesa = value; }
        }
        private DateTime dataFechamento;

        public DateTime DataFechamento
        {
            get { return dataFechamento; }
            set { dataFechamento = value; }
        }
        private decimal valorTotal;

        public decimal ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
        private int idPagamento;

        public int IdPagamento
        {
            get { return idPagamento; }
            set { idPagamento = value; }
        }
        private DateTime dataAbertura;

        public DateTime DataAbertura
        {
            get { return dataAbertura; }
            set { dataAbertura = value; }
        }
        private int idCaixa;

        public int IdCaixa
        {
            get { return idCaixa; }
            set { idCaixa = value; }
        }



    }
}
