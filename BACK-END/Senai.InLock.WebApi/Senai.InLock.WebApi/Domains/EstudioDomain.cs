using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domains
{
    public class EstudioDomain
    {
        [Required(ErrorMessage = "É necessário um Id para o estúdio.")]
        public int EstudioId { get; set; }

        [Required(ErrorMessage = "Um nome é requerido para o estúdio")]
        public string NomeEstudio { get; set; }

        public List<JogoDomain> JogosEstudio { get; set; }
    }
}
