// Día 6: arrays (tamaño fijo) vs List<T> (tamaño dinámico)

// Array: horas de estudio de la semana
int[] horas = { 2, 1, 2, 0, 2 };
int total = 0;
foreach (int h in horas) total += h;
Console.WriteLine($"Total semana: {total} h, promedio: {(double)total / horas.Length:F1} h");

// Ordenar y buscar
Array.Sort(horas);
Console.WriteLine($"Ordenado: {string.Join(", ", horas)}");
Console.WriteLine($"¿Hubo un día en 0? {Array.IndexOf(horas, 0) >= 0}");

// List<T>: pendientes que cambian
List<string> pendientes = new List<string> { "Dia05", "Dia06", "Fortinet NSE 1" };
pendientes.Add("Formatear PC");
pendientes.Remove("Dia05");
Console.WriteLine($"Quedan {pendientes.Count} pendientes:");
for (int i = 0; i < pendientes.Count; i++)
{
    Console.WriteLine($"{i + 1}. {pendientes[i]}");
}