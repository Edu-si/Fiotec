using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class RelatorioRepository : Repository<Relatorio>, IRelatorioRepository
    {
        public RelatorioRepository(MeuDbContext context) : base(context) { }


    }
}
