using System;

//DESCRIÇÃO DA SEQUÊNCIA DE  FIBONACCI
/*
Cada novo número na sequência de Fibonacci é gerado pela soma dos dois números anteriores. 
Ao começar com 1 e 2, os primeiros 10 números serão:
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
*/

//DESCRIÇÃO DA APLICAÇÃO
/*A aplicação a seguir realiza a soma dos valores pares da sequência de Fibonacci. 
Sendo que o total não pode exceder o limite estipulado como parâmetro*/

static int SomaSequenciaFibonacci(int limiteSoma)
{
    int num1 = 1;
    int num2 = 1;
    bool validarSoma = true;
    int resultado = 0;

    while(validarSoma)
    {
        int soma = 0;
        soma = num1 + num2;
        num1 = num2;
        num2 = soma;

        if(soma % 2 == 0)
        {
            if(soma <= limiteSoma)
                resultado += soma;
            
            else
                validarSoma = false;
        }
    }

    return resultado;
}
Console.WriteLine(SomaSequenciaFibonacci(8)); //Deve retornar 10.
Console.WriteLine(SomaSequenciaFibonacci(10)); //Deve retornar 10.
Console.WriteLine(SomaSequenciaFibonacci(34)); //Deve retornar 44.
Console.WriteLine(SomaSequenciaFibonacci(60)); //Deve retornar 44.
Console.WriteLine(SomaSequenciaFibonacci(1000)); //Deve retornar 798.
Console.WriteLine(SomaSequenciaFibonacci(100000)); //Deve retornar 60696.
Console.WriteLine(SomaSequenciaFibonacci(4000000)); //Deve retornar 4613732.