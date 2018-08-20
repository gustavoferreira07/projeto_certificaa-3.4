using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_certifica.Repositorio
{
    class Historico
    {
        public string Id_ocorrencia { get; set; }
        public string Nm_usuario { get; set; }
        public DateTime Data_edit { get; set; }

        public Historico(string id_ocorrencia, string nm_usuario, DateTime data_edit)
        {
            this.Id_ocorrencia = id_ocorrencia;
            this.Nm_usuario = nm_usuario;
            this.Data_edit = data_edit;
        }
        public Historico()
        {
            
        }
    }
}
