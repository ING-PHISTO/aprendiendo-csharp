int minutosCorriendo = 25;
int diasEntrenadosSemana = 3;

if (minutosCorriendo >= 40 && diasEntrenadosSemana >= 4)
{
    Console.WriteLine("Nivel: listo para Hyrox 🏆");
}
else if (minutosCorriendo >= 20 || diasEntrenadosSemana >= 3)
{
    Console.WriteLine("Nivel: intermedio, vas bien 💪");
}
else
{
    Console.WriteLine("Nivel: principiante, ¡a darle!");
}