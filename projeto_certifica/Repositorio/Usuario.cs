using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_certifica.Controlador
{
    class Usuario
    {
        public string User { get; set; }
        public string Senha { get; set; }
        public string Cargo { get; set; }

        public Usuario(string user, string senha, string cargo)
        {
            this.User = user;
            this.Senha = senha;
            this.Cargo = cargo;
        }

        public Usuario()
        { }


    }
}
