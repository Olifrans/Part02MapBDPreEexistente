//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MapeandoBDPreEexistente.Negocio
//{
//    [Table("category")]
//    public class Categoria
//    {
//        [Column("category_id")]
//        public int Id { get; set; }

//        [Column("name")]
//        public string Nome { get; set; }

//        //[Column("last_update")]
//        //public DateTime DataCadastro { get; set; }



//        //Sobrescrevendo o método ToString para que as informações de primeiro nome e último nome de cada ator se tornem visíveis.
//        public override string ToString()
//        {
//            return $"Categoria ({Id}): {Nome}";
//        }
//    }
//}
