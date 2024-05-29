using System;

//Calcular a soma de todos os múltiplos de 3 ou 5, menores que o parâmetro "numero".

static int SomaMultiplosDe3Ou5(int numero)
{
    int resultado = 0;

    for(int i = 1; i < numero; i++)
    {
        if(i % 3 == 0 || i % 5 == 0)
        {
            resultado += i;
        }
    }

    return resultado;
}

Console.WriteLine($"Total {SomaMultiplosDe3Ou5(10)}"); // Deve retornar 23
Console.WriteLine($"Total {SomaMultiplosDe3Ou5(49)}"); // Deve retornar 543
Console.WriteLine($"Total {SomaMultiplosDe3Ou5(1000)}"); // Deve retornar 233168
Console.WriteLine($"Total {SomaMultiplosDe3Ou5(8456)}"); // Deve retornar 16687353
Console.WriteLine($"Total {SomaMultiplosDe3Ou5(19564)}"); // Deve retornar 89301183