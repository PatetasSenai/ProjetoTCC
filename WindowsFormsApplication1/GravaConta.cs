using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    
    public class GravaConta
    {
        private SqlConnection conn = null;

        public GravaConta()
        {
            this.conn = Conexao.obterConexao();
        }

        public int novo(Conta c)
        {
            try
            {
                string sql = "insert into Conta(idmesa, dataFechamento, valorTotal, idPagamento, dataAbertura, idCaixa) values (@mesa,@datafecha, @total, @tipoPag, @dataaberto, @caixa); SELECT SCOPE_IDENTITY()";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //(@mesa,@datafecha, @total, @tipoPag, @dataaberto, @caixa)
                cmd.Parameters.AddWithValue("@mesa", c.IdMesa);
                cmd.Parameters.AddWithValue("@datafecha", c.DataFechamento);
                cmd.Parameters.AddWithValue("@total", c.ValorTotal);
                cmd.Parameters.AddWithValue("@tipoPag", c.IdPagamento);
                cmd.Parameters.AddWithValue("@dataaberto", c.DataAbertura);
                cmd.Parameters.AddWithValue("@caixa", c.IdCaixa);
                String conta = cmd.ExecuteScalar().ToString();
                c.IdConta = Convert.ToInt32(conta);
                conn.Close();
                return c.IdConta;
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.ToString());
                conn.Close();
                return 0 ;
            }
        }
    }
}
