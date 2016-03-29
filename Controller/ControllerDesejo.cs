using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;


namespace Controller
{
    public class ControllerDesejo
    {
        public bool GravarDesejo(Desejo desejo)
        {
            SqlConnection conexao = ADODBConnection.Connection();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "insert into tbl_desejo (id_amigo_solicitante,id_amigo_solicitado,data_desejo,valor,descrição) values(@id_amigo_solicitante,id_amigo_solicitado,@data_desejo,@valor,@descricao)";
            comando.Parameters.AddWithValue("@id_amigo_socilitante", desejo.Solicitante.IDAmigo);
            comando.Parameters.AddWithValue("@id_amigo_solicitado", desejo.Solicitado.IDAmigo);
            comando.Parameters.AddWithValue("@data_desejo", desejo.DataDesejo);
            comando.Parameters.AddWithValue("@email", desejo.Valor);
            comando.Parameters.AddWithValue("@descricao", desejo.Descricao);

            conexao.Open();
            int linhasModificadas = comando.ExecuteNonQuery();
            conexao.Close();
            if (linhasModificadas == 0)
                return false;
            else
                return true;

        }
        public List<Desejo> ListarDesejosPorAmigo(int idAmigo)
        {
            SqlConnection conexao = ADODBConnection.Connection();
            SqlCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tbl_desejo";
            List<Desejo> listaDesejo = new List<Desejo>();
            Desejo desejo;
            conexao.Open();
            using (SqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    desejo = new Desejo();
                    desejo.IDDesejo = reader.GetInt32(0);
                    desejo.Solicitante.IDAmigo = reader.GetInt32(1);
                    desejo.Solicitado.IDAmigo = reader.GetInt32(2);
                    desejo.DataDesejo = reader.GetDateTime(3);
                    desejo.Solicitado.Nome = reader.GetString(4);
                    desejo.Solicitado.Email = reader.GetString(5);
                    desejo.Solicitado.DataNascimento = reader.GetDateTime(6);
                    if (idAmigo == desejo.Solicitante.IDAmigo)
                    {
                        listaDesejo.Add(desejo);
                    }
                }
                conexao.Close();
                return listaDesejo;
            }
        }
    }
}

