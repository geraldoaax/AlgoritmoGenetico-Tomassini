Este trabalho consiste em aplicar e avaliar um algoritmo gen�tico b�sico para a minimiza��o da fun��o f, no intervalo [ 512; 512] e definida por:
 
A figura abaixo apresenta o gr�fico da fun��o nesse intervalo proposto no exemplo 3 do artigo A Survey of Genetic Algorithms de M. Tomassini. Pode-se buscar a solu��o no subintervalo [0, 512] e �espelhar� os valores encontrados no intervalo onde x < 0.
 
Figura 1: Gr�fico da fun��o f no intervalo [-512, 512]
O trabalho proposto utiliza a codifica��o bin�ria para os indiv�duos. Com 10 bits temos 1024 valores diferentes (incluindo o 0). 
Como lidamos com minimiza��o de fun��es significa que valores de x que resultam nos menores valores de f (x) s�o na realidade indiv�duos com maior aptid�o. Como a fun��o analisada n�o assume valores positivos, a aptid�o pode ser definida por g(x) =  f (x). 
A solu��o implementada adotou uma popula��o constante de 50 indiv�duos. A sele��o dos pais para as novas gera��es � feita pelo m�todo da roleta viciada. Um limite de 50 gera��es � suficiente para esse problema. 
Sobre a parametriza��o do algoritmo gen�tico aplicado a este problema, foi constatado que:
1.empre que um bom indiv�duo � encontrado, dificilmente ele permanece intacto por v�rias gera��es.
2. valores muito elevados para a taxa de recombina��o resultam na perda de bons indiv�duos devido � recombina��o.
3. valores muito pequenos para esses par�metros tornam o processo evolutivo mais lento.
 
