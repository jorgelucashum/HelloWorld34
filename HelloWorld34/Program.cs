using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld34
{
    // Exceções: 
    // É qualquer condição de erro ou comportamento inesperado encontrado por um programa em execução. (no .NET exceção é um objeto herdado da classe 'System.Exception').
    // Quando lançada, uma exceção é propagada na pilha de chamadas de métodos em execução, até que seja capturada (tratada) ou o programa seja encerrado.
    // O modelo de tratamento de exceções permite que erros sejam tratados de forma consistente e flexível, usando boas práticas.
    // - Delega a lógica do erro para a classe / método responsável por conhecer as regras que podem ocasionar o erro.
    // - Trata de forma organizada (inclusive hierárquica) exceções de tipos diferentes.
    // - A exceção pode carregar dados quaisquer.
    class Program
    {
        // Estrutura try-catch:
        // Bloco 'try { }': Contém o código que representa a execução normal do trecho do código que pode acarretar em uma exceção.

        // Bloco 'catch(Exception e) { }': Contém o codigo a ser executado caso uma exceção ocorra, deve ser especificado o tipo da exceção a ser tratada (upcasting é permitido).
        static void Main(string[] args)   
        {

        }
    }
}