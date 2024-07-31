using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Actividad_8
{
    internal class Recetas
    {
        public string Nombre { get; set; }
        public string Ingredientes { get; set; }
        public string Preparacion { get; set; }

        public Recetas(string nombre, string ingredientes, string preparacion)
        {
            Nombre = nombre;
            Ingredientes = ingredientes;
            Preparacion = preparacion;
        }

        public Recetas(List<Recetas> recetasList)
        {
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("--- Recetas ---");
            Console.WriteLine("1. Agregar Recetas");
            Console.WriteLine("2. Buscar Recetas");
            Console.WriteLine("3. Mostrar Recetas");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese una opción: ");
        }

        public void IngresarRecetas(List<Recetas> recetaList)
        {

            try
            {
              
                Console.WriteLine("Ingrese el nombre de la receta: ");
                string nombreReceta = Console.ReadLine() ?? "";
                nombreReceta.ToLower();
                Console.WriteLine("Ingrese los ingredientes: ");
                string ingredientesReceta = Console.ReadLine() ?? "";
                Console.WriteLine("Ingrese una descripción de la preparación: ");
                string preparacionReceta = Console.ReadLine() ?? "";
                Recetas? recetaNombreFind = recetaList.Find(p => p.Nombre == nombreReceta);
                if (recetaNombreFind == null)
                {
                    recetaList.Add(new Recetas(nombreReceta, ingredientesReceta, preparacionReceta));
                    Console.WriteLine("Receta Añadida Correctamente");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Receta Existente");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("[!]Error: "+ ex.Message);
            }
        }
        public void BuscarReceta(List<Recetas> recetaList)
        {
            Console.WriteLine("--- Buscar Recetas ---");
            Console.Write("Ingresa el nombre de la Receta: ");
            string nombreReceta = Console.ReadLine() ?? "";
            nombreReceta.ToLower();
            Recetas? recetasFind = recetaList.Find(p => p.Nombre == nombreReceta);
            if (recetasFind != null)
            {
                Console.WriteLine($"Nombre: {recetasFind.Nombre}\nIngredientes {recetasFind.Ingredientes}\nPreparación: {recetasFind.Preparacion}");
                Console.WriteLine("");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Receta Inexistente");
                Console.ReadKey();
            }

        }
        public void MostrarRecetas(List<Recetas> recetasList)
        {
            foreach (var recetas in recetasList)
            {
                Console.WriteLine("--- Receta {ID} ---");
                Console.WriteLine($"Nombre: {recetas.Nombre}\nIngredientes: {recetas.Ingredientes}\nPreparación: {recetas.Preparacion} ");
            }
        }

    }
}
