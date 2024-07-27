# Desafio-People4Tech

Teste de Conhecimentos em .NET, Padrões de Arquitetura e Princípios SOLID

Parte 1: Questões Teóricas
1. Explique o que são os princípios SOLID e como cada um deles pode ser aplicado em um projeto desenvolvido em .NET.
2. Quais são os principais padrões de arquitetura de software utilizados em aplicações .NET? Descreva dois desses padrões e seus benefícios.
3. Por que é importante separar a lógica de negócios da lógica de apresentação em uma aplicação .NET? Como isso pode ser alcançado?

Parte 2: Desenvolvimento Prático
Você foi designado para desenvolver uma pequena aplicação de gestão de tarefas em .NET. Utilize os princípios SOLID e considere um padrão arquitetural apropriado para o desenvolvimento desta aplicação. Siga as instruções abaixo:

1. Modelagem de Dados: Crie uma classe Task com os seguintes atributos: Id, Title, Description, DueDate, Priority.
2. Interface de Repositório: Defina uma interface ITaskRepository com métodos para adicionar, remover, atualizar e listar tarefas.
3. Implementação do Repositório: Implemente a interface ITaskRepository utilizando uma estrutura de dados adequada (ex: lista, banco de dados em memória).
4. Camada de Serviços: Crie uma classe TaskService que utilize o ITaskRepository para gerenciar as operações de negócio relacionadas às tarefas (ex: adicionar, remover, atualizar).
5. Camada de Apresentação: Desenvolva uma interface simples (pode ser console, web ou outra) para interagir com o TaskService e permitir ao usuário realizar operações básicas de CRUD (Create, Read, Update, Delete) de tarefas.

Critérios de Avaliação:
• Adesão aos princípios SOLID.
• Utilização adequada de padrões de arquitetura.
• Clareza e organização do código.
• Funcionalidade correta e completa da aplicação desenvolvida.
• Tratamento de exceções e erros.

Instruções:
• Utilize C# e .NET Framework/Core para desenvolver a aplicação.
• Documente seu código conforme necessário para explicar decisões de design e implementação.
• Submeta seu projeto em um repositório Git público ou envie um arquivo compactado com o código fonte.
