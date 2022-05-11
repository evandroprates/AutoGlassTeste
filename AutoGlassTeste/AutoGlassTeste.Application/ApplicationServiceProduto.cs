using AutoGlassTeste.Application.DTO;
using AutoGlassTeste.Application.Interfaces;
using AutoGlassTeste.Domain.Core.Interfaces.Repository;
using AutoGlassTeste.Domain.Core.Interfaces.Services;
using AutoGlassTeste.Domain.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGlassTeste.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        //private readonly IMapperProduto mapperProduto;

        private readonly IMapper mapper;
        private readonly IRepositoryProduto repository;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IRepositoryProduto repository, IMapper mapper)
        {
            this.serviceProduto = serviceProduto;
            //this.mapperProduto = mapperProduto;
            this.mapper = mapper;
            this.repository = repository;
        }

        //public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        //{
        //    this.serviceProduto = serviceProduto;
        //    this.mapperProduto = mapperProduto;
        //    this.mapper = mapper;
        //}

        public void Add(ProdutoDto produtoDto)
        {
            //var produto = mapperProduto.MapperDtoEntity(produtoDto); //Converte para entidade para inserir na base
            //serviceProduto.Add(produto);

            var produto = mapper.Map<Produto>(produtoDto); //Converte para entidade para inserir na base
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {

            //var produtos = serviceProduto.GetAll();
            //return mapperProduto.MapperListProdutosDto(produtos);

            var produtos = this.serviceProduto.GetAll();

            var _produtosDto = mapper.Map<IEnumerable<ProdutoDto>>(produtos);

            return _produtosDto;
        }

        public ProdutoDto GetById(int id)
        {
            //var produto = serviceProduto.GetById(id);
            //return mapperProduto.MapperEntityToDto(produto);

            var produto = this.serviceProduto.GetById(id);
            return mapper.Map<ProdutoDto>(produto);
        }

        public void Remove(Produto produtoDelete)
        {
            //var produto = mapperProduto.MapperDelUpEntity(produtoDelete);

            var produto = mapper.Map<Produto>(produtoDelete);
            serviceProduto.Remove(produto);
        }

        public void Update(Produto produtoUpdate)
        {
            // var produto = mapperProduto.MapperDelUpEntity(produtoUpdate);
            var produto = mapper.Map<Produto>(produtoUpdate);
            serviceProduto.Update(produto);
        }
    }
}
