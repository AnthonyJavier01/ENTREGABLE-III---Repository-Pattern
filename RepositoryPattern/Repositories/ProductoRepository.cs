using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RepositoryPattern.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly List<Producto> _productos = new();

        public IEnumerable<Producto> GetAll()
        {
            return _productos;
        }

        public Producto? GetById(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Producto producto)
        {
            _productos.Add(producto);
        }

        public void Update(Producto producto)
        {
            var productoExistente = GetById(producto.Id);

            if (productoExistente is not null)
            {
                productoExistente.Nombre = producto.Nombre;
                productoExistente.Precio = producto.Precio;
            }
        }

        public void Delete(int id)
        {
            var producto = GetById(id);

            if (producto is not null)
            {
                _productos.Remove(producto);
            }
        }
    }
}
