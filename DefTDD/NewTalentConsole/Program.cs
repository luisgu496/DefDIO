using NewTalentConsole;

Calculadora c = new Calculadora();

int num1 = 20;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {c.somar(num1, num2)}");
Console.WriteLine($"{num1} - {num2} = {c.subtrair(num1, num2)}");
Console.WriteLine($"{num1} * {num2} = {c.multiplicar(num1, num2)}");
Console.WriteLine($"{num1} / {num2} = {c.dividir (num1, num2)}");