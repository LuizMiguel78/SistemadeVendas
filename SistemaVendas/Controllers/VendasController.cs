using Microsoft.AspNetCore.Mvc;
using SistemaVendas.Application;
using SistemaVendas.Domain;

namespace SistemaVendas.Controllers;

[ApiController]
[Route("api/produtos")]
public class ProdutosController : ControllerBase
{
    private readonly ProdutoService _service;

    public ProdutosController(ProdutoService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Listar()
    {
        return Ok(_service.Listar());
    }

    [HttpPost]
    public IActionResult Criar(Produto produto)
    {
        _service.Adicionar(produto);

        return Ok(produto);
    }
}