using Laboratorio_02;
HabitacionSimple listHabitacionSimple = new HabitacionSimple(0,0,null,null,0);
HabitacionDoble listHabitacionDoble = new HabitacionDoble(0, 0, null, null, null);
Suite listSuites = new Suite(0,0,null,null,0,null);
HabitacionDeluxe listDeluxe = new HabitacionDeluxe(0,0,null,null,null);
bool menucondition = true;
do
{
    Console.Clear();
    Console.WriteLine("______MENU______");
    Console.WriteLine("1.Agregar habitaciones");
    Console.WriteLine("2.Eliminar habitación");
    Console.WriteLine("3.Mostrar habitaciones");
    Console.WriteLine("4.Asignar habitaciones");
    Console.WriteLine("5.Liberar habitaciones");
    Console.WriteLine("6.Salir del programa");
    int option = int.Parse(Console.ReadLine());
    try
    {
        switch (option)
        {
            case 1:
                bool menucondition2 = true;
                do
                {
                    Console.Clear();
                    Console.WriteLine("______AGREGAR HABITACIONES______");
                    Console.WriteLine("1.Habitación simple");
                    Console.WriteLine("2.Habitación Doble");
                    Console.WriteLine("3.Suite");
                    Console.WriteLine("4.Habitación Deluxe");
                    Console.WriteLine("5.Regresar");
                    int option2 = int.Parse(Console.ReadLine());
                    switch (option2)
                    {
                        case 1:
                            listHabitacionSimple.AgregarHabitacion();
                            break;
                        case 2:
                            listHabitacionDoble.AgregarHabitacion();
                            break;
                        case 3:
                            listSuites.AgregarHabitacion();
                            break;
                        case 4:
                            listSuites.AgregarHabitacion();
                            break;
                        case 5:
                            menucondition2 = false;
                            break;
                    }
                }
                while (menucondition2);
                break;
            case 2:
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Habitaciones simples:");
                listHabitacionSimple.MostrarInformacion();
                Console.WriteLine("\nHabitaciones dobles:");
                listHabitacionDoble.MostrarInformacion();
                Console.WriteLine("\nSuites:");
                listSuites.MostrarInformacion();
                Console.WriteLine("\nHabitaciones deluxe:");
                listDeluxe.MostrarInformacion();
                Console.WriteLine("Habitaciones registradas correctamente.");
                Console.WriteLine("Presione cualquier tecla para continuar: ");
                Console.ReadKey();
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                menucondition = false;
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
while (menucondition);