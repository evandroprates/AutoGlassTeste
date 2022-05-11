using AutoGlassTeste.Application;
using AutoGlassTeste.Application.DTO;
using AutoGlassTeste.Application.Interfaces;
using AutoGlassTeste.Domain.Core.Interfaces.Repository;
using AutoGlassTeste.Domain.Core.Interfaces.Services;
using AutoGlassTeste.Domain.Entity;
using AutoMapper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProdutosTeste.Services
{
    public class ProdutoServiceTeste
    {
        private ApplicationServiceProduto produtoService;

        public ProdutoServiceTeste()
        {
            produtoService = new ApplicationServiceProduto(new Mock<IServiceProduto>().Object, new Mock<IRepositoryProduto>().Object, new Mock<IMapper>().Object);
        }

        [Fact]
        public void Post_ValidandoAtualizacao()
        {
            var exception = Assert.Throws<Exception>(() => produtoService.Update(new Produto()));
            Assert.Equal("ID não é válido", exception.Message);
        }

        [Fact]
        public void Post_ValidandoDelete()
        {
            var exception = Assert.Throws<Exception>(() => produtoService.Remove(new Produto()));
            Assert.Equal("ID não é válido", exception.Message);
        }

    }
}
