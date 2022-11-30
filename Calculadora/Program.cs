using Calculadora;

CalculadoraControle calculadora = new CalculadoraControle();

Console.WriteLine(calculadora.Somar.Calcular(2, 1));
Console.WriteLine(calculadora.Subtrair.Calcular(2, 1));
Console.WriteLine(calculadora.Multiplicar.Calcular(2, 1));
Console.WriteLine(calculadora.Dividir.Calcular(2, 1));
