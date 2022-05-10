using AutoGlassTeste.Application;
using AutoGlassTeste.Application.DTO;
using AutoGlassTeste.Application.Interfaces;
using AutoGlassTeste.Domain.Core.Interfaces.Repository;
using AutoGlassTeste.Domain.Core.Interfaces.Services;
using AutoGlassTeste.Domain.Entity;
using AutoGlassTeste.Infraestrutura.Data.Repositorys;
using AutoMapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Produto.Teste.Services
{
    public class ProdutoServiceTeste
    {
        private ApplicationServiceProduto produtoService;

        public ProdutoServiceTeste()
        {
            produtoService = new ApplicationServiceProduto(new Mock<IServiceProduto>().Object, new Mock<IMapperProduto>().Object);
        }

        [Fact]
        public void Post_ValidandoAtualizacao()
        {
            var result = Assert.Throws<Exception>(() => produtoService.Update(new Produto()));
            Assert.True(true);
        }
    }
}
