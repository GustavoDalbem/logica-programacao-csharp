# Lógica de Programação em C#

Exercícios e anotações dos meus estudos de lógica de programação usando C#.

## Projetos

| # | Projeto | Assunto |
|---|---------|---------|
| 1 | [SaidaDeDadosEmCSharp](SaidaDeDadosEmCSharp) | Saída de dados: `Console.Write`, `Console.WriteLine`, formatação de números (`ToString("F2")`), `CultureInfo` e concatenação de texto |
| 2 | [ProcessamentoDeDadosEmCSharpCasting](ProcessamentoDeDadosEmCSharpCasting) | Processamento de dados e casting: operações com `int` e `double`, divisão de inteiros e conversão entre tipos |
| 3 | [EntradaDeDadosEmCSharpParte1](EntradaDeDadosEmCSharpParte1) | Entrada de dados: `Console.ReadLine` e `Split` para ler várias palavras na mesma linha |
| 4 | [EntradaDeDadosEmCSharpParte2](EntradaDeDadosEmCSharpParte2) | Entrada de dados: conversão com `int.Parse`, `char.Parse` e `double.Parse`, com exercício de fixação |
| 5 | [ExercicioResolvido01](ExercicioResolvido01) | Exercício resolvido: cálculo da área e do preço de um terreno a partir da largura, comprimento e preço do metro quadrado |
| 6 | [FuncoesMatematicasEmCSharp](FuncoesMatematicasEmCSharp) | Funções matemáticas da classe `Math`: `Sqrt` (raiz quadrada), `Pow` (potência) e `Abs` (valor absoluto) |

## Exercícios do URI Online Judge (beecrowd)

Ficam na pasta [URI](URI), um projeto por problema, com o número do problema no nome.

| Problema | Projeto | Assunto |
|----------|---------|---------|
| 1001 | [URI1001ExtremamenteBasico](URI/URI1001ExtremamenteBasico) | Extremamente Básico: lê dois inteiros e mostra a soma |
| 1002 | [URI1002AreaDoCirculo](URI/URI1002AreaDoCirculo) | Área do Círculo: lê o raio e calcula a área com `Math.Pow`, mostrando 4 casas decimais |
| 1003 | [URI1003SomaSimples](URI/URI1003SomaSimples) | Soma Simples: lê dois inteiros e mostra `SOMA = ` com o resultado |
| 1004 | [URI1004ProdutoSimples](URI/URI1004ProdutoSimples) | Produto Simples: lê dois inteiros e mostra `PROD = ` com a multiplicação |
| 1005 | [URI1005Media1](URI/URI1005Media1) | Média 1: média ponderada de duas notas (pesos 3.5 e 7.5) com 5 casas decimais |
| 1006 | [URI1006Media2](URI/URI1006Media2) | Média 2: média ponderada de três notas (pesos 2, 3 e 5) com 1 casa decimal |
| 1007 | [URI1007Diferenca](URI/URI1007Diferenca) | Diferença: lê quatro inteiros e calcula `A * B - C * D` |
| 1008 | [URI1008Salario](URI/URI1008Salario) | Salário: calcula o salário a partir das horas trabalhadas e do valor da hora (`int` x `double`) |
| 1010 | [URI1010CalculoSimples](URI/URI1010CalculoSimples) | Cálculo Simples: lê duas linhas com `Split` (vetores) e calcula o valor a pagar pelas peças |
| 1014 | [URI1014Consumo](URI/URI1014Consumo) | Consumo: calcula o consumo médio (km/l) com 3 casas decimais |
| 1016 | [URI1016Distancia](URI/URI1016Distancia) | Distância: calcula em quantos minutos um carro alcança o outro |
| 1017 | [URI1017GastoDeCombustivel](URI/URI1017GastoDeCombustivel) | Gasto de Combustível: litros gastos na viagem, usando casting `(double)` antes da divisão |

## Como rodar

Cada pasta é um projeto separado. Abra o arquivo `.slnx` no Visual Studio, ou rode pelo terminal:

```bash
dotnet run --project SaidaDeDadosEmCSharp/SaidaDeDadosEmCSharp
```
