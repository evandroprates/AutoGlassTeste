using AutoGlassTeste.Application;
using AutoGlassTeste.Application.DTO;
using AutoGlassTeste.Application.Interfaces;
using AutoGlassTeste.Domain.Core.Interfaces.Services;
using AutoGlassTeste.Domain.Entity;
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
            produtoService = new ApplicationServiceProduto(new Mock<IServiceProduto>().Object, new Mock<IMapperProduto>().Object);
        }

        [Fact]
        public void Post_ValidandoAtualizacao()
        {
            var exception = Assert.Throws<Exception>(() => produtoService.Update(new Produto()));
            Assert.Equal("ID não é válido", exception.Message);
        }

        [Fact]
        public void Post_ValidandoPost()
        {
            var exception = Assert.Throws<Exception>(() => produtoService.Add(new ProdutoDto()));
            Assert.Equal("ID não é válido", exception.Message);
        }

    }
}
