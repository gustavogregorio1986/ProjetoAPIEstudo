using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAPIEstudo.Dominio.Dominio
{
    [Table("tb_Pagamento")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPagamento { get; set; }

        public double Preco { get; set; }

        public int Qtde { get; set; }

        public int Parcela { get; set; }

        public Produto Produto { get; set; }

        [ForeignKey("Produto")]
        public int Id_Produto { get; set; }
    }
}
