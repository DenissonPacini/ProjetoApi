using APIRest.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRest.Infraestrutura.Data.Base
{
    public class BaseRepositorio<T> where T: Carteirinha
    {
        protected readonly AppDbContexto _appDbContexto;
        protected readonly DbSet<T> carteirinha;

        public BaseRepositorio(AppDbContexto appDbContexto)
        {
            _appDbContexto = appDbContexto;
            carteirinha = _appDbContexto.Set<T>();
        }
    }
}
