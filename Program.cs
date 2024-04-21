using DesafioPOO.Models;

Smartphone nokia = new Nokia("+5511711760148", "Nokia C20", "352391982894641", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone("+5511483577630", "14", "443393287861821", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");