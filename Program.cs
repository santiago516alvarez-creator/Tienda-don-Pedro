// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using Company.ClassLibrary1

using var context = new AppDbContext();
var servicio = new ProductoServices(context);

servicio.agregar("Mouse", 13800)
servicio.agregar("Teclado", 98000)
servicio.agregar("Auris",34000)

console.WriteLine("-----------------Lista de Productos-----------------")

foreach (var p in servicio.ObtenerTodos())

Console.WriteLine($"{p.Id} - {p.Nombre} - {p.Precio}")