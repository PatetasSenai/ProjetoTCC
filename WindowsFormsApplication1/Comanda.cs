using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Comanda
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int iditens;

        public int Iditens
        {
            get { return iditens; }
            set { iditens = value; }
        }
        private int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        private int idfuncionario;

        public int Idfuncionario
        {
            get { return idfuncionario; }
            set { idfuncionario = value; }
        }
        private DateTime datainicioatendimento;

        public DateTime Datainicioatendimento
        {
            get { return datainicioatendimento; }
            set { datainicioatendimento = value; }
        }
        private DateTime datafinalatendimento;

        public DateTime Datafinalatendimento
        {
            get { return datafinalatendimento; }
            set { datafinalatendimento = value; }
        }
        private int idconta;

        public int Idconta
        {
            get { return idconta; }
            set { idconta = value; }
        }







    }
}
