using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AplicativoMvcBasico.Models
{
    public class Produto: Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage ="O Campo {0} é Obrigatorio")]
        [StringLength(200, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatorio")]
        [StringLength(1000, ErrorMessage = "O Campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }
        
        [Required(ErrorMessage = "O Campo {0} é Obrigatorio")]
        public string Imagem { get; set; }
        
        [Required(ErrorMessage = "O Campo {0} é Obrigatorio")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Valor { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        [Required(ErrorMessage = "O Campo {0} é Obrigatorio")]
        public bool Ativo { get; set; }

        public Fornecedor Fornecedor { get; set; }

    }
}
