// ejercicio 1  
/*
Console.WriteLine("¿cual es su nombre?");
string nombre = Console.ReadLine();
Console.WriteLine("confirme su email... ");
string email = Console.ReadLine();
Console.WriteLine("tiene usted un cupon?");
string cupon = Console.ReadLine();

double precioNeto = 100.00;

double descuento = 0.50;

double PrecioFinal = precioNeto - (precioNeto * descuento);




if (cupon == "si")
{
    Console.WriteLine("con cupon de descuento el precio le queda en : " + PrecioFinal);

}

else { Console.WriteLine("el precio del producto es de " + precioNeto); }

*/


//ejercicio 2 
Console.WriteLine("Elija un lenguaje de programacion de los siguientes indicando con A, B o C ");
Console.WriteLine("a : javascript");
Console.WriteLine("b : python");
Console.WriteLine("c : c#");


string opcionElegida = Console.ReadLine();


 switch(opcionElegida)
{
    case "a": Console.WriteLine("el hola mundo en javascrip se escribe asi : console.log(hola mundo)");
        break;
        case "b": Console.WriteLine("el hola mundo en python se escribe asi : print(hola mundo)");   
        break; 
        case "c": Console.WriteLine("el hola mundo en c# se escribe asi : console.writeline(hola mundo)");
         break;

        default: Console.WriteLine("lenguaje no elegido");
            break;
}


