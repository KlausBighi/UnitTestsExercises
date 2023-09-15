using Calculator.Services;

CalculatorImp c = new CalculatorImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {c.Sum(num1, num2)}");

//-------------------------------------------------------------

StringValidation s = new StringValidation();

string text = "Ola";

Console.WriteLine(text);