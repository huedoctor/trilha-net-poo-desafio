using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("1234567", "Modelo 1", "1111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone("09809", "Modelo 2", "22222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");