using RefactoringWithGenerics.Entities;
using RefactoringWithGenerics.Repository;
using System;

class Program
{
    static void Main(string[] args)
    {
        AsientoRepository asientoRepository = new AsientoRepository();

        // Crear y agregar asientos
        Asiento nuevoAsiento = new Asiento { AsientoId = 1, BusId = 101, NumeroPiso = 1, NumeroAsiento = 10, FechaCreacion = DateTime.Now };
        Asiento nuevoAsiento2 = new Asiento { AsientoId = 2, BusId = 101, NumeroPiso = 1, NumeroAsiento = 10, FechaCreacion = DateTime.Now };
        asientoRepository.Agregar(nuevoAsiento);
        asientoRepository.Agregar(nuevoAsiento2);

        // Obtener todos los asientos
        var asientos = asientoRepository.TraerTodos();
        Console.WriteLine($"Total de asientos: {asientos.Count}");

        //Imrpime asiento 1 y 2
        Console.WriteLine(asientoRepository.ObtenerPorId(1));
        Console.WriteLine(asientoRepository.ObtenerPorId(2));

        // Remover un asiento
        asientoRepository.Remover(nuevoAsiento);
        Console.WriteLine($"\n\n\nTotal de asientos después de remover: {asientoRepository.TraerTodos().Count}\n\n\n");

        // Imprimir el asiento restante
        var asientoRestante = asientoRepository.ObtenerPorId(2);
        Console.WriteLine(asientoRestante);
    }
}
