using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_certifica.Repositorio
{
    class Orcamento
    {
        public int Id_orcamento { get; set; }
        public string Id_ocorrencia { get; set; }
        public string Status_orcamento { get; set; }
        public string Tipo_orcamento { get; set; }
        public string Ds_orcamento { get; set; }
        public string Data_conclusao { get; set; }
        public double Valor { get; set; }
        public string Motivo_Status { get; set; }
        public byte[] Img_recibo { get; set; }

        public Orcamento(int id_orcamento, string id_ocorrencia,string status_orcamento, string tipo_orcamento, string ds_orcamento, string data_conclusao, Double valor, string motivo_status, byte[] img_recibo)
        {
            this.Id_orcamento = id_orcamento;
            this.Id_ocorrencia = id_ocorrencia;
            this.Status_orcamento = status_orcamento;
            this.Tipo_orcamento = tipo_orcamento;
            this.Ds_orcamento = ds_orcamento;
            this.Data_conclusao = data_conclusao;
            this.Valor = valor;
            this.Motivo_Status = motivo_status;
            this.Img_recibo = img_recibo;
        }
        public Orcamento()
        {

        }
    }
}
