using RepositoryPattern.Repositories;
using RepositoryPattern.Services;

IProductoRepository repository = new ProductoRepository();

ProductoService productoService = new ProductoService(repository);

bool salir = false;

while (!salir)
{
    Console.WriteLine();
    Console.WriteLine("=================================");
    Console.WriteLine(" SISTEMA DE PRODUCTOS");
    Console.WriteLine("=================================");
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Listar productos");
    Console.WriteLine("3. Buscar producto por código");
    Console.WriteLine("4. Actualizar producto");
    Console.WriteLine("5. Eliminar producto");
    Console.WriteLine("6. Salir");
    Console.WriteLine("=================================");

    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine()!;

    Console.WriteLine();

    switch (opcion)
    {
        case "1":
            productoService.AgregarProducto();
            break;

        case "2":
            productoService.ListarProductos();
            break;

        case "3":
            Console.Write("Ingrese código: ");
            int idBuscar = int.Parse(Console.ReadLine()!);

            productoService.BuscarPorId(idBuscar);
            break;

        case "4":
            productoService.ActualizarProducto();
            break;

        case "5":
            productoService.EliminarProducto();
            break;

        case "6":
            salir = true;
            Console.WriteLine("Programa finalizado.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
}