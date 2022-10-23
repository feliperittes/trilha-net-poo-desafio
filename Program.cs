using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(number: "8486168", model: "NK046", imei: "22222222", memory: 128);
nokia.Call();
nokia.InstallApp("Instagram");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(number: "35217858", model: "13 Pro Max", imei: "3333333333", memory: 256);
iphone.ReceiveCall();
iphone.InstallApp("Telegram");