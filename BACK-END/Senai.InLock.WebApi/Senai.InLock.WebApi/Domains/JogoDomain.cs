using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Senai.InLock.WebApi.Domains
{
    public class JogoDomain
    {
        public int JogoId { get; set; }
        public string NomeJogo { get; set; }
        public DateTime DataLancamenteo { get; set; }
        public decimal Valor { get; set; }
        public int EstudioId { get; set; }
        //public EstudiodDomain Estudio { get; set; }
    }
}