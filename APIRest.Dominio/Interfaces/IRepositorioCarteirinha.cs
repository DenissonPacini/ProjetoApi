using APIRest.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRest.Dominio.Interfaces
{
    public interface IRepositorioCarteirinha
    {
        bool SaveCarteirinha(Carteirinha dados);
        List<Carteirinha> GetCarteirinha(string Aluno);
    }
}
