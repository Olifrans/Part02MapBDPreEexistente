using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02MapBDPreEexistente.Negocio
{
    public class Pessoa
    {
        public byte Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

        //Sobrescrita método ToString Get-Visivél nas informações da entidade.
        public override string ToString()
        {
            var tipo = this.GetType().Name;
            return $"{tipo} ({Id}): {PrimeiroNome} {UltimoNome} --> {Email} --> {Ativo}";
        }
    }
}
