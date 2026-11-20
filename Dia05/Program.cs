// Día 5: bucles for, while, do-while y foreach

// for: tabla del 7
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"7 x {i} = {7 * i}");
}

// while: contar hasta llegar a 2 L de agua (8 vasos de 250 ml)
int vasos = 0;
while (vasos < 8)
{
    vasos++;
    Console.WriteLine($"Vaso {vasos}: {vasos * 250} ml");
}

// do-while: se ejecuta al menos una vez
int intento = 0;
do
{
    intento++;
    Console.WriteLine($"Intento {intento}");
} while (intento < 3);

// foreach: recorrer los hábitos
string[] habitos = { "Crema", "Gym", "C#", "Duolingo", "Agua" };
foreach (string habito in habitos)
{
    Console.WriteLine($"Hábito: {habito}");
}