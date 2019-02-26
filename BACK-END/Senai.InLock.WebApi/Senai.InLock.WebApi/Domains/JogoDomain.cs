using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Domains
{
    public class JogoDomain
    {
        [Required(ErrorMessage = "É necessário um Id para o jogo.")]
        public int JogoId { get; set; }

        [Required(ErrorMessage = "É necessário um Nome para o jogo.")]
        public string NomeJogo { get; set; }

        [Required(ErrorMessage = "É necessário uma descrição para jogo")]
        public string  Descricao { get; set; }

        [Required(ErrorMessage = "É necessário uma data de lançamento.")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "É necessário um valor para o jogo.")]
        public decimal Valor { get; set; }

        public EstudioDomain Estudio { get; set; }

        public int EstudioId { get; set; }
    }
}
