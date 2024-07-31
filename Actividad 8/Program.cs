using Actividad_8;

List<Recetas> RecetasList = new List<Recetas> ();
Recetas recetasObjetc = new Recetas(RecetasList);

bool run = true;
do
{
    try
    {

        recetasObjetc.Menu();
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.Clear();
                recetasObjetc.IngresarRecetas(RecetasList);

                break;
            case 2:
                Console.Clear();
                recetasObjetc.BuscarReceta(RecetasList);
              
                break;
            case 3:
                Console.Clear();
                recetasObjetc.MostrarRecetas(RecetasList);
               
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Saliendo...");
                Console.ReadKey();
                run = false;
                break;

            default:
                Console.WriteLine("Ingrese una opción válida");
                Console.ReadKey();
                break;
        }
    }
    catch (Exception ex)
    {

        Console.WriteLine("Error: " + ex.Message);
        Console.ReadKey();
    }
} while (run == true);