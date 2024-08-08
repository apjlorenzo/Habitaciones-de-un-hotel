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
    Console.Write("Escriba una opción: ");
    try
    {
        int option = int.Parse(Console.ReadLine());
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
                    Console.Write("Escriba una opción: ");
                    try
                    {
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
                                listDeluxe.AgregarHabitacion();
                                break;
                            case 5:
                                menucondition2 = false;
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                    }
                }
                while (menucondition2);
                break;
            case 2:
                Console.Clear();
                Console.WriteLine("Ingrese el tipo de habitacion a eliminar: (1.Simple 2. Doble 3. Suite o 4. Deluxe)");
                int respuesta = int.Parse(Console.ReadLine());
                if (respuesta == 1)
                {
                    listHabitacionSimple.EliminarHabitacion();
                }
                else if (respuesta == 2)
                {
                    listHabitacionDoble.EliminarHabitacion();
                }
                else if (respuesta == 3)
                {
                    listSuites.EliminarHabitacion();
                }
                else if (respuesta == 4)
                {
                    listDeluxe.EliminarHabitacion();
                }
                else
                {
                    Console.WriteLine("No es una opción válida.");
                }
                break;
            case 3:
                Console.Clear();
                listHabitacionSimple.MostrarInformacion();
                listHabitacionDoble.MostrarInformacion();
                listSuites.MostrarInformacion();
                listDeluxe.MostrarInformacion();
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Ingrese el tipo de habitacion a asignar el cliente: (1.Simple 2. Doble 3. Suite o 4. Deluxe)");
                int respuesta2 = int.Parse(Console.ReadLine());
                if (respuesta2 == 1)
                {
                    listHabitacionSimple.AsignarCliente();
                }
                else if (respuesta2 == 2)
                {
                    listHabitacionDoble.AsignarCliente();
                }
                else if (respuesta2 == 3)
                {
                    listSuites.AsignarCliente();
                }
                else if (respuesta2 == 4)
                {
                    listDeluxe.AsignarCliente();
                }
                else
                {
                    Console.WriteLine("No es una opción válida.");
                }
                Console.ReadKey();
                break;
            case 5:
                Console.Clear();
                Console.WriteLine("Ingrese el tipo de habitacion a asignar el cliente: (1.Simple 2. Doble 3. Suite o 4. Deluxe)");
                int respuesta3 = int.Parse(Console.ReadLine());
                if (respuesta3 == 1)
                {
                    listHabitacionSimple.LiberarHabitacion();
                }
                else if (respuesta3 == 2)
                {
                    listHabitacionDoble.LiberarHabitacion();
                }
                else if (respuesta3 == 3)
                {
                    listSuites.LiberarHabitacion();
                }
                else if (respuesta3 == 4)
                {
                    listDeluxe.LiberarHabitacion();
                }
                else
                {
                    Console.WriteLine("No es una opción válida.");
                }
                Console.ReadKey();
                break;
            case 6:
                menucondition = false;
                break;
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        Console.ReadKey();
    }
}
while (menucondition);
