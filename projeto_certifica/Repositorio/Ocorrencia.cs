using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_certifica.Repositorio
{
    class Ocorrencia
    {

        public string Nm_ocorrencia { get; set; }
        public string Nm_usuario { get; set; }
        public string Status { get; set; }
        public string Nome_proprietario { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
        public string Rg { get; set; }
        public string Cnh { get; set; }
        public string Renavan { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Ano { get; set; }
        public string Descricao { get; set; }
        public string Data_entrada { get; set; }
        public string Hora_entrada { get; set; }
        public string Area { get; set; }
        public byte[] Img_entrada { get; set; }
        public byte[] Img_saida { get; set; }
        public byte[] Img_avaria { get; set; }
        public byte[] Img_ocorrencia { get; set; }
        public string Questao1 { get; set; }
        public string Questao2 { get; set; }
        public string Questao3 { get; set; }
        public string Questao4 { get; set; }
        public string Questao5 { get; set; }
        public string Questao6 { get; set; }
        public string Questao7 { get; set; }
        public string Questao8 { get; set; }



        public Ocorrencia(string nm_ocorrencia,string nm_usuario,string status, string nome_proprietario, string cpf, string celular, string endereco, string rg, string cnh,
            string renavan, string modelo, string placa, string cor, string ano, string descricao,string data_entrada, string hora_entrada,string area, byte[]img_entrada,
            byte[] img_saida, byte[] img_avaria, byte[] img_ocorrencia, string questao1, string questao2, string questao3, string questao4, string questao5, string questao6, string questao7, string questao8)
        {
            this.Nm_ocorrencia = nm_ocorrencia;
            this.Nm_usuario = nm_usuario;
            this.Status = status;
            this.Nome_proprietario = nome_proprietario;
            this.Cpf = cpf;
            this.Celular = celular;
            this.Endereco = endereco;
            this.Rg = rg;
            this.Cnh = cnh;
            this.Renavan = renavan;
            this.Modelo = modelo;
            this.Placa = placa;
            this.Cor = cor;
            this.Ano = ano;
            this.Descricao = descricao;
            this.Data_entrada = data_entrada;
            this.Hora_entrada = hora_entrada;
            this.Area = area;
            this.Img_entrada = img_entrada;
            this.Img_saida = img_saida;
            this.Img_avaria = img_avaria;
            this.Img_ocorrencia = img_ocorrencia;
            this.Questao1 = questao1;
            this.Questao2 = questao2;
            this.Questao3 = questao3;
            this.Questao4 = questao4;
            this.Questao5 = questao5;
            this.Questao6 = questao6;
            this.Questao7 = questao7;
            this.Questao8 = questao8;
        }

        public Ocorrencia()
        {

        }
    }
}
