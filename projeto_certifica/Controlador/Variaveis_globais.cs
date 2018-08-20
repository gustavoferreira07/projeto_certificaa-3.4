using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_certifica.Controlador
{
    class Variaveis_globais
    {
        private static string _usuario;
        public static string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private static string _id_usuario;
        public static string id_usuario
        {
            get { return _id_usuario; }
            set { _id_usuario = value; }
        }

        private static string _id_ocorrencia;
        public static string id_ocorrencia
        {
            get { return _id_ocorrencia; }
            set { _id_ocorrencia = value; }
        }
        private static string _cargo;
        public static string cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }
        private static string _id_orcamento;
        public static string id_orcamento
        {
            get { return _id_orcamento; }
            set { _id_orcamento = value; }
        }

    }
}
