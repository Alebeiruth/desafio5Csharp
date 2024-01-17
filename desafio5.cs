
string? number;
string validaEntrada = "";
bool entradaValida = false;
int validoNumero = 0;

Console.WriteLine("Entre com valor entre 5 e 10:");
do{
    number = Console.ReadLine();
    if (number != null)
    {
        validaEntrada = number;
    }

    entradaValida = int.TryParse(validaEntrada, out validoNumero);
    if (entradaValida == true)
    {
        if (validoNumero <= 5 || validoNumero >= 10)
        {
            entradaValida = false;
            Console.WriteLine($"You entered {validoNumero}. Please enter a number between 5 and 10.");
        }

    }
    else
    {
    Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
    }while(entradaValida == false);

    Console.WriteLine($"Your input value ({validoNumero}) has been accepted.");
    number = Console.ReadLine();
