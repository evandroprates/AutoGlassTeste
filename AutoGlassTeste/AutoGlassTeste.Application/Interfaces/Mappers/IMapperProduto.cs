using AutoGlassTeste.Application.DTO;
using AutoGlassTeste.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoGlassTeste.Application.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperDtoEntity(ProdutoDto produtoDto);
        Produto MapperDelUpEntity(Produto produto);
        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);

    }
}
