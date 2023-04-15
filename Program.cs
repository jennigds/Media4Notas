Console.Clear();
double nota1, nota2, nota3, nota4, media;

Console.WriteLine("-- Média de quatro notas --");

Console.Write("Digite a nota #1...: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota #2...: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota #3...: ");
nota3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a nota #4...: ");
nota4 = Convert.ToDouble(Console.ReadLine());

bool todasAsNotasSaoValidas =  nota1 >= 0 && nota1 <= 10
                            && nota2 >= 0 && nota2 <= 10
                            && nota3 >= 0 && nota3 <= 10
                            && nota4 >= 0 && nota4 <= 10;

if (!todasAsNotasSaoValidas)
{
    Console.WriteLine("Digite somente notas entre 0 e 10;");
}
else
{

media = (nota1 + nota2+ nota3 + nota4) / 4;
string Resultado;

if (media < 5)
{
    Resultado = "Reprovado";
}
else if (media > 6)
    {
        Resultado = "Aprovado";
    }
    else
    {
        Resultado = "Em Recuperação";
    }






Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {Resultado:N1}.");

}



 // jennifer e gustavo fizeram juntos!!