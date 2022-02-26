using System;

namespace APIRest.Dominio.Entidades
{
    public class Carteirinha
    {
        public Carteirinha(string aluno, string codBarrasCarteirinha, int viaCarteirinha, string sitCarteirinha, DateTime dTImpressao, DateTime dTAlteracao)
        {
            Aluno = aluno;
            CodBarrasCarteirinha = codBarrasCarteirinha;
            ViaCarteirinha = viaCarteirinha;
            SitCarteirinha = sitCarteirinha;
            DTImpressao = dTImpressao;
            DTAlteracao = dTAlteracao;
        }

        public Carteirinha() { }

        public int Id { get; set; }
        public string  Aluno { get; set; }
        public string SitCarteirinha { get; set; }
        public int ViaCarteirinha { get; set; }
        public string CodBarrasCarteirinha { get; set; }
        public DateTime DTImpressao { get; set; }
        public DateTime DTAlteracao { get; set; }
    }
}
