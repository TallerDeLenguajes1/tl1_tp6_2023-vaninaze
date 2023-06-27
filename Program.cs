// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("\n Valor de a: "+a);
Console.WriteLine("\n Valor de b: "+b);
*/

//invertir un num
/*Console.WriteLine("\n Ingrese un numero: ");
string? numStr = Console.ReadLine();
int num, digito;
string numInv = "";

if(int.TryParse(numStr,out num)){ //Devuelve un bool
    if(num>=10){
        Console.WriteLine("\n Numero: "+num);
        while(num != 0){
            digito = num%10; //ultimo digito
            num = num/10;
            numInv = numInv + digito.ToString();
        }
        Console.WriteLine("\n Numero invertido: "+numInv);
    } else {
        Console.WriteLine("\n El numero tiene 1 digito, no se puede invertir");
    }
} else {
    Console.WriteLine("\n Error! No ingreso un num");
}
*/

string? cad, cad2;
Console.WriteLine("Ingresar una cadena: ");
cad = Console.ReadLine();

Console.WriteLine("Longitud: "+cad.Length);
Console.WriteLine("Ingresar otra cadena: ");
cad2 = Console.ReadLine();

Console.WriteLine("Cadenas concatenadas: "+String.Concat(cad, cad2));
string subcad = cad.Substring(2,3);
Console.WriteLine("Subcadena de la cadena: "+subcad);

foreach (char car in cad)
{
    Console.WriteLine("Elemento: "+car);
}
if(cad.Contains("nin", System.StringComparison.CurrentCultureIgnoreCase)){
    Console.WriteLine("La palabra 'nin' aparece en la cadena");
} else {
    Console.WriteLine("La palabra 'nin' NO aparece en la cadena");
}
cad = cad.ToLower();
Console.WriteLine("Cadena en minuscula: "+cad);
cad = cad.ToUpper();
Console.WriteLine("Cadena en Mayuscula: "+cad);

Console.WriteLine("Ingresar cadena con delimitadores '-'");
cad2 = Console.ReadLine();
char delimitador = '=';
string[] arre = cad2.Split(delimitador);

foreach (var comp in arre)
{
    Console.WriteLine("Elemento: "+comp);
}

Console.WriteLine("Ingresar cadena con delimitadores +,-,* o /");
cad2 = Console.ReadLine();
if(cad2.Contains("+")){
    delimitador = '+';
} else if(cad2.Contains("-")){
    delimitador = '-';
} else if(cad2.Contains("*")){
    delimitador = '*';
} else {
    delimitador = '/';
}
string[] arreNumString = cad2.Split(delimitador);
int[] arreNum = new int[8];
int i=0, num;
foreach (string item in arreNumString)
{
    if(int.TryParse(item, out num)){
        arreNum[i] = num;
        i++;
    }
}
int longArre = arreNum.Length;
int resultado=0;
i = 0;
while(i < longArre){
    switch (delimitador)
    {
        case '+':
            resultado = resultado + arreNum[i];
            break;
        case '-':
            resultado = resultado - arreNum[i];
            break;
        case '*':
            if(i == 0){
                resultado = 1;
            }
            resultado = resultado * arreNum[i];
            break;
        case '/':
            resultado = resultado / arreNum[i];
            break;
    }
    i++;
}
Console.WriteLine("Resultado: "+resultado);