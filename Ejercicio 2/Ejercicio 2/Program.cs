Console.WriteLine("BIENVENIDO LINDO/A USUARIO :3");
{  
    {
        // Paso 1: Declarar y tambien inicializar eñ arreglo con nombre y apellido
        string[] nombreCompleto = { "Vladimir", "Alas" };

        // Paso 2: Imprimir los valores del arreglo
        Console.WriteLine("Valores del arreglo:");
        foreach (string valor in nombreCompleto)
        {
            Console.WriteLine(valor);
        }

        // Paso 3: Almacenar la longitud del arreglo pues en una variable
        int longitudArreglo = nombreCompleto.Length;

        // Paso 4: Imprimir en consola, el tamaño del arreglo con sus valores
        Console.WriteLine($"Tamaño del arreglo: {longitudArreglo}");
        Console.WriteLine("Valores del arreglo:");
        for (int i = 0; i < longitudArreglo; i++)
        {
            Console.WriteLine($"Posición {i}: {nombreCompleto[i]}");
        }
    }
}
