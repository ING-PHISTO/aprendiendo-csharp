// Ficha técnica de mi proyecto de tesis
string proyecto = "VLASS";
string lenguajeBot = "TypeScript";
char version = 'A';
int imagenesEntrenamiento = 240000;
int lugaresReconocidos = 6;
decimal exactitud = 99.0m;
bool usaWhatsApp = true;

Console.WriteLine($"Proyecto: {proyecto} (versión {version})");
Console.WriteLine($"Bot hecho en: {lenguajeBot}");
Console.WriteLine($"Entrenado con {imagenesEntrenamiento} imágenes");
Console.WriteLine($"Reconoce {lugaresReconocidos} lugares con {exactitud}% de exactitud");
Console.WriteLine($"¿Funciona por WhatsApp? {usaWhatsApp}");