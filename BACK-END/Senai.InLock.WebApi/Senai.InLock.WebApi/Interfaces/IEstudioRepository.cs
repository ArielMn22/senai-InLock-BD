using Senai.InLock.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interfaces
{
    public interface IEstudioRepository
    {
        /// <summary>
        /// Lista todos os estúdios com uma lista de jogos do estúdio.
        /// </summary>
        /// <returns>Uma List<EstudioDomain></returns>
        List<EstudioDomain> ListarEstudios();
    }
}
