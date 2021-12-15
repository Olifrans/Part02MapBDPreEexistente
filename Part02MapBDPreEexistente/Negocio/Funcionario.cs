using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02MapBDPreEexistente.Negocio
{
    public class Funcionario : Pessoa
    {        
        public string UsuarioLogin { get; set; }
        public string UsuarioSenha { get; set; }

        //Sobrescrita método ToString Get-Visivél nas informações da entidade.
        public override string ToString()
        {
            return $"Cliente ({Id}): {UsuarioLogin} --> {UsuarioSenha}";
        }
    }
}
