using APIRest.Infraestrutura.Data;
using APIRest.Infraestrutura.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIRest.Infraestrutura.Data
{
    public class DataService : IDataService
    {
        private readonly AppDbContexto _appDbContexto;

        public DataService(AppDbContexto appDbContexto) {
            _appDbContexto = appDbContexto;
        }

        public void InicializaDB()
        {
            _appDbContexto.Database.EnsureCreated();
        }
    }
}
