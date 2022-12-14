## Projeto

Este projeto foi desenvolvido com Visual Studio com VB.NET e atualizado para a versão 2022 com o .NET 4.8 mas exige > .NET 4.5.2)
(Pode ser alterado no arquivo de solução)

## Introdução

Este trabalho consiste em aplicar e avaliar um algoritmo genético básico para a minimização da função f, no intervalo [ 512; 512] e definida por:

<p align="center"> 
<img src=https://github.com/geraldoaax/AlgoritmoGenetico-Tomassini/blob/main/AG/img/funcao_tomassini.png/>
<br/>
</p>
 
A figura abaixo apresenta o gráfico da função nesse intervalo proposto no exemplo 3 do artigo A Survey of Genetic Algorithms de M. Tomassini. Pode-se buscar a solução no subintervalo [0, 512] e “espelhar” os valores encontrados no intervalo onde x < 0.

<p align="center"> 
<img src=https://github.com/geraldoaax/AlgoritmoGenetico-Tomassini/blob/main/AG/img/grafico_funcao.png/>
<br/>
Figura 1: Gráfico da função f no intervalo [-512, 512]
</p>

O trabalho proposto utiliza a codificação binária para os indivíduos. Com 10 bits temos 1024 valores diferentes (incluindo o 0). 
Como lidamos com minimização de funções significa que valores de x que resultam nos menores valores de f (x) são na realidade indivíduos com maior aptidão. Como a função analisada não assume valores positivos, a aptidão pode ser definida por g(x) =  f (x). 

A solução implementada adotou uma população constante de 50 indivíduos. A seleção dos pais para as novas gerações é feita pelo método da roleta viciada. Um limite de 50 gerações é suficiente para esse problema. 

Sobre a parametrização do algoritmo genético aplicado a este problema, foi constatado que:

1. sempre que um bom indivíduo é encontrado, dificilmente ele permanece intacto por várias gerações.
2. valores muito elevados para a taxa de recombinação resultam na perda de bons indivíduos devido à recombinação.
3. valores muito pequenos para esses parâmetros tornam o processo evolutivo mais lento.

<p align="center"> 
<img src=https://github.com/geraldoaax/AlgoritmoGenetico-Tomassini/blob/main/AG/img/resultado.png/>
<br/>
</p>
