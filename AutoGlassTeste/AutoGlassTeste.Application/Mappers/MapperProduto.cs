using AutoGlassTeste.Application.DTO;
using AutoGlassTeste.Application.Interfaces;
using AutoGlassTeste.Domain.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGlassTeste.Application
{
    //public class MapperProduto : Profile
    //{
    //    public MapperProduto()
    //    {
    //        CreateMap<ProdutoDto, Produto>();
    //    }

    //}
    public class MapperProduto : IMapperProduto
    {
        IEnumerable<ProdutoDto> ProdutoDtos = new List<ProdutoDto>();

        public Produto MapperDtoEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                //CodigoProduto = produtoDto.CodigoProduto,
                Cnpj = produtoDto.Cnpj,
                CodigoFornecedor = produtoDto.CodigoFornecedor,
                DataFabricacao = produtoDto.DataFabricacao,
                DataValidade = produtoDto.DataValidade,
                DescricaoFornecedor = produtoDto.DescricaoFornecedor,
                DescricaoProduto = produtoDto.DescricaoProduto,
                Situacao = produtoDto.Situacao
            };

            return produto;
        }

        public Produto MapperDelUpEntity(Produto produtoDelUp)
        {
            var produto = new Produto()
            {
                CodigoProduto = produtoDelUp.CodigoProduto,
                Cnpj = produtoDelUp.Cnpj,
                CodigoFornecedor = produtoDelUp.CodigoFornecedor,
                DataFabricacao = produtoDelUp.DataFabricacao,
                DataValidade = produtoDelUp.DataValidade,
                DescricaoFornecedor = produtoDelUp.DescricaoFornecedor,
                DescricaoProduto = produtoDelUp.DescricaoProduto,
                Situacao = produtoDelUp.Situacao
            };

            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                //CodigoProduto = produto.CodigoProduto,
                Cnpj = produto.Cnpj,
                CodigoFornecedor = produto.CodigoFornecedor,
                DataFabricacao = produto.DataFabricacao,
                DataValidade = produto.DataValidade,
                DescricaoFornecedor = produto.DescricaoFornecedor,
                DescricaoProduto = produto.DescricaoProduto,
                Situacao = produto.Situacao
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(x => new ProdutoDto()
            {
                //CodigoProduto = x.CodigoProduto,
                Cnpj = x.Cnpj,
                CodigoFornecedor = x.CodigoFornecedor,
                DataFabricacao = x.DataFabricacao,
                DataValidade = x.DataValidade,
                DescricaoFornecedor = x.DescricaoFornecedor,
                DescricaoProduto = x.DescricaoProduto,
                Situacao = x.Situacao
            });

            return dto;
        }
    }
}
