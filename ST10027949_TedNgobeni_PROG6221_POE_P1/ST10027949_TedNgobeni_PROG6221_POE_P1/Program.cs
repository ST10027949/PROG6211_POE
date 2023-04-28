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
       

        //Get method that asks for user input
        private void GetIngredientDetails()
        {

            Console.Write("Please enter accordingly ;) \n");
            Console.Write("\n***************************************************\n");

            //User input for ingredients 
            Console.Write("\nEnter the number of ingredients: ");
            NumberOfIngredients = int.Parse(Console.ReadLine());

            //Creates arrays to hold inputs
            IngredientNames = new string[NumberOfIngredients];
            IngredientQuantities = new double[NumberOfIngredients];
            MeasurementUnit = new string[NumberOfIngredients];

            //For loop that iterates through the amount of ingredients 
            for (int i = 0; i < NumberOfIngredients; i++)
            {
                Console.WriteLine($"\nIngredient {i + 1}\n");

                Console.Write("Name: ");
                IngredientNames[i] = Console.ReadLine();

                Console.Write("Quantity: ");
                IngredientQuantities[i] = double.Parse(Console.ReadLine());

                Console.Write("Unit: ");
                MeasurementUnit[i] = Console.ReadLine();
            }
        }

        //Get method that asks for user input
        private void StepDescription()
        {
            //Asks for user input 
            Console.Write("\nEnter the number of steps: ");
            NumberOfSteps = int.Parse(Console.ReadLine());

            //Creates a array to hold steps
            StepDescriptions = new string[NumberOfSteps];

            //Loop that iterates through the amount of steps that are needed
            for (int i = 0; i < NumberOfSteps; i++)
            {
                Console.WriteLine($"\nStep {i + 1}\n");

                Console.Write("Enter the step description: ");
                StepDescriptions[i] = Console.ReadLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
        }
    }

}



