string? lerResultado;
string valorDeEntrada = "";
bool validarNumero = false;
int numValue = 0;

Console.WriteLine("Enter an integer value between 5 and 10");//faz a pergunta pro usuario antes do bloco

do
{
    lerResultado = Console.ReadLine();//ler o valor digitado pelo usuario
    if(lerResultado != null)//verifica se é diferente de nulo
    {
        valorDeEntrada = lerResultado;//equivale variavel vazia antes para agora valor digitado
    }

    validarNumero = int.TryParse(valorDeEntrada, out numValue);//variavel tem valor de int, e sua saida é int

    if (validarNumero == true)// caso seja verdadeiro entra no codigo
    {
        if (numValue <= 5 || numValue >= 10) // se numValue for menor ou igual a 5 ou 10 é FALSO
        {
            validarNumero = false; //validaNumero euqivale a Falso agora
            Console.WriteLine($"seu numero {numValue} continua fora dos numero entre 5 e 10");//mnostrando essa msg
        }
    }
    else//caso não entre na condição anterior ele mostra essa msg
    {
        Console.WriteLine("Seu numero está incorreto, tente mais uma vez");
    }
}while(validarNumero == false);//loop acontece se a variavel for igual a falso
Console.WriteLine($"Parabens seu numero {numValue} foi aceito");//sendo verdadeiro ela sai do loop aparecendo essa msg
