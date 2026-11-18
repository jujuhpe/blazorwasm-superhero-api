# BlazorWasmSuperHeroApi

Aplicação em C# e Blazor WebAssembly para pesquisar personagens e exibir seus dados, imagens e powerstats usando a [SuperHero API](https://superheroapi.com/). O projeto usa o endpoint `https://www.superheroapi.com/api.php/{access-token}/search/{nome}` indicado no roteiro.

## Executar

Pré-requisito: .NET SDK 10 e conexão com a internet.

Abra a pasta `BlazorWasmSuperHeroApi` no VS Code e execute no terminal:

```powershell
dotnet run --launch-profile http
```

Acesse http://localhost:5149. Gere um token de acesso no site da SuperHero API com sua conta GitHub, cole o token no primeiro campo e pesquise nomes como `Batman`, `Spider-Man` ou `Wonder Woman`.

## O que a aplicação mostra

- Resultados da busca por nome, com foto e identificação.
- Powerstats: inteligência, força, velocidade, resistência, poder e combate.
- Biografia: nome civil, editora e alinhamento.
- Aparência: espécie, altura e peso; além da ocupação.
- Estados de carregamento, campos vazios, erros de autenticação, falhas de rede e buscas sem resultados.

O token fica apenas na memória da página durante a sessão e é enviado à API como parte do caminho da requisição. Ele não é salvo no código nem no armazenamento do navegador. Não compartilhe capturas de tela que mostrem o token.

## Estrutura

```text
BlazorWasmSuperHeroApi/
  Models/HeroSearchResponse.cs  Modelos da resposta JSON
  Pages/Home.razor             Busca, validação e exibição dos personagens
  Program.cs                   HttpClient configurado para a SuperHero API
  Layout/MainLayout.razor       Cabeçalho e rodapé do site
  wwwroot/css/app.css           Estilos responsivos
```

Documentação da API: https://superheroapi.com/

