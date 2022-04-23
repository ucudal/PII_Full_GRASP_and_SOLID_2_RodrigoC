//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Esta clase fue modificada ya que incumplia el SRP(Principio de Responsabilidad Única), debido a que esta clase previamente se encargaba de 
    /// crear recetas y imprimirlas en la consola, siendo esta última responsabilidad delegada a la nueva clase ConsolePrinter.
    /// 
    /// </summary>
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public ArrayList Taste()
        {
            return steps;
        }

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
    }
}