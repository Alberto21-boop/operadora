namespace operadora;

public class Program
{
    static void Main(string[] args)
    {
        //Uma operadora de telefonia cobra R$ 50,00 por um plano basico que dá direito a 100 minutos de telefone.
        //Cada minuto que excerder a franquia de 100 minutos custara R$ 2,00. Fazer um programa para ler a quantidade
        //de minutos que uma pessoa consumiu, dai mostrar o valor a der pago.

        double A, minutos, cobrar, franquia, plano;

        minutos = 100;
        franquia = 2.00;
        plano = 50.00;

        Console.Write("Digite por favor a quantidade de minutos: ");
        A = double.Parse(Console.ReadLine());

        if(A > minutos)
        {
            cobrar = (A - 100) * franquia;
            cobrar = cobrar + plano;
            Console.WriteLine("Valor a pagar é de " + cobrar.ToString("C"));
        }
        else if(A < minutos)
        {
            Console.WriteLine("Valor a pagar é de " + plano.ToString("C"));
        }

    }
}