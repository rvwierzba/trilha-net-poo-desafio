
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        override public void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando o App: {nomeApp} em seu IPHONE... OK!");
        }
    }
}