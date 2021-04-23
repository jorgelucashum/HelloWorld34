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
        // Bloco 'finally { }': Contém o código a ser executado independente de ter ocorrido ou não uma exceção. (Exemplo comum: fechar um arquivo ou conexão de banco de dados ao final do processamento).
        static void Main(string[] args)
        {
            try // 'try' tentando executar o código
            {
                Console.WriteLine("Digite 2 números para realizar uma divisão:");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            // 'catch()' é executado caso ocorra alguma exceção, assim "capturando" ela.
            // É preferivel sempre especificar o máximo possível o tipo da exceção dentro do parâmetro 'catch()', sendo '(Exception)' o tipo mais genérico, servindo pra qualquer exceção.
            catch (DivideByZeroException e) // Cógido executado caso ocorra uma divisão por zero (exceção). 
            {
                Console.WriteLine("Não é possível realizar uma divisão por zero.");
            }
            catch(FormatException e) // Cógido executado caso a entrada dos valrores estejam fora do formato aceitado (exceção). 
            {
                Console.WriteLine("Erro no formato. " + e.Message); // '.Message' retorna a própria mensagem padrão criada pela classe da exceção utilizada.
            }
            finally // Executando de forma independente de ter ou não ocorrida uma exceção.
            {
                Console.WriteLine("\nO código executado com exito!");
            }
        }
    }
}