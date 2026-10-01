using RepositoryPattern.Models;
using RepositoryPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Services
{
    public class ProductoService
    {
        private readonly IProductoRepository _repository;

        public ProductoService(IProductoRepository repository)
        {
            _repository = repository;
        }

        public void ListarProductos()
        {
            var productos = _repository.GetAll();

            if (!productos.Any())
            {
                Console.WriteLine("No existen productos registrados.");
                return;
            }

            foreach (var producto in productos)
            {
                Console.WriteLine(
                $"Id: {producto.Id} | Nombre: {producto.Nombre} | Precio: S/. {producto.Precio}");
            }
        }

        public void BuscarPorId(int id)
        {
            var producto = _repository.GetById(id);

            if (producto is null)
            {
                Console.WriteLine("Producto no encontrado.");
                return;
            }

            Console.WriteLine(
            $"Id: {producto.Id} | Nombre: {producto.Nombre} | Precio: S/. {producto.Precio}");
        }

        public void AgregarProducto()
        {
            Console.Write("Código: ");
            int id = int.Parse(Console.ReadLine()!);

            if (_repository.GetById(id) is not null)
            {
                Console.WriteLine("El código ya existe.");
                return;
            }

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine()!;

            Console.Write("Precio: ");
            decimal precio = decimal.Parse(Console.ReadLine()!);

            var producto = new Producto
            {
                Id = id,
                Nombre = nombre,
                Precio = precio
            };

            _repository.Add(producto);

            Console.WriteLine("Producto registrado correctamente.");
        }

        public void ActualizarProducto()
        {
            Console.Write("Ingrese código del producto: ");
            int id = int.Parse(Console.ReadLine()!);

            var producto = _repository.GetById(id);

            if (producto is null)
            {
                Console.WriteLine("Producto no encontrado.");
                return;
            }

            Console.Write("Nuevo nombre: ");
            producto.Nombre = Console.ReadLine()!;

            Console.Write("Nuevo precio: ");
            producto.Precio = decimal.Parse(Console.ReadLine()!);

            _repository.Update(producto);

            Console.WriteLine("Producto actualizado correctamente.");
        }

        public void EliminarProducto()
        {
            Console.Write("Ingrese código del producto: ");
            int id = int.Parse(Console.ReadLine()!);

            var producto = _repository.GetById(id);

            if (producto is null)
            {
                Console.WriteLine("Producto no encontrado.");
                return;
            }

            _repository.Delete(id);

            Console.WriteLine("Producto eliminado correctamente.");
        }
    }
}
