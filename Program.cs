using DesafioPOO.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // TODO: Realizar os testes com as classes Nokia e Iphone
        Iphone smt1 = new Iphone("8546565656", "Iphone 14", "8888888888888888888888888888", 1024);
        smt1.Ligar();
        smt1.ReceberLigacao();
        smt1.InstalarAplicativo("AngryBird");

        Nokia smt2 = new Nokia("9966969696696", "Nokia C03", "999999999999999999999999", 128);
        smt2.Ligar();
        smt2.ReceberLigacao();
        smt2.InstalarAplicativo("X");
    }
}