Console.WriteLine("Ingrese el monto del consumo: ");
double consumo = Convert.ToDouble(Console.ReadLine());

double descuento = 0;
double impuesto = 0.18 * consumo;
double subtotal = consumo + impuesto;

 if (consumo <= 100)
  {
         descuento = 0.1 * consumo;
  }
 else
  {
         descuento = 0.2 * consumo;
  }

double importeTotal = subtotal - descuento;

Console.WriteLine("El descuento es de: S/ " + descuento+("0.00"));
Console.WriteLine("El impuesto es: S/ " + impuesto +("0.00"));
Console.WriteLine("El subtotal es: S/ " + subtotal + ("0.00"));
Console.WriteLine("Su importe a pagar: S/ " + importeTotal + ("0.00"));

