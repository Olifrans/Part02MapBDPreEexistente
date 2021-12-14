using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02MapBDPreEexistente.Negocio
{
    public class Idioma
    {
        public byte Id { get; set; }
        public string Nome { get; set; }

        public IList<Filme> FilmesFalados { get; set; }
        public IList<Filme> FilmeOriginal { get; set; }

        public Idioma()
        {
            FilmesFalados = new List<Filme>();
            FilmesFalados = new List<Filme>();
        }

        //Sobrescrevendo o método ToString para que as informações de Titulo e Decricao do filme se tornem visíveis.
        public override string ToString()
        {
            return $"Ator ({Id}): {Nome} ";
        }
    }    
}
