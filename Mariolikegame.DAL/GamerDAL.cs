using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MarioLikeGame.Model;
namespace Mariolikegame.DAL
{
    public class GamerDAL
    {
        //Declarar o objeto de conexao com o BD
        private SqlConnection conexao;

        //Exibir as Mensagens de Erro
        public string MensagemErro { get; set; }

        public GamerDAL()
        {
            //Criar Objeto para ler a configuraçao
            LeitorConfiguracao leitor = new LeitorConfiguracao();

            //Instanciar a conexao
            conexao = new SqlConnection();
            conexao.ConnectionString = leitor.LerConexao();
        
        }

        public bool Inserir(Placar placar)
        {
            bool resultado = false;
            //Limpa mensagem de erro
            MensagemErro = "";

            //Declarar Comando SQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "INSERT INTO Score (nome_Jogador, score_Jogador, data_Score, tempo)" +
                "VALUES (@Nome,@Score,@Data, @Tempo);";

            //Criar os parametros
            comando.Parameters.AddWithValue("@Nome",placar.NomeJogador);
            comando.Parameters.AddWithValue("@Score", placar.ScoreJogador);
            comando.Parameters.AddWithValue("@Data", placar.DataScoreJogador);
            comando.Parameters.AddWithValue("@Tempo", placar.Tempo);

            //Executar o Comando
            try
            {
                //Abrir a conexao
                conexao.Open();
                //Executar o comando
                comando.ExecuteNonQuery();
                //Se chegou até aqui, entao fununcinou! :)
                resultado = true;
            }
            catch (Exception ex)
            {

                //Se entrou aqui, entao deu pau
                MensagemErro = ex.Message;
            }
            finally
            {
                //Finalizar fechando a conexao
                conexao.Close();
            }
            return resultado;
        }

        public List<Placar> Listar()
        {
            //Instanciar a lista
            List<Placar> resultado = new List<Placar>();

            //Declarar o comando
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT TOP 10 id_Jogador, nome_Jogador, score_Jogador, data_Score, tempo " +
                " FROM Score ORDER BY score_Jogador DESC, tempo, data_Score";

            //Executar o comando
            try
            {
                //Abrir a conexao
                conexao.Open();

                //Executar o comando e receber o resultado
                SqlDataReader leitor = comando.ExecuteReader();

                //Verificarse encontrou algo
                while (leitor.Read() == true)
                {
                    //instancio o objeto
                    Placar placar = new Placar();
                    placar.IdJogador = Convert.ToInt32(leitor["id_Jogador"]);
                    placar.NomeJogador = Convert.ToString(leitor["nome_Jogador"]);
                    placar.ScoreJogador = Convert.ToInt32(leitor["score_Jogador"]);
                    placar.DataScoreJogador = Convert.ToDateTime(leitor["data_Score"]);
                    placar.Tempo = Convert.ToString(leitor["tempoJogo"]);

                    //Adicionar na lista
                    resultado.Add(placar);
                }

                //Fechar o leitor
                leitor.Close();
            }
            catch (Exception ex)
            {

                //Se entrou aqui entao deu pau :(
                string mensagem = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
            return resultado;
        }
            

    }
}
