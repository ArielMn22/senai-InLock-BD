using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private string StringConexao = @"Data Source=.\SqlExpress;Initial catalog=InLock_Games_Tarde;user id=sa; password=132";

        public void CadastrarJogo(JogoDomain jogo)
        {
            string queryInsert = @"INSERT INTO Jogos(NomeJogo, Descricao, DataLancamento, Valor, EstudioId) VALUES(@NOMEJOGO, @DESCRICAO, @DATALANCAMENTO, @VALOR, @ESTUDIOID)";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@NOMEJOGO", jogo.NomeJogo);
                    cmd.Parameters.AddWithValue("@DESCRICAO", jogo.Descricao);
                    cmd.Parameters.AddWithValue("@DATALANCAMENTO", jogo.DataLancamento);
                    cmd.Parameters.AddWithValue("@VALOR", jogo.Valor);
                    cmd.Parameters.AddWithValue("@ESTUDIOID", jogo.EstudioId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<JogoDomain> ListarJogos()
        {
            string querySelect = @"SELECT
	                                    J.*,
	                                    E.NomeEstudio
                                    FROM
	                                    Jogos J INNER JOIN Estudios E
                                    ON
	                                    J.EstudioId = E.EstudioId";
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        List<JogoDomain> jogos = new List<JogoDomain>();

                        while (sdr.Read())
                        {
                            JogoDomain jogo = new JogoDomain()
                            {
                                JogoId = Convert.ToInt32(sdr["JogoId"]),
                                NomeJogo = sdr["NomeJogo"].ToString(),
                                Descricao = sdr["Descricao"].ToString(),
                                DataLancamento = Convert.ToDateTime(sdr["DataLancamento"]),
                                Valor = Convert.ToDecimal(sdr["Valor"]),
                                Estudio = new EstudioDomain()
                                {
                                    EstudioId = Convert.ToInt32(sdr["EstudioId"]),
                                    NomeEstudio = sdr["NomeEstudio"].ToString()
                                }
                            };

                            jogos.Add(jogo);
                        }

                        return jogos;
                    }

                    return null;
                }
            }
        }

        public List<JogoDomain> ListarJogosPorEstudio(int EstudioId)
        {
            string querySelect = @"SELECT * FROM Jogos WHERE EstudioId = @ESTUDIOID";

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    cmd.Parameters.AddWithValue("@ESTUDIOID", EstudioId);

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        List<JogoDomain> jogos = new List<JogoDomain>();

                        while (sdr.Read())
                        {
                            JogoDomain jogo = new JogoDomain()
                            {
                                JogoId = Convert.ToInt32(sdr["JogoId"]),
                                NomeJogo = sdr["NomeJogo"].ToString(),
                                Descricao = sdr["Descricao"].ToString(),
                                DataLancamento = Convert.ToDateTime(sdr["DataLancamento"]),
                                Valor = Convert.ToDecimal(sdr["Valor"]),
                                EstudioId = Convert.ToInt32(sdr["EstudioId"])
                            };

                            jogos.Add(jogo);
                        }

                        return jogos;
                    }

                    return null;
                }
            }
        }
    }
}
