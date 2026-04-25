using NicosCardapio.Api.Models;
using NicosCardapio.API.Data;

namespace NicosCardapio.API.Services;

public interface ICardapioService
{
    List<Categoria> GetTodas();
    Categoria? GetPorId(int id);
}

public class CardapioService : ICardapioService
{
    private readonly List<Categoria> _categorias;

    public CardapioService()
    {
        _categorias = CardapioData.GetCategorias();
    }

    public List<Categoria> GetTodas() => _categorias;

    public Categoria? GetPorId(int id) =>
        _categorias.FirstOrDefault(c => c.Id == id);
}
