using AutoGlassTeste.Domain.Core.Interfaces.Repository;
using AutoGlassTeste.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGlassTeste.Infraestrutura.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly Context context;
        public RepositoryProduto(Context context) : base (context)
        {
            this.context = context;
        }
    }
}
