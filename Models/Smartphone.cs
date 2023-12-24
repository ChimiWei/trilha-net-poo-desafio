namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // (Implementado!) TODO: Implementar as propriedades faltantes de acordo com o diagrama 
        private string _modelo { get; set; }
        private string _imei { get; set; }
        private int _memoria { get; set; }

        public string Modelo 
        { 
            get => _modelo ; 
            
            set => _modelo = value; 
        }
        public string IMEI 
        { 
            get => _imei ; 
            
            set => _imei = value; 
        }
        public int Memoria 
        { 
            get => _memoria; 

            set 
            {
                if(Memoria < value)
                {
                    throw new Exception("Operação inválida.");
                }
                _memoria = value; 
            } 
        } 

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
            // (Implementado!) TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar(string numero)
        {
            Console.WriteLine($"Ligando para {numero}");
        }

        public void ReceberLigacao(string numero)
        {
            Console.WriteLine($"Recebendo ligação de {numero}...");
        }

        public abstract void InstalarAplicativo(string nomeApp, int tamanho);
    }
}