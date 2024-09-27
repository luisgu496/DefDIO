using Def_CelularPOO.Models;

Smartphone nokia = new Nokia("12345678", "G60", "861536030196001", "128");
Smartphone iphone = new Iphone("87654321", "12", "872548031069100", "256");

nokia.Numero = "21 1111-3333";
iphone.Numero = "22 4444-5555";

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("FaceBook");

Console.WriteLine();
