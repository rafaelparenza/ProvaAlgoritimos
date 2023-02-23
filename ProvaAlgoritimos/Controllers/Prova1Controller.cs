using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProvaAlgoritimos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Prova1Controller : ControllerBase
    {

        /*
         PROVA GA
            *  multiplicação 
            + Soma
            - Subtração
            / Divisão
            % Resto da divisão
            += somar/concatenar a si mesmo

            > Maior que
            < Menor que
            <= Menor igual que
            >= Maior igual que
            != diferente de
            == é igual a

            && Operador logico E
            || Operador logico Ou

            if(logica){}else{}
            logica?retornoverdadeiro:retornofalso;

            Está Liberado:
            Pesquisas e consultar material

            É PROIBIDO
            Pesquisar enunciados e solicitar ajuda de alguem.


            Essa prova tem como objetivo identificar se aluno adquiriu a capacidade de analise, implementar uma logica coerente com a descrição passada.
            

         */

        /*1) Exercicio 1, O sistema em que vc está trabalhando promete conseguir seguidores no instagram, 
         * seu trabalho é construir uma etapa que informe quanto tempo (em dias) vai levar para ela alcançar 
         * o resultado esperado. O usuario deve informar a quantidade de seguidores e em quanto quer chegar, 
         * o sistema deve calcular o tempo.O sistema garante uma entrada de 50 seguidores por dia. 
        Como o usuario quer saber o numero de dias o valor deve ser arredondado sempre para cima, utilize Math.Ceiling(VariavelDecimalNroDias) para arredondar.
*/
        [HttpGet("Ex1")]
        public int QuestaoNumero1(int seguidoresInicio, int metaSeguidores)
        {
            int retorno = 0;
            //(decimal) forçar para decimal, pois divisao de inteiros da inteiro
            decimal Nrodias = ((decimal)metaSeguidores - seguidoresInicio) / 50;
            int diasInteiros = (int)Nrodias;
            if(Nrodias- diasInteiros > 0)
            {
                diasInteiros = diasInteiros + 1;
            }
            retorno = diasInteiros;

            return retorno;
        }
        /*2) Os dias da semana de um banco de dados estão salvo como numeros, sendo 0 o domingo e 6 sabado, da seguinte forma:
        Domingo = 0
        Segunda = 1
        Terça = 2
        Quarta =3, 
        Quinta = 4
        Sexta = 5
        Sabado = 6

        Você deve criar um metodo que leia esse numero e escreva retorne o dia da semana equivalente. 
        O seu chefe deixou claro e É essencial que seja utilizado o swtich Case...

*/
        [HttpGet("Ex2")]

        public string QuestaoNumero2(int diaSemanaEquivalente)
        {
            string retorno = "";

            switch (diaSemanaEquivalente)
            {
                case 0:
                    retorno += "Domingo";
                    break;
                case 1:
                    retorno += "Segunda-feira";
                    break;
                case 2:
                    retorno += "Terça-feira";
                    break;
                case 3:
                    retorno += "Quarta-feira";
                    break;
                case 4:
                    retorno += "Quinta-feira";
                    break;
                case 5:
                    retorno += "Sexta-feira";
                    break;
                case 6:
                    retorno += "Sábado";
                    break;
                default:
                    retorno += "Dia inválido";
                    break;
            }

            return retorno;
        }

        /*3) Vc precisa retornar o nome de uma pessoa, com base na sua descrição... Concatene ao retorno as pessoas que estão dentro dos parametros passado
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

*/

        [HttpGet("Ex3")]

        public string QuestaoNumero3(string raca = "", string idade = "", string genero = "")
        {
            string retorno = "";

            string branco = "branco";
            string negro = "negro";
            string luiz = "Luiz";
            string Carlos = "Carlos";
            string Stefani = "Stefani";
            string Claudia = "Claudia";
            string homem = "homem";
            string mulher = "mulher";

            if(raca== branco)
            {
                if (idade == "" && genero == "")
                {
                    retorno = Stefani + luiz;
                }
                else if(idade== "18")
                {
                    if (genero == "")
                    {
                        retorno = luiz;
                    }
                    else if(genero == homem)
                    {
                        retorno = luiz;
                    }                    
                }
                else if(idade=="20")
                {

                }
            }

            return retorno;
        }

        /*4) Você recebe uma idade e precisa verificar qual situação da pessoa, sendo
             até 18 = jovem
            0 a 60 = Adulto
            maior que 60 = idoso
            Seu chefe deixou claro que é essencial o uso de ternario. (Logica?verdadeiro:falso)

*/

        [HttpGet("Ex4")]

        public string QuestaoNumero4(decimal idade)
        {
            string retorno = "";
            retorno = (idade <= 18 ? "jovem" : idade <= 60 ? "adulto" : " idoso");

            return retorno;
        }

        /*
         5) Você recebeu uma quantidade de Minutos e precisa converter isso em dias, horas, minutos. 
            Exemplo: 1440 minutos equivalem a 1 dia, 0 horas e 0 minutos
            1441 minutos equivalem a 1 dia, 0 horas e 1 minutos
            Dica utilize o resto da divisão(%) para pegar o restante do dia
            int restoMinutos = totalMinutes % 1440;

         */

        [HttpGet("Ex5")]

        public string QuestaoNumero5(decimal minutos)
        {
            string retorno = "";
            int dias = (int)minutos / 1440;
            int restoMinutos = (int)minutos % 1440;
            int horas = restoMinutos % 60;
            int min = horas - restoMinutos;


            return ""+dias + horas + min;
        }

        /*6) Ajude o professor leia 5 notas e tire a media, caso o aluno tirou >=6 aprovado, senão reprovado...  
        retorne a media e diga se ele está aprovado ou reprovado. Exemplo de retorno A media é 9 o aluno está APROVADO.*/

        [HttpGet("Ex6")]
        public string QuestaoNumero6(decimal n1, decimal n2, decimal n3, decimal n4, decimal n5)
        {
            string retorno = "";

            decimal medianota = (n1 + n2 + n3 + n4 + n5) / 5;
            if (medianota >= 6)
            {
                retorno = "A média é " + medianota+ "o aluno está aprovado";
            }
            else
            {
                retorno = "A média é " + medianota + "o aluno está reprovado";
            }

            return retorno;
        }
    }
}
