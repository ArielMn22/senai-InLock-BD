using Senai.InLock.WebApi.Domains;
using Senai.InLock.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Repositories
{
    public class EstudioRepository : IEstudioRepository
    {
        private IJogoRepository JogoRepository { get; set; }

        public EstudioRepository()
        {
            JogoRepository = new JogoRepository();
        }

        private string StringConexao = @"Data Source=.\SqlExpress;Initial catalog=InLock_Games_Tarde;user id=sa; password=132";

        public List<EstudioDomain> ListarEstudios()
        {
            string querySelect = @"SELECT * FROM Estudios";

            List<EstudioDomain> estudios;

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        estudios = new List<EstudioDomain>();

                        while (sdr.Read())
                        {
                            EstudioDomain estudio = new EstudioDomain()
                            {
                                EstudioId = Convert.ToInt32(sdr["EstudioId"]),
                                NomeEstudio = sdr["NomeEstudio"].ToString(),
                                JogosEstudio = JogoRepository.ListarJogosPorEstudio(Convert.ToInt32(sdr["EstudioId"]))
                            };

                            estudios.Add(estudio);
                        }
                        return estudios;
                    }
                    return null;
                }
            }
        }
    }
}
