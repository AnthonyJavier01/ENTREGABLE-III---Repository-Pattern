# Repository Pattern - Gestión de Productos en Memoria

## Descripción

Este proyecto es una aplicación de consola desarrollada en C# que implementa el patrón de diseño Repository Pattern para la gestión de productos.

El repositorio almacena los datos en memoria utilizando una colección List<Producto>, permitiendo realizar operaciones CRUD (Crear, Leer, Actualizar y Eliminar) sin utilizar una base de datos.

El objetivo principal es desacoplar el acceso a los datos de la lógica de negocio mediante el uso de una interfaz de repositorio.

---

# Objetivos del Entregable

- Aplicar Repository Pattern.
- Implementar un repositorio en memoria.
- Separar responsabilidades mediante capas.
- Realizar operaciones CRUD desde consola.
- Facilitar el mantenimiento y escalabilidad del proyecto.

---

# Funcionalidades

La aplicación permite:

1. Registrar productos.
2. Listar todos los productos.
3. Buscar un producto por código.
4. Actualizar un producto existente.
5. Eliminar un producto.
6. Salir de la aplicación.

---

# Estructura del Proyecto

```text
RepositoryPatternProductos
│
├── Models
│   └── Producto.cs
│
├── Repositories
│   ├── IProductoRepository.cs
│   └── ProductoRepository.cs
│
├── Services
│   └── ProductoService.cs
│
├── Program.cs
│
└── README.md
```

---

# Explicación de las Capas

## Models

Contiene las entidades del sistema.

### Producto.cs

Representa un producto con sus propiedades:

- Id
- Nombre
- Precio

---

## Repositories

Contiene el acceso a datos.

### IProductoRepository

Define el contrato que debe cumplir cualquier repositorio de productos.

Métodos:

```csharp
GetAll()
GetById()
Add()
Update()
Delete()
```

### ProductoRepository

Implementa la interfaz IProductoRepository utilizando una lista en memoria.

```csharp
private readonly List<Producto> _productos = new();
```

---

## Services

Contiene la lógica de negocio.

### ProductoService

Se comunica con el repositorio para:

- Registrar productos.
- Buscar productos.
- Actualizar productos.
- Eliminar productos.
- Mostrar información en consola.

---

## Program

Punto de entrada de la aplicación.

Contiene:

- Menú principal.
- Captura de opciones.
- Invocación de servicios.

---

# ¿Qué es el Repository Pattern?

El Repository Pattern es un patrón de diseño que encapsula la lógica de acceso a datos.

Permite que la aplicación trabaje con interfaces en lugar de depender directamente de una fuente de datos específica.

---

## Antes del Repository Pattern

La lógica de negocio accede directamente a los datos.

```csharp
List<Producto> productos = new();
```

Problemas:

- Alto acoplamiento.
- Difícil mantenimiento.
- Difícil realizar pruebas unitarias.
- Cambio de tecnología costoso.

---

## Después del Repository Pattern

La lógica de negocio depende de una abstracción.

```csharp
IProductoRepository repository;
```

Beneficios:

- Bajo acoplamiento.
- Mayor mantenibilidad.
- Código más limpio.
- Fácil migración a SQL Server, Entity Framework o APIs.
- Facilita pruebas unitarias.

---

# Flujo de Funcionamiento

### Agregar Producto

El usuario ingresa:

```text
Código
Nombre
Precio
```

El sistema valida que el código no exista y registra el producto.

---

### Listar Productos

Muestra todos los productos almacenados en memoria.

Ejemplo:

```text
Id: 1 | Nombre: Laptop | Precio: S/. 3500
Id: 2 | Nombre: Mouse | Precio: S/. 80
```

---

### Buscar Producto

Permite buscar un producto por código.

Ejemplo:

```text
Ingrese código: 1
```

Resultado:

```text
Id: 1 | Nombre: Laptop | Precio: S/. 3500
```

---

### Actualizar Producto

Permite modificar:

- Nombre
- Precio

de un producto existente.

---

### Eliminar Producto

Permite eliminar un producto utilizando su código.

---

# Menú Principal

```text
=================================
      SISTEMA DE PRODUCTOS
=================================
1. Agregar producto
2. Listar productos
3. Buscar producto por código
4. Actualizar producto
5. Eliminar producto
6. Salir
=================================
Seleccione una opción:
```

---

# Ejemplo de Ejecución

```text
Seleccione una opción: 1

Código: 1
Nombre: Laptop
Precio: 3500

Producto registrado correctamente.
```

```text
Seleccione una opción: 2

Id: 1 | Nombre: Laptop | Precio: S/. 3500
```

```text
Seleccione una opción: 3

Ingrese código: 1

Id: 1 | Nombre: Laptop | Precio: S/. 3500
```

---

# Tecnologías Utilizadas

- NET 10
- C#
- Repository Pattern
- Programación Orientada a Objetos (POO)
- Console Application

---

# Principios Aplicados

### Encapsulamiento

Cada clase tiene una responsabilidad específica.

### Abstracción

El repositorio es consumido mediante interfaces.

### Separación de Responsabilidades

- Modelos
- Repositorios
- Servicios
- Presentación

### Bajo Acoplamiento

La lógica de negocio no depende de la implementación concreta del repositorio.

---

# Resultado Esperado

Al ejecutar la aplicación el usuario podrá:

✅ Registrar productos.

✅ Listar productos.

✅ Buscar productos por código.

✅ Actualizar productos.

✅ Eliminar productos.

✅ Gestionar información sin necesidad de una base de datos.

✅ Aplicar correctamente Repository Pattern.

---

# Pasos para Ejecutar el Proyecto

## 1. Abrir una terminal

Ubicarse en la carpeta raíz del proyecto.

Ejemplo:

```bash
cd RepositoryPatternProductos
```

---

## 2. Restaurar dependencias

```bash
dotnet restore
```

---

## 3. Compilar el proyecto

```bash
dotnet build
```

Debe mostrarse un mensaje similar a:

```text
Build succeeded.
0 Warning(s)
0 Error(s)
```

---

## 4. Ejecutar la aplicación

```bash
dotnet run
```

---

## 5. Utilizar el menú

Seleccionar una opción:

```text
1. Agregar producto
2. Listar productos
3. Buscar producto por código
4. Actualizar producto
5. Eliminar producto
6. Salir
```

---

## 6. Finalizar la aplicación

Seleccionar:

```text
6
```

Resultado:

```text
Programa finalizado.
```

---
