using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 01", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Uber");

System.Console.WriteLine();

System.Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "345678", modelo: "Modelo 02", imei: "22222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");


