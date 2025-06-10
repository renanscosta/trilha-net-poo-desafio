using DesafioPOO.Models;

var nokia = new Nokia("11999999999", "Nokia 6.1", "1234567890", 64);
var iphone = new Iphone("11988888888", "iPhone 12", "0987654321", 128);
nokia.Ligar();
iphone.Ligar();
nokia.ReceberLigacao();
iphone.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("Telegram");
Console.WriteLine("Aplicativos instalados com sucesso!");
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();