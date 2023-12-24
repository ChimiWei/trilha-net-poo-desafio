using DesafioPOO.Models;

// (Implementado!) TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111231311", memoria: 64);
Smartphone iphone = new Iphone(numero: "7891011", modelo: "Modelo 2", imei: "32222221222", memoria: 128);

nokia.Ligar(iphone.Numero);
nokia.InstalarAplicativo("Whatsapp", 60);
nokia.InstalarAplicativo("TelegramLite", 10);

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");

iphone.ReceberLigacao(nokia.Numero);
iphone.InstalarAplicativo("Telegram", 120);
iphone.InstalarAplicativo("Whatsapp", 60);

