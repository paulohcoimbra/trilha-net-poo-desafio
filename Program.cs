using DesafioPOO.Models;

Console.WriteLine("Nokia...");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo A", imei: "s29kdjpp", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Iphone...");
Smartphone iphone = new Nokia(numero: "123456", modelo: "X Pro", imei: "k1laod09", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
