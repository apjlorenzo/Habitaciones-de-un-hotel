using Laboratorio_02;

List <Habitación> listHabitacion = new List<Habitación> ();
bool menucondition = true;
do
{
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
                
                Console.ReadKey();
                break;
            case 2:
                Console.Clear();
                Console.ReadKey();
                break;
            case 3:
                Console.Clear();
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