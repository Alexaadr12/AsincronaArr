Console.WriteLine("Welcome to my beatiful program <3");

{
    // Paso 1: Declarar un arreglo de 10 posiciones con los valores ya dados
    string[] palabras = { "Perro", "Casa", "Cebra", "Tortuga", "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };

    // Paso 2: Mostrar el arreglo con sus posiciones inicializadas
    Console.WriteLine("Arreglo original:");
    for (int i = 0; i < palabras.Length; i++)
    {
        Console.WriteLine($"Posición {i}: {palabras[i]}");
    }

    // Paso 3: función Sort para ordenar el arreglo
    Array.Sort(palabras);

    // Paso 4: Imprimir en consola, el arreglo ordenado
    Console.WriteLine("\nArreglo ordenado:");
    for (int i = 0; i < palabras.Length; i++)
    {
        Console.WriteLine($"Posición {i}: {palabras[i]}");
    }
}

