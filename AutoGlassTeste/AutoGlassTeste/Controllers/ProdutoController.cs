using AutoGlassTeste.Application.DTO;
using AutoGlassTeste.Application.Interfaces;
using AutoGlassTeste.Domain.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGlassTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IApplicationServiceProduto _applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto)
        {
            _applicationServiceProduto = applicationServiceProduto;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok(_applicationServiceProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(_applicationServiceProduto.GetById(id)); ;
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound();
                else if(produtoDto.Situacao == "Ativo" || produtoDto.Situacao == "Inativo")
                {
                    if (produtoDto.DataFabricacao <= produtoDto.DataValidade)
                    {
                        _applicationServiceProduto.Add(produtoDto);
                        return Ok("Produto Cadastrado");
                    }
                    else
                    {
                        return BadRequest("A data de fabricação não pode ser maior que a data de validade");
                    }

                }

                return BadRequest("Só é aceito 'Ativo' ou 'Inativo' no campo de situação");

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut()]
        public ActionResult Put([FromBody] Produto produto)
        {
            try
            {
                if (produto == null)
                    return NotFound();
                else if (produto.Situacao == "Ativo" || produto.Situacao == "Inativo")
                {
                    if (produto.DataFabricacao <= produto.DataValidade)
                    {
                        _applicationServiceProduto.Update(produto);
                        return Ok("Produto Atualizado");
                    }
                    else
                    {
                        return BadRequest("A data de fabricação não pode ser maior que a data de validade");

                    }
                }

                return BadRequest("Só é aceito 'Ativo' ou 'Inativo' no campo de situação");

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] Produto produto)
        {
            try
            {
                if (produto == null)
                    return NotFound();

                produto.Situacao = "Inativo";

                _applicationServiceProduto.Remove(produto);

                return Ok("Produto Atualizado");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
