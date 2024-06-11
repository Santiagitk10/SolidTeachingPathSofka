// See https://aka.ms/new-console-template for more information
using SolidTeachingPathSofka;

//Principio Responsabilidad única
var circulo = new Circulo(10);
Console.WriteLine($"Area círculo: {circulo.CalcularArea()}");

var reactangulo = new Rectangulo(5, 7);
Console.WriteLine($"Area rectángulo: {reactangulo.CalcularArea()}");

//Principio Open/Closed
var descuentoPorcentaje = new DescuentoPorcentaje(15);
var descuentoMontoFijo = new DescuentoMontoFijo(200);

Pedido.GenerarFactura(20000, descuentoPorcentaje);
Pedido.GenerarFactura(20000, descuentoMontoFijo);

//Principio Substitución de Liskov
Circulo circulo2 = new Circulo(15.25);
Circulo circulo3 = new Circulo(7.8);
Rectangulo rectangulo2 = new Rectangulo(5, 12.8);

Forma[] formas = { circulo2, circulo3, reactangulo };

Console.WriteLine($"El area total es: {CalculadoraArea.CalcularAreaTotal(formas)}");

//Principio Segregación de Interfaces
Television television = new Television();
Radio radio = new Radio();

television.Encender();
television.AjustarVolumen(25);

radio.Apagar();
radio.AjustarVolumen(-15);

Console.WriteLine($"Televisor Encendido: {television.EstaEncendido}");
Console.WriteLine($"Volumen Televisor: {television.Volumen}");

Console.WriteLine($"Radio Encendido: {radio.EstaEncendido}");
Console.WriteLine($"Volumen Radio: {radio.Volumen}");

//Principio Inversión de Dependencia

ServicioSMS servicioSMS = new ServicioSMS();
Notificador notificadorTexto = new Notificador(servicioSMS);
notificadorTexto.EnviarNotificacion();

ServicioEmail servicioEmail = new ServicioEmail();
Notificador notificadorEmail = new Notificador(servicioEmail);
notificadorEmail.EnviarNotificacion();

Console.ReadLine();