using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class gravaComanda
    {

        private SqlConnection conn = null;

        public gravaComanda()
        {
            this.conn = Conexao.obterConexao();
        }

        public int salvar(List<Comanda> itens)
        {
            foreach (Comanda c in itens)
            {
                try
                {
                    string sql = "insert into Comanda(iditens, quantidade, total, idfuncionario, datainicioatendimento, datafinalatendimento, idconta) values (@iditem,@qtd, @total, @idfunc, @datainicioatendimento, @datafinalatendimento,@idconta)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //@iditem,@qtd, @total, @idfunc, @datainicioatendimento, @datafinalatendimento
                    cmd.Parameters.AddWithValue("@iditem", c.Iditens);
                    cmd.Parameters.AddWithValue("@qtd", c.Quantidade);
                    cmd.Parameters.AddWithValue("@total", c.Total);
                    cmd.Parameters.AddWithValue("@idfunc", c.Idfuncionario);
                    cmd.Parameters.AddWithValue("@datainicioatendimento", c.Datainicioatendimento);
                    cmd.Parameters.AddWithValue("@datafinalatendimento", c.Datafinalatendimento);
                    cmd.Parameters.AddWithValue("@idconta", c.Idconta);
                    cmd.ExecuteNonQuery();
                    
                }
                
                catch (Exception erro)
                {
                    conn.Close();
                    Console.Write(erro.ToString());
                    return 0;
                }
            
            }
            conn.Close();
            return 1;
                      
        }

    }
}
