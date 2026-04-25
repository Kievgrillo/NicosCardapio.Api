using NicosCardapio.Api.Models;

namespace NicosCardapio.API.Data;

public static class CardapioData
{
    public static List<Categoria> GetCategorias()
    {
        return new List<Categoria>
        {
            new Categoria
            {
                Id = 1,
                Nome = "Cervejas",
                Icone = "🍺",
                Itens = new List<Item>
                {
                    new Item { Id = 1,  Nome = "Bohemia Litrinho",        Preco = 3.50m,  SubCategoria = "Bohemia" },
                   
                    new Item { Id = 2,  Nome = "Brahma Litrinho",         Preco = 3.00m,  SubCategoria = "Brahma" },
                    new Item { Id = 3,  Nome = "Brahma Litrão",           Preco = 10.00m, SubCategoria = "Brahma" },
                    new Item { Id = 4,  Nome = "Brahma Latão",            Preco = 5.00m,  SubCategoria = "Brahma" },
                    new Item { Id = 5,  Nome = "Brahma Zero",             Preco = 4.50m,  SubCategoria = "Brahma" },
                    
                    new Item { Id = 6,  Nome = "Budweiser Litrinho",      Preco = 3.50m,  SubCategoria = "Budweiser" },
                    new Item { Id = 7,  Nome = "Budweiser Litrão",        Preco = 10.00m, SubCategoria = "Budweiser" },
                    new Item { Id = 8,  Nome = "Budweiser Latão",         Preco = 5.50m,  SubCategoria = "Budweiser" },
                    new Item { Id = 9,  Nome = "Budweiser Longnek",       Preco = 5.50m,  SubCategoria = "Budweiser" },
                   
                    new Item { Id = 10, Nome = "Corona Latão",            Preco = 7.50m,  SubCategoria = "Corona" },
                    new Item { Id = 11, Nome = "Corona Longnek",          Preco = 7.50m,  SubCategoria = "Corona" },
                    new Item { Id = 12, Nome = "Corona Zero",             Preco = 7.50m,  SubCategoria = "Corona" },
                    
                    new Item { Id = 13, Nome = "Original Litrinho",       Preco = 4.00m,  SubCategoria = "Original" },
                    new Item { Id = 14, Nome = "Original Latão",          Preco = 6.00m,  SubCategoria = "Original" },
                    new Item { Id = 15, Nome = "Original 600ml",          Preco = 9.00m,  SubCategoria = "Original" },
                    
                    new Item { Id = 16, Nome = "Skol Litrinho",           Preco = 3.00m,  SubCategoria = "Skol" },
                    new Item { Id = 17, Nome = "Skol Litrão",             Preco = 10.00m, SubCategoria = "Skol" },
                    new Item { Id = 18, Nome = "Skol Latão",              Preco = 5.00m,  SubCategoria = "Skol" },
                    
                    new Item { Id = 19, Nome = "Spaten 600ml",            Preco = 11.00m, SubCategoria = "Spaten" },
                    new Item { Id = 20, Nome = "Spaten Latão",            Preco = 6.00m,  SubCategoria = "Spaten" },
                    
                    new Item { Id = 21, Nome = "Stella Latão",            Preco = 7.00m,  SubCategoria = "Stella Artois" },
                    new Item { Id = 22, Nome = "Stella Gold",             Preco = 7.50m,  SubCategoria = "Stella Artois" },
                    new Item { Id = 23, Nome = "Stella 600ml",            Preco = 13.00m, SubCategoria = "Stella Artois" },
                    new Item { Id = 24, Nome = "Stella Longnek",          Preco = 6.50m,  SubCategoria = "Stella Artois" },
                    
                    new Item { Id = 25, Nome = "Amstel Litrão",           Preco = 10.00m, SubCategoria = "Amstel" },
                    new Item { Id = 26, Nome = "Amstel Latão",            Preco = 5.50m,  SubCategoria = "Amstel" },
                    new Item { Id = 27, Nome = "Amstel Ultra",            Preco = 5.50m,  SubCategoria = "Amstel" },
                    new Item { Id = 28, Nome = "Amstel 600",              Preco = 9.00m,  SubCategoria = "Amstel" },
                    
                    new Item { Id = 29, Nome = "Heineken Latão",          Preco = 7.00m,  SubCategoria = "Heineken" },
                    new Item { Id = 30, Nome = "Heineken 600ml",          Preco = 13.00m, SubCategoria = "Heineken" },
                    new Item { Id = 31, Nome = "Heineken Longnek",        Preco = 7.00m,  SubCategoria = "Heineken" },
                    new Item { Id = 32, Nome = "Heineken Zero Lata",      Preco = 6.00m,  SubCategoria = "Heineken" },
                    new Item { Id = 33, Nome = "Heineken Zero Long",      Preco = 7.50m,  SubCategoria = "Heineken" },
                    
                    new Item { Id = 34, Nome = "Baden IPA 350ml",         Preco = 6.50m,  SubCategoria = "Especiais" },
                    new Item { Id = 35, Nome = "Eisenbahn IPA",           Preco = 7.50m,  SubCategoria = "Especiais" },
                    new Item { Id = 36, Nome = "Eisenbahn Latão",         Preco = 5.00m,  SubCategoria = "Especiais" },
                    new Item { Id = 37, Nome = "Eisenbahn Long",          Preco = 6.00m,  SubCategoria = "Especiais" },
                    
                    new Item { Id = 38, Nome = "Petra Latão",             Preco = 5.00m,  SubCategoria = "Outras" },
                    new Item { Id = 39, Nome = "Itaipava",                Preco = 4.50m,  SubCategoria = "Outras" },
                    new Item { Id = 40, Nome = "Praya",                   Preco = 8.00m,  SubCategoria = "Outras" },
                    new Item { Id = 41, Nome = "Império",                 Preco = 5.00m,  SubCategoria = "Outras" },
                    new Item { Id = 42, Nome = "Sol Zero",                Preco = 7.00m,  SubCategoria = "Outras" },
                }
            },

            new Categoria
            {
                Id = 2,
                Nome = "Refrigerantes",
                Icone = "🥤",
                Itens = new List<Item>
                {
                    new Item { Id = 50, Nome = "Guaraná Lata",            Preco = 5.00m,  SubCategoria = "Guaraná" },
                    new Item { Id = 51, Nome = "Guaraná Antártica 1L",    Preco = 7.00m,  SubCategoria = "Guaraná" },
                    new Item { Id = 52, Nome = "Guaraná Antártica 2L",    Preco = 10.00m, SubCategoria = "Guaraná" },
                    new Item { Id = 53, Nome = "Coca-Cola Lata",          Preco = 5.00m,  SubCategoria = "Coca-Cola" },
                    new Item { Id = 54, Nome = "Coca-Cola 600ml",         Preco = 7.00m,  SubCategoria = "Coca-Cola" },
                    new Item { Id = 55, Nome = "Coca-Cola Vidro 1L",      Preco = 8.00m,  SubCategoria = "Coca-Cola" },
                    new Item { Id = 56, Nome = "Coca-Cola 1,5L",          Preco = 10.00m, SubCategoria = "Coca-Cola" },
                    new Item { Id = 57, Nome = "Coca-Cola 2L",            Preco = 12.00m, SubCategoria = "Coca-Cola" },
                    new Item { Id = 58, Nome = "Coca-Cola Zero 1,5L",     Preco = 10.00m, SubCategoria = "Coca-Cola Zero" },
                    new Item { Id = 59, Nome = "Coca-Cola Zero 2L",       Preco = 12.00m, SubCategoria = "Coca-Cola Zero" },
                    new Item { Id = 60, Nome = "Coca-Cola Zero 600ml",    Preco = 7.00m,  SubCategoria = "Coca-Cola Zero" },
                    new Item { Id = 61, Nome = "Fanta Laranja 2L",        Preco = 10.00m, SubCategoria = "Fanta" },
                    new Item { Id = 62, Nome = "Fanta Uva 1,5L",          Preco = 8.00m,  SubCategoria = "Fanta" },
                    new Item { Id = 63, Nome = "Fanta Uva 2L",            Preco = 10.00m, SubCategoria = "Fanta" },
                    new Item { Id = 64, Nome = "Sprite 2L",               Preco = 9.00m,  SubCategoria = "Outras" },
                    new Item { Id = 65, Nome = "Refrigerante UAI",        Preco = 6.00m,  SubCategoria = "Outras" },
                    new Item { Id = 66, Nome = "Schwepps Lata",           Preco = 5.00m,  SubCategoria = "Outras" },
                }
            },

            new Categoria
            {
                Id = 3,
                Nome = "Água",
                Icone = "💧",
                Itens = new List<Item>
                {
                    new Item { Id = 70, Nome = "H2O 500ml",               Preco = 6.00m },
                    new Item { Id = 71, Nome = "H2O 1,5L",                Preco = 9.00m },
                    new Item { Id = 72, Nome = "H2O Limoneto 500ml",      Preco = 6.00m },
                    new Item { Id = 73, Nome = "H2O Limoneto 1,5L",       Preco = 9.00m },
                    new Item { Id = 74, Nome = "Água com Gás 500ml",      Preco = 3.00m },
                    new Item { Id = 75, Nome = "Água com Gás 1,5L",       Preco = 6.00m },
                    new Item { Id = 76, Nome = "Água sem Gás 500ml",      Preco = 2.00m },
                    new Item { Id = 77, Nome = "Água sem Gás 1,5L",       Preco = 5.00m },
                    new Item { Id = 78, Nome = "Água 5L",                 Preco = 13.00m },
                    new Item { Id = 79, Nome = "Água Tônica Lata",        Preco = 5.00m },
                }
            },

            new Categoria
            {
                Id = 4,
                Nome = "Energéticos",
                Icone = "⚡",
                Itens = new List<Item>
                {
                    new Item { Id = 80, Nome = "Red Bull 250ml",          Preco = 11.00m },
                    new Item { Id = 81, Nome = "Red Bull Latão",          Preco = 16.00m },
                    new Item { Id = 82, Nome = "Monster",                 Preco = 11.00m },
                    new Item { Id = 83, Nome = "Bally 2L",                Preco = 15.00m },
                    new Item { Id = 84, Nome = "Start 2L",                Preco = 13.00m },
                }
            },

            new Categoria
            {
                Id = 5,
                Nome = "Doses",
                Icone = "🥃",
                Itens = new List<Item>
                {
                    new Item { Id = 90, Nome = "Campari",                 Preco = 10.00m, SubCategoria = "Doses" },
                    new Item { Id = 91, Nome = "Dreher",                  Preco = 5.00m,  SubCategoria = "Doses" },
                    new Item { Id = 92, Nome = "Whisky Mel",              Preco = 15.00m, SubCategoria = "Doses" },
                    new Item { Id = 93, Nome = "Whisky",                  Preco = 12.00m, SubCategoria = "Doses" },
                    new Item { Id = 94, Nome = "Chapelão",                Preco = 4.00m,  SubCategoria = "Doses" },
                    new Item { Id = 95, Nome = "Paratudo",                Preco = 5.00m,  SubCategoria = "Doses" },
                    new Item { Id = 96, Nome = "Alcatrão",                Preco = 5.00m,  SubCategoria = "Doses" },
                    new Item { Id = 97, Nome = "Ballatines Copão 700ml",  Preco = 20.00m, SubCategoria = "Copão 700ml" },
                    new Item { Id = 98, Nome = "Cavalo Branco Copão 700ml", Preco = 20.00m, SubCategoria = "Copão 700ml" },
                    new Item { Id = 99, Nome = "Red Label Copão 700ml",   Preco = 25.00m, SubCategoria = "Copão 700ml" },
                    new Item { Id = 100, Nome = "Gin Copão 700ml",        Preco = 18.00m, SubCategoria = "Copão 700ml" },
                }
            },

            new Categoria
            {
                Id = 6,
                Nome = "Drinks",
                Icone = "🍹",
                Itens = new List<Item>
                {
                    new Item { Id = 110, Nome = "Wemix",                  Preco = 5.50m,  SubCategoria = "Prontos" },
                    new Item { Id = 111, Nome = "Ice Of",                 Preco = 4.00m,  SubCategoria = "Prontos" },
                    new Item { Id = 112, Nome = "Ice Smirnoff",           Preco = 9.00m,  SubCategoria = "Prontos" },
                    new Item { Id = 113, Nome = "Skol Beats Latão",       Preco = 10.00m, SubCategoria = "Prontos" },
                    new Item { Id = 114, Nome = "Michelada",              Preco = 19.90m, SubCategoria = "Especiais",
                        Descricao = "Cerveja Long Neck Corona com limão, gelo, sal e pimenta do reino" },
                    new Item { Id = 115, Nome = "Soda Italiana",          Preco = 19.90m, SubCategoria = "Especiais",
                        Descricao = "Água com gás, gelo e Monin — Sabores: Maçã Verde ou Melancia" },
                }
            },

            new Categoria
            {
                Id = 7,
                Nome = "Sucos",
                Icone = "🧃",
                Itens = new List<Item>
                {
                    new Item { Id = 120, Nome = "Suco Caixa",             Preco = 8.00m },
                    new Item { Id = 121, Nome = "Gatorade",               Preco = 6.50m },
                }
            },

            new Categoria
            {
                Id = 8,
                Nome = "Gelo",
                Icone = "🧊",
                Itens = new List<Item>
                {
                    new Item { Id = 130, Nome = "Gelo 4kg",               Preco = 12.00m },
                    new Item { Id = 131, Nome = "Gelo 10kg",              Preco = 18.00m },
                    new Item { Id = 132, Nome = "Gelo 20kg",              Preco = 25.00m },
                }
            },

            new Categoria
            {
                Id = 9,
                Nome = "Porções",
                Icone = "🍟",
                Itens = new List<Item>
                {
                    new Item { Id = 140, Nome = "Batata Frita",               Preco = 29.90m },
                    new Item { Id = 141, Nome = "Batata com Cheddar e Bacon", Preco = 44.90m },
                    new Item { Id = 142, Nome = "Filé de Frango com Batata Frita", Preco = 59.90m },
                    new Item { Id = 143, Nome = "Linguiça Caseira",           Preco = 44.90m },
                    new Item { Id = 144, Nome = "Frango a Passarinho",        Preco = 39.90m },
                    new Item { Id = 145, Nome = "Porção de Salgado",          Preco = 24.90m,
                        Descricao = "15 salgados sortidos" },
                    new Item { Id = 146, Nome = "Porção Kids",               Preco = 24.90m,
                        Descricao = "5 tekitos, 5 salgados e 100g de batata frita" },
                    new Item { Id = 147, Nome = "Salgados Fritos",           Preco = 12.00m, SubCategoria = "Salgados" },
                }
            },

            new Categoria
            {
                Id = 10,
                Nome = "Espetinho",
                Icone = "🥩",
                Itens = new List<Item>
                {
                    new Item { Id = 150, Nome = "Espetinho de Boi",       Preco = 11.00m, SubCategoria = "R$ 11,00" },
                    new Item { Id = 151, Nome = "Espetinho de Frango",    Preco = 11.00m, SubCategoria = "R$ 11,00" },
                    new Item { Id = 152, Nome = "Espetinho Misto",        Preco = 11.00m, SubCategoria = "R$ 11,00" },
                    new Item { Id = 153, Nome = "Espetinho Kafta",        Preco = 11.00m, SubCategoria = "R$ 11,00" },
                    new Item { Id = 154, Nome = "Espetinho de Queijo",    Preco = 11.00m, SubCategoria = "R$ 11,00" },
                    new Item { Id = 155, Nome = "Costela",                Preco = 13.00m, SubCategoria = "R$ 13,00" },
                    new Item { Id = 156, Nome = "Medalhão de Boi",        Preco = 13.00m, SubCategoria = "R$ 13,00" },
                    new Item { Id = 157, Nome = "Medalhão de Frango",     Preco = 13.00m, SubCategoria = "R$ 13,00" },
                }
            }
        };
    }
}
