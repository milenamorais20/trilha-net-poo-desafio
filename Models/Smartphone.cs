namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ExibirNumero(){
            Console.WriteLine("Numero: " + Numero);
        }

        public void ExibirModelo(){
            Console.WriteLine("Modelo: " + Modelo);
        }

        public void ExibirIMEI(){
            Console.WriteLine("IMEI: " + IMEI);
        }

        public void ExibirMemoria(){
            Console.WriteLine("Memoria: " + Memoria);
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}