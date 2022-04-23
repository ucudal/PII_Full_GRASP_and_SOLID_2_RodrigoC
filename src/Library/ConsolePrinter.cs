using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase creada aplicando el patrón expert, esta clase es experta en imprimir recetas en la consola. A su vez dicha clase 
    /// cumple el principio de responsabilidad única(SRP), ya que la única responsabilidad de esta clase es imprimir recetas 
    /// y su única razón de cambio es si en un futuro quiero cambiar la forma en la cual se imprime la receta.
    ///
    /// </summary>
    public class ConsolePrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.Taste())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}