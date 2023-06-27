// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("\n Valor de a: "+a);
Console.WriteLine("\n Valor de b: "+b);

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