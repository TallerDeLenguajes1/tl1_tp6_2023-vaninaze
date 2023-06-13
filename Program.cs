// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;

int b;

a=10;

b=a;

Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

/* string? numStr;
int numFloat;
numStr = Console.ReadLine();
int digito;
string numInv="";

bool anda = int.TryParse(numStr,out numFloat);
if (anda)
{   
    Console.WriteLine("Numero: "+numFloat);
    numInv=null;
    while (numFloat != 0)
    {
        digito = numFloat%10;
        numFloat = numFloat/10;
        numInv = numInv + digito.ToString();
    }
    //string numlargo = "123";
    //string numinv = numlargo[2].ToString() + numlargo[1].ToString() + numlargo[0].ToString();

    Console.WriteLine(numInv);
}*/


//Punto 2
int op = 1;
int num1, num2, resultado;
while(op != 0){
    Console.WriteLine("--- MENU ---");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("Ingresar opcion: ");
    op = Console.Read();
    Console.WriteLine("Ingresar numero 1: ");

    num1 = Console.ReadLine();

    Console.WriteLine("Ingresar numero 2: ");

    num2 = Console.ReadLine();

    switch (op)
    {
        case 1:
            resultado = num1+num2;
            Console.WriteLine("Resultado: "+resultado);
            break;
        case 2:
            resultado = num1-num2;
            Console.WriteLine("Resultado: "+resultado);
            break;
        case 3:
            resultado = num1*num2;
            Console.WriteLine("Resultado: "+resultado);
            break;
        case 4:
            resultado = num1/num2;
            Console.WriteLine("Resultado: "+resultado);
            break;
    }
    Console.WriteLine("Desea realizar otro calculo? 1-SI 0-NO: ");
    op = Console.Read();
}