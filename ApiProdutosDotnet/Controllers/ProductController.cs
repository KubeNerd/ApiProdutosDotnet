using Microsoft.AspNetCore.Mvc;
using ApiProdutosDotnet.Models;
using System.Linq;

namespace ApiProdutosDotnet.Controllers;

[ApiController] // Indica que esta classe é um controlador de API
[Route("api/[controller]")] // Define a rota base como "api/product"
public class ProductController : ControllerBase
{
    // Lista estática para simular um banco de dados em memória
    private static List<Product> _produtos = new List<Product>();

    // Método POST para cadastrar produtos
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)] // Define o status de sucesso 201
    [ProducesResponseType(StatusCodes.Status400BadRequest)] // Define o status de erro 400
    public ActionResult<Product> Post(Product produto)
    {
        // Gera um ID único baseado no tamanho da lista
        produto.Id = _produtos.Count + 1;

        // Adiciona o produto à lista
        _produtos.Add(produto);

        // Retorna o status 201 com a localização do novo recurso
        return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
    }

    // Método GET para retornar todos os produtos
    [HttpGet]
    public ActionResult<IEnumerable<Product>> Get()
    {
        return Ok(_produtos); // Retorna a lista com status 200 (OK)
    }

    // Método PUT para atualizar um produto
    [HttpPut("{id}")] // O ID é fornecido como parte da rota
    [ProducesResponseType(StatusCodes.Status204NoContent)] // Status de sucesso sem conteúdo
    [ProducesResponseType(StatusCodes.Status404NotFound)] // Status de recurso não encontrado
    public ActionResult Put(int id, Product produtoAtualizado)
    {
        // Busca o produto pelo ID
        var produto = _produtos.FirstOrDefault(x => x.Id == id);
        if (produto == null)
        {
            // Retorna 404 se o produto não for encontrado
            return NotFound();
        }

        // Atualiza os campos do produto
        produto.Name = produtoAtualizado.Name;
        produto.Price = produtoAtualizado.Price;

        // Retorna 204 (No Content) indicando sucesso
        return NoContent();
    }

    // Método DELETE para remover um produto
    [HttpDelete("{id}")] // O ID é fornecido como parte da rota
    [ProducesResponseType(StatusCodes.Status204NoContent)] // Status de sucesso sem conteúdo
    [ProducesResponseType(StatusCodes.Status404NotFound)] // Status de recurso não encontrado
    public ActionResult Delete(int id)
    {
        // Busca o produto pelo ID
        var produto = _produtos.FirstOrDefault(x => x.Id == id);
        if (produto == null)
        {
            // Retorna 404 se o produto não for encontrado
            return NotFound();
        }

        // Remove o produto da lista
        _produtos.Remove(produto);

        // Retorna 204 (No Content) indicando sucesso
        return NoContent();
    }
}
