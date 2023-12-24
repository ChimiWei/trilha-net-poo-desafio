namespace DesafioPOO.Models
{
    // (Implementado!) TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero,  modelo, imei, memoria)
        {

        }
        
        // (Implementado!) TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp, int tamanho)
        {
            if(tamanho > Memoria)
            {
                Console.WriteLine("Memória de Armazenamento do Nokia insuficiente.");
            } else 
            {
                Console.WriteLine($"Instalando aplicativo no Nokia Nº {Numero}...");
                Memoria = Memoria - tamanho;
                Console.WriteLine($"Memória de Armazenamento restante: {Memoria}");
            }
            
        }

    }
}