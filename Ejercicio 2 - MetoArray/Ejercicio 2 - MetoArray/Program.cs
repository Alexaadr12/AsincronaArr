Console.WriteLine("Hello, World!");

{
    string[] palabras = { "Casa", "Dedo", "Taquito", "Mundo", "Sol", "Europalandiaxd" };

    Array.Sort(palabras); // Asegurarse de que el arreglo esté ordenado para usar BinarySearch

    string[] palabrasBuscadas = { "Sol", "Dedo", "Casa" };

    foreach (string palabra in palabrasBuscadas)
    {
        int posicion = Array.BinarySearch(palabras, palabra);

        if (posicion >= 0)
        {
            Console.WriteLine($"La palabra '{palabra}' se encuentra en la posición {posicion}.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabra}' no se encontró en el arreglo.");
        }
    }
}
