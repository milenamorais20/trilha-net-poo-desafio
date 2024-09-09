using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("73 998267866","Iphone","Imei123", 32);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
iphone.ExibirIMEI();
iphone.ExibirMemoria();
iphone.ExibirModelo();
iphone.ExibirNumero();

Console.WriteLine("\n");

Nokia nokia = new Nokia("71999603264", "Nokia", "Imei456", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.ExibirIMEI();
nokia.ExibirMemoria();
nokia.ExibirModelo();
nokia.ExibirNumero();