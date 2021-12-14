using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02MapBDPreEexistente.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string TituloFilme { get; set; }
        public string DescricaoFilme { get; set; }
        public string AnoLancamentoFilme { get; set; }
        public ClassificacaoIndicativa Clasificacao { get; set; }
        public short DuracaaoFilme { get; set; }
        public IList<FilmeAtor> Atores { get; set; }

        public Idioma IdiomaFalado { get; set; }
        public Idioma IdiomaOriginal { get; set; }

        public Filme()
        {
            Atores = new List<FilmeAtor>();
        }


        //Sobrescrevendo o método ToString para que as informações de Titulo e Decricao do filme se tornem visíveis.
        public override string ToString()
        {
            return $"Ator ({Id}): {TituloFilme} {AnoLancamentoFilme}";
        }
    }
}
