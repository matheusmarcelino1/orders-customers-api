## 1. O que é DDD?
Domain-Driven Design é uma abordagem de desenvolvimento de software focada no domínio do negócio. A ideia central é modelar o sistema com base nas regras e comportamentos do negócio, mantendo o domínio isolado de detalhes técnicos como banco de dados ou frameworks.
No projeto, o conceito foi aplicado por meio da separação clara entre as camadas de Domain (entidades e regras), Application, Infrastructure e API, garantindo organização, baixo acoplamento e maior facilidade de manutenção.


## 2. O que é API REST?
API REST é um estilo arquitetural para construção de APIs que utilizam o protocolo HTTP para comunicação entre sistemas.
Baseia-se em princípios como uso de verbos HTTP (GET, POST, PUT, DELETE) e recursos identificados por URLs.


## 3. Diferença entre banco relacional e não relacional
Banco Relacional:
- Estruturado em tabelas
- Utiliza SQL

Banco Não Relacional:
- Estrutura mais flexível (documentos, chave-valor, grafos)
- Melhor escalabilidade horizontal
- Exemplo: MongoDB, Redis

Bancos relacionais utilizam tabelas com esquema definido e relacionamentos entre entidades, garantindo integridade referencial. 
Já bancos não relacionais possuem estrutura mais flexível, sendo indicados para cenários que exigem maior escalabilidade horizontal ou dados menos estruturados.


## 4. Para que serve o Git?
Git é um sistema de controle de versão distribuído que permite acompanhar e gerenciar alterações no código ao longo do tempo. Ele possibilita controle de histórico, criação de branches, reversão de alterações e colaboração entre desenvolvedores.
O projeto foi versionado desde sua criação, mantendo um histórico organizado das etapas de desenvolvimento.


## 5. Como rodar o projeto:
1. Clonar o repositório
2. Abrir a solution no Visual Studio
3. Definir OrdersCustomers.Api como Startup Project
4. Executar a aplicação
Obs: O banco SQLite será criado automaticamente na primeira execução através das migrations.


## 6. Tecnologias utilizadas:
- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- xUnit
- Swagger


## 7. Decisões técnicas:
- Estruturação do projeto em camadas para garantir separação de responsabilidades e organização do código.
- Utilização de SQLite visando simplicidade de execução e facilidade de avaliação do projeto.
- Uso do Entity Framework Core como ORM para abstração da persistência.
- Implementação de teste unitário na camada de Domain para validação das regras de negócio.
- Simulação de evento (PedidoCriadoEvent) para demonstrar o conceito de mensageria e arquitetura orientada a eventos.

## 8. Melhorias futuras:
- Implementação de Event Bus real (RabbitMQ ou similar)
- Validações adicionais nos serviços
- Autenticação e autorização
