namespace DesafioPOO.Models
{
    // (Implementado!) TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero,  modelo, imei, memoria)
        {

        }
        
    // (Implementado!) TODO: Sobrescrever o método "InstalarAplicativo"    
        public override void InstalarAplicativo(string nomeApp, int tamanho)
        {
            if(tamanho > Memoria)
            {
                Console.WriteLine("Memória de Armazenamento do iPhone insuficiente.");
            } else 
            {
                Console.WriteLine($"Instalando aplicativo no iPhone Nº {Numero}...");
            }
            Memoria = Memoria - tamanho;
        }
    }
}