using Microsoft.AspNetCore.Mvc;
using NicosCardapio.API.Services;

namespace NicosCardapio.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CardapioController : ControllerBase
{
    private readonly ICardapioService _service;

    public CardapioController(ICardapioService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetTodas()
    {
        var categorias = _service.GetTodas();
        return Ok(categorias);
    }

    [HttpGet("{id}")]
    public IActionResult GetPorId(int id)
    {
        var categoria = _service.GetPorId(id);
        if (categoria is null)
            return NotFound(new { mensagem = $"Categoria {id} não encontrada." });

        return Ok(categoria);
    }
}
