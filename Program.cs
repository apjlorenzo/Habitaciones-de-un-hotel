using Laboratorio_02;

HabitacionSimple listHabitación = new HabitacionSimple(0,0,false,null,0); 
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
                Console.Clear();
                do
                {
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
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                    }
                }
                while (true);
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
                listHabitación.MostrarInformacion();
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Console.ReadKey();
                break;
            case 5:
                Console.Clear();
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
    }
}
while (menucondition);