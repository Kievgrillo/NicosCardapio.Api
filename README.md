# 🍺 Nico's Distribuidora — Cardápio Digital

> Cardápio digital via QR Code para a **Nico's Distribuidora**. Desenvolvido com ASP.NET Core 8 + HTML/CSS/JS puro, sem dependências de frontend. Basta escanear o QR Code na mesa para visualizar o cardápio completo no celular.

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-ASP.NET%20Core-239120?style=flat-square&logo=csharp)
![Deploy](https://img.shields.io/badge/Deploy-Render-46E3B7?style=flat-square&logo=render)
![License](https://img.shields.io/badge/License-MIT-yellow?style=flat-square)

---

## 📱 Como funciona

1. O cliente escaneia o QR Code na mesa com a câmera do celular
2. O navegador abre automaticamente o cardápio digital
3. O cardápio é servido pela API e exibido em tempo real
4. Funciona em **Android e iOS** sem instalar nenhum app

---

## 🗂️ Arquitetura

```
NicosCardapio.Api/
├── Controllers/
│   └── CardapioController.cs   # Endpoints REST da API
├── Data/
│   └── CardapioData.cs         # Dados dos itens e preços
├── Models/
│   └── Cardapio.cs             # Modelos Categoria e Item
├── Services/
│   └── CardapioService.cs      # Regra de negócio
├── wwwroot/
│   └── index.html              # Frontend (HTML/CSS/JS)
├── Program.cs                  # Configuração da aplicação
├── appsettings.json            # Porta e configurações
└── NicosCardapio.Api.csproj    # Projeto .NET 8
```

### Separação de responsabilidades

| Camada | Arquivo | Responsabilidade |
|---|---|---|
| **Model** | `Cardapio.cs` | Define a estrutura de dados |
| **Data** | `CardapioData.cs` | Fonte dos dados do cardápio |
| **Service** | `CardapioService.cs` | Regras de negócio e acesso aos dados |
| **Controller** | `CardapioController.cs` | Exposição dos endpoints REST |
| **Frontend** | `wwwroot/index.html` | Interface do usuário mobile |

---

## 🚀 Rodando localmente

### Pré-requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Passos

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/NicosCardapio.Api.git
cd NicosCardapio.Api

# Rode o projeto
dotnet run
```

Acesse no navegador:
```
http://localhost:5000
```

Ou no celular (mesma rede Wi-Fi):
```
http://SEU_IP_LOCAL:5000
```
---

## 🌐 Endpoints da API

| Método | Rota | Descrição |
|---|---|---|
| `GET` | `/api/cardapio` | Retorna todas as categorias e itens |
| `GET` | `/api/cardapio/{id}` | Retorna uma categoria específica |


A documentação interativa via Swagger está disponível em:
```
http://localhost:5000/swagger
```

---

## 📦 Deploy

O projeto está configurado para deploy via **Docker** no [Render](https://render.com).

### Dockerfile

```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "NicosCardapio.Api.dll"]
```

### Passo a passo no Render

1. Faça push do projeto no GitHub
2. Acesse [render.com](https://render.com) e crie um **New Web Service**
3. Conecte o repositório do GitHub
4. Configure:
   - **Language:** Docker
   - **Instance Type:** Free
5. Clique em **Deploy Web Service**
6. Aguarde ~3 minutos — a URL pública será gerada automaticamente

---

## ✏️ Atualizando o cardápio

Para alterar preços ou adicionar itens, edite o arquivo:

```
NicosCardapio.Api/Data/CardapioData.cs
```

Após editar, faça commit e push — o Render faz o redeploy automaticamente.

---

## 📋 Categorias do cardápio

| # | Categoria |
|---|---|
| 1 | 🍺 Cervejas |
| 2 | 🥤 Refrigerantes |
| 3 | 💧 Água |
| 4 | ⚡ Energéticos |
| 5 | 🥃 Doses |
| 6 | 🍹 Drinks |
| 7 | 🧃 Sucos |
| 8 | 🧊 Gelo |
| 9 | 🍟 Porções |
| 10 | 🥩 Espetinho |

---

## 🖨️ QR Code

O QR Code foi gerado apontando para a URL pública do Render e impresso em plaquinhas plastificadas para as mesas da distribuidora.

Para gerar um novo QR Code, acesse qualquer gerador gratuito como [qr-code-generator.com](https://www.qr-code-generator.com) e cole a URL do seu deploy.

---

## 🛠️ Tecnologias utilizadas

- **Backend:** C# — ASP.NET Core 8
- **Frontend:** HTML5, CSS3, JavaScript (Vanilla)
- **Documentação:** Swagger / OpenAPI
- **Deploy:** Docker + Render
- **QR Code:** Python (qrcode + Pillow) para geração da plaquinha

---

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

<p align="center">Feito com ☕ para a <strong>Nico's Distribuidora</strong></p>
