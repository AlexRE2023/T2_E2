using System;

class Program
{
    static void Main()
    {
        string[] estudiantes = new string[100];
        int[] notas = new int[100];
        int cantidadEstudiantes = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("Notas de estudiantes");
            Console.WriteLine("================================");
            Console.WriteLine("1: Ingresar nota");
            Console.WriteLine("2: Nota más alta");
            Console.WriteLine("3: Nota más baja");
            Console.WriteLine("4: Ver lista de estudiantes");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        IngresarNota(estudiantes, notas, ref cantidadEstudiantes);
                        break;
                    case 2:
                        NotaMasAlta(estudiantes, notas, cantidadEstudiantes);
                        break;
                    case 3:
                        NotaMasBaja(estudiantes, notas, cantidadEstudiantes);
                        break;
                    case 4:
                        ListaDeEstudiantes(estudiantes, notas, cantidadEstudiantes);
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
            }

            Console.Write("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void IngresarNota(string[] estudiantes, int[] notas, ref int cantidadEstudiantes)
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("Ingresar Nota");
        Console.WriteLine("================================");

        if (cantidadEstudiantes < estudiantes.Length)
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            estudiantes[cantidadEstudiantes] = Console.ReadLine();

            Console.Write("Ingrese la nota: ");
            if (int.TryParse(Console.ReadLine(), out int nota))
            {
                notas[cantidadEstudiantes] = nota;
                cantidadEstudiantes++;

                Console.WriteLine("================================");
                Console.WriteLine(" ¡ Guardado ! ");
                Console.WriteLine("================================");
            }
            else
            {
                Console.WriteLine("La nota ingresada no es válida.");
            }

            Console.WriteLine("1: Agregar uno más");
            Console.WriteLine("2: Volver");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                if (opcion == 1)
                {
                    IngresarNota(estudiantes, notas, ref cantidadEstudiantes);
                }
            }
            else if (opcion == 2)
            {
                return;
            }
            else
            {
                Console.WriteLine("Opción inválida. Volviendo al menú principal.");
            }
        }
        else
        {
            Console.WriteLine("Se ha alcanzado el límite de estudiantes.");
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            Console.WriteLine("================================");
            Console.Write("Ingrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
        }
    }

    static void NotaMasAlta(string[] estudiantes, int[] notas, int cantidadEstudiantes)
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("La nota más alta");
        Console.WriteLine("================================");

        if (cantidadEstudiantes > 0)
        {
            int notaMasAlta = notas[0];

            for (int i = 1; i < cantidadEstudiantes; i++)
            {
                int notaActual = notas[i];
                if (notaActual > notaMasAlta)
                {
                    notaMasAlta = notaActual;
                }
            }

            Console.WriteLine("La nota más alta es: " + notaMasAlta);

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                if (i > 0)
                {
                    Console.Write(" ");
                }

                if (notas[i] == notaMasAlta)
                {
                    Console.Write(estudiantes[i] + " [" + notas[i] + "]");
                }
                else
                {
                    Console.Write(estudiantes[i] + " " + notas[i]);
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No hay estudiantes registrados.");
        }

        Console.WriteLine("================================");
        Console.WriteLine("1: Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            return;
        }
    }

    static void NotaMasBaja(string[] estudiantes, int[] notas, int cantidadEstudiantes)
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("La nota más baja");
        Console.WriteLine("================================");

        if (cantidadEstudiantes > 0)
        {
            int notaMasBaja = notas[0];
            int posicionMasBaja = 0;

            for (int i = 1; i < cantidadEstudiantes; i++)
            {
                int notaActual = notas[i];
                if (notaActual < notaMasBaja)
                {
                    notaMasBaja = notaActual;
                    posicionMasBaja = i;
                }
            }

            Console.WriteLine("La nota más baja es: " + notaMasBaja);

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                if (i > 0)
                {
                    Console.Write(" ");
                }
                if (i == posicionMasBaja)
                {
                    Console.Write(estudiantes[i] + " [" + notaMasBaja + "]");
                }
                else
                {
                    Console.Write(estudiantes[i] + " " + notas[i]);
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No hay estudiantes registrados.");
        }

        Console.WriteLine("================================");
        Console.WriteLine("1: Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            return;
        }
    }

    static void ListaDeEstudiantes(string[] estudiantes, int[] notas, int cantidadEstudiantes)
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("Lista de estudiantes");
        Console.WriteLine("================================");

        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            Console.WriteLine(estudiantes[i] + " - " + notas[i]);
        }

        Console.WriteLine("================================");
        Console.WriteLine("1: Regresar");
        Console.WriteLine("================================");
        Console.Write("Ingrese una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            return;
        }
    }
}