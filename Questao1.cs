public class Questao1
{
    static char Conceito(int nota)
    {
        if(nota < 5)
        {
            return 'D';
        }else if(nota < 7)
        {
            return 'C';
        }else if(nota < 9)
        {
            return 'B';
        }
        else
        {
            return 'A';
        }
    }

    public static void rodar()
    {
        char conceito;

        Console.WriteLine("Insira a nota do aluno(0 a 10): ");

        int nota = int.Parse(Console.ReadLine());

        conceito = Conceito(nota);

        Console.WriteLine($"O Aluno teve conceito: {conceito}");
    }
}