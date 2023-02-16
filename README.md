# ProvaAlgoritimos
Prova aplicada para alunos particulares, exercicios de algoritimos com API c#
PROVA GA
"*"  multiplicação 
"+" Soma
"-" Subtração
"/" Divisão
"%" Resto da divisão
"+=" somar/concatenar a si mesmo
">" Maior que
"<" Menor que
"<=" Menor igual que
">=" Maior igual que
"!=" diferente de
"==" é igual a

"&&" Operador logico E
"||" Operador logico Ou


Clone esse repositório no github e e envie por push ao termino da prova

___
1) Exercicio 1, O sistema em que vc está trabalhando promete conseguir seguidores no instagram, seu trabalho é construir uma etapa que informe quanto tempo (em dias) vai levar para ela alcançar o resultado esperado. 
O usuario deve informar a quantidade de seguidores e em quanto quer chegar, o sistema deve calcular o tempo.
O sistema garante uma entrada de 50 seguidores por dia. 
Como o usuario quer saber o numero de dias o valor deve ser arredondado sempre para cima, utilize Math.Ceiling(VariavelDecimalNroDias) para arredondar.

2) Os dias da semana de um banco de dados estão salvo como numeros, sendo 0 o domingo e 6 sabado, da seguinte forma:
Domingo = 0
Segunda = 1
Terça = 2
Quarta =3, 
Quinta = 4
Sexta = 5
Sabado = 6
Você deve criar um metodo que leia esse numero e escreva retorne o dia da semana equivalente. O seu chefe deixou claro e É essencial que seja utilizado o swtich Case...

3) Vc precisa retornar o nome de uma pessoa, com base na sua descrição... Concatene ao retorno as pessoas que estão dentro dos parametros passado
Nome | Raça | idade | Genero
Luiz | Branco | 18 |Homem 
Carlos | Negro | 20 | Homem
Stefani | Branco | 20 | Mulher 
Claudia | Negro | 18 | Mulher 
Ou seja, 
se for passado Branco e 18 deve retornar Luiz e Claudia, caso um parametro não foi passado ele sera vazio por exemplo Raca == "";
Considere todos parametros de entrada como texto(string)
Exemplo: Entrada: Raca = "Branco", idade="", Genero=""
Retorno: ClaudiaStefani

4) Você recebe uma idade e precisa verificar qual situação da pessoa, sendo
 até 18 = jovem
0 a 60 = Adulto
maior que 60 = idoso
Seu chefe deixou claro que é essencial o uso de ternario. (Logica?verdadeiro:falso)

5) Você recebeu uma quantidade de Minutos e precisa converter isso em dias, horas, minutos. 
Exemplo: 1440 minutos equivalem a 1 dia, 0 horas e 0 minutos
1441 minutos equivalem a 1 dia, 0 horas e 1 minutos
Dica utilize o resto da divisão(%) para pegar o restante do dia
int restoMinutos = totalMinutes % 1440;

6) Ajude o professor leia 5 notas e tire a media, caso o aluno tirou >=6 aprovado, senão reprovado...  retorne a media e diga se ele está aprovado ou reprovado. Exemplo de retorno A media é 9 o aluno está APROVADO
