# Desafio Técnico - Decomposição de Números

Este projeto foi desenvolvido como parte de um desafio técnico para demonstrar habilidades em C#, boas práticas de programação, e criação de APIs.

## Funcionalidades

- **Console App:** Decomposição de um número em todos os seus divisores e identificação dos divisores primos.
- **API:** Disponibiliza a funcionalidade de decomposição de números como um serviço RESTful.
- **Testes Unitários:** Implementados para garantir a qualidade do código, cobrindo os principais serviços e funcionalidades.

## Estrutura do Projeto

- **NumeroDecomposicao.Api/**: Contém a API que expõe a funcionalidade via HTTP.
- **NumeroDecomposicao.Tests/**: Projeto de testes unitários utilizando xUnit.
- **NumeroDecomposicao/**: Console App que realiza a decomposição de números.

## Tecnologias Utilizadas

- **C#**
- **.NET Core**
- **xUnit** para testes unitários
- **Swagger** para documentação da API

## Como Executar

### Console App
1. Navegue até a pasta `NumeroDecomposicao`.
2. Execute o comando `dotnet run` para iniciar a aplicação de console.

### API
1. Navegue até a pasta `NumeroDecomposicao.Api`.
2. Execute `dotnet run` para iniciar a API.
3. Acesse o Swagger UI em `https://localhost:{porta}/swagger` para testar os endpoints.

### Testes
1. Navegue até a pasta `NumeroDecomposicao.Tests`.
2. Execute `dotnet test` para rodar todos os testes.
