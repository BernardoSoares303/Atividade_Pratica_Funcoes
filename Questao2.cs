public class Questao2
{
    static bool PositivoOuNegativo(int i)
    {
        if(i >= 0)
        {
            return true;
        }else return false;
    }

    public static void Rodar()
    {
        Console.Write("insira um numero positivo ou negtivo: ");

        int num = int.Parse(Console.ReadLine());

        if (PositivoOuNegativo(num))
        {
            Console.WriteLine("O numero Digitado é positivo!");
        }else Console.WriteLine("O numero Digitado é negativo!");
    }
}