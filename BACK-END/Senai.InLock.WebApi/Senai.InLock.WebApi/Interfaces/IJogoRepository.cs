using Senai.InLock.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interfaces
{
    public interface IJogoRepository
    {
        /// <summary>
        /// Lista todos os jogos com seus respectivos estúdios.
        /// </summary>
        /// <returns>Uma lista de JogoDomain</returns>
        List<JogoDomain> ListarJogos();

        /// <summary>
        /// Lista todos os jogos de um estúdio.
        /// </summary>
        /// <returns>Uma lista de JogoDomain</returns>
        List<JogoDomain> ListarJogosPorEstudio(int EstudioId);

        /// <summary>
        /// Cadastra um jogo na tabela JogoDomain
        /// </summary>
        /// <param name="jogo">JogoDomain</param>
        void CadastrarJogo(JogoDomain jogo);
    }
}
