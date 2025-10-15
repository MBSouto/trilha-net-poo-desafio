using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "12345", modelo: "np02", imei: "00001236", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "67891", modelo: "np05", imei: "00001789", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
