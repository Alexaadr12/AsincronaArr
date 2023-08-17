Console.WriteLine("Hello, World!");

{
    
    {
        int[] numeros = { 4, 10, 45, -67, -7, 25, 89, 64 };
        ImprimirArreglo("Arreglo original:", numeros);

        Array.Reverse(numeros);
        ImprimirArreglo("\nArreglo después de Reverse:", numeros);

        Array.Sort(numeros);
        ImprimirArreglo("\nArreglo después de Sort:", numeros);
    }

    static void ImprimirArreglo(string mensaje, int[] arreglo)
    {
        Console.WriteLine(mensaje);
        foreach (int numero in arreglo)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}
