// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido linda personita <3");

    {
        // Primer paso: Se declarao un arreglo sin tamaño
        float[] arreglo;

        // Paso 2: Pedir el tamaño de dicho arreglo
        Console.WriteLine("Ingrese el tamaño del arreglo: ");
        int tamaño = Convert.ToInt32(Console.ReadLine());

        if (tamaño < 5)
        {
            Console.WriteLine("Estimado, el tamaño a ingresar minimo es de -> 5.");
            return;
        }

        // Inicializar el arreglo con el tamaño ya propuesto
        arreglo = new float[tamaño];

        // Paso 3: Pedir al usuario que ingrese los valores de dicho arreglo
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write($"Ingrese el valor para la posición {i}: ");
            arreglo[i] = Convert.ToSingle(Console.ReadLine());
        }

        // Imprimir EN CONSOLA los valores ingresados
        Console.WriteLine("Estimado personita, estos son los números que ingreso:");
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.WriteLine($"Posición {i}: {arreglo[i]}");
        }
    }
