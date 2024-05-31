using System;

static int MaiorPalindromo(int qntAlgarismos)
{
    double contador = Math.Pow(10, qntAlgarismos) -1;
    int maiorPalindromo = 0;
    
    for(int i = 1; i <= contador; i++)
    {
        for(int j = 1; j <= contador; j++)
        {
            int resultado = i * j;
            string texto1 = resultado.ToString();
            string texto2 = new string(texto1.Reverse().ToArray());

            if (texto1 == texto2 && resultado > maiorPalindromo)
                maiorPalindromo = resultado;
        }
    }
    return maiorPalindromo;
}

Console.WriteLine(MaiorPalindromo(3)); //Deve retornar 9009