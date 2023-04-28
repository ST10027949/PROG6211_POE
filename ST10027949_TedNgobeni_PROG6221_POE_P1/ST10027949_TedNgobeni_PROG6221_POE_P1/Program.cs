using System;
using System.Collections.Generic;

namespace ST10027949_TedNgobeni_PROG6221_POE_P1
{
    //Creation of the recipe class that willl hold the methods.
    class Recipe
    {
        public int NumberOfIngredients { get; private set; }
        public string[] IngredientNames { get; private set; }
        public double[] IngredientQuantities { get; private set; }
        public string[] MeasurementUnit { get; private set; }
        public int NumberOfSteps { get; private set; }
        public string[] StepDescriptions { get; private set; }

      
    }

    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
          
        }
    }

}


