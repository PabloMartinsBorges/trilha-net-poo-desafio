using System.ComponentModel.Design;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


 Nokia nokia = new Nokia("123", "Flip", "123456789012345", 100);
 Iphone iphone = new Iphone("321", "X11", "098765432109876", 120);

Console.WriteLine("Ligando com os smartphones");
 nokia.Ligar(); 
 iphone.Ligar();

Console.WriteLine("\nRecebendo ligação com os smartphones");
nokia.ReceberLigacao();
 iphone.ReceberLigacao();

Console.WriteLine("\nInstalando Whatsapp com os smartphones");
 nokia.InstalarAplicativo("Whatsapp");
 iphone.InstalarAplicativo("Whatsapp");
