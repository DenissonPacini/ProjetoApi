using APIRest.Dominio.Entidades;
using APIRest.Dominio.Interfaces;
using APIRest.Infraestrutura.Data.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRest.Infraestrutura.Data.Repositorio
{
    public class RepositorioCarteirinha : BaseRepositorio<Carteirinha>, IRepositorioCarteirinha
    {
        private readonly AppDbContexto _contexto;
        public RepositorioCarteirinha(AppDbContexto contexto) : base(contexto) {
            _contexto = contexto;
        }
        


        public IList<Carteirinha> GetCarteirinha()
        {
            return carteirinha.ToList();
        }

        public bool SaveCarteirinha(Carteirinha dados)
        {
            if (!carteirinha.Where(p => p.Aluno == dados.Aluno && p.ViaCarteirinha == dados.ViaCarteirinha).Any())
            {
                carteirinha.Add(new Carteirinha(
                    dados.Aluno
                    , dados.CodBarrasCarteirinha
                    , dados.ViaCarteirinha
                    , dados.SitCarteirinha
                    , dados.DTImpressao
                    , dados.DTAlteracao));

                _contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Carteirinha> GetCarteirinha(string Aluno)
        {
            List<Carteirinha> listaDeCarteirinhas = new List<Carteirinha>();

            var listaCarteirinha = (from c in _appDbContexto.Carteirinha
                                    where c.Aluno == Aluno
                                    select new {c.Aluno
                                                 , c.CodBarrasCarteirinha
                                                 , c.SitCarteirinha
                                                 , c.ViaCarteirinha
                                                 , c.DTAlteracao
                                                 , c.DTImpressao
                                                }).ToList();

            foreach (var item in listaCarteirinha)
            {
                listaDeCarteirinhas.Add(new Carteirinha
                {
                    Aluno = item.Aluno,
                    CodBarrasCarteirinha = item.CodBarrasCarteirinha,
                    DTAlteracao = item.DTAlteracao,
                    DTImpressao = item.DTImpressao,
                    SitCarteirinha = item.SitCarteirinha,
                    ViaCarteirinha = item.ViaCarteirinha
                });
            }
            return listaDeCarteirinhas;
        }
    }
}
