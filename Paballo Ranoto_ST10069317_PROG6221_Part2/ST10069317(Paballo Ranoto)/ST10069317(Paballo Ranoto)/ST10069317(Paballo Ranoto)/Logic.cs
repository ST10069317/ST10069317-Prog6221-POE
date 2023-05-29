using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10069317_Paballo_Ranoto_
{
    public class Logic
    {
        private const int LIMIT = 300;
        private int limitBalance;

        public int LimitBalance { get { return limitBalance; } set { limitBalance = value; } }

        public void checkLImit(int Limit)
        {
            if (Limit > 300)
            {
                throw new ArgumentOutOfRangeException("limit", Limit, "THe calories are too much");
            }
            if (Limit < LIMIT)
            {
                throw new ArgumentOutOfRangeException("limit");
            }
            limitBalance = limitBalance - Limit;
        }


        //Declarations
        public List<Ingredients> food = new List<Ingredients>();
        public List<Ingredients> steps = new List<Ingredients>();

        Ingredients ingredients = new Ingredients();
        int numberOfIngredients;
        int numberOfSteps;
        int i;
        

        public void Add()
        {
            //Ask user to enter name and number of ingredients
            Console.WriteLine("===========================");
            Console.WriteLine("What is the name of the Recipe");
            string recipeNames = Console.ReadLine();
            ingredients.RecipeName = recipeNames;
            Console.Write("Enter the number of ingredients");
            numberOfIngredients = Convert.ToInt32(Console.ReadLine());

            //A for loop to store the user input in a class 
            for (int i = 0; i < numberOfIngredients; i++)
            {

                /*Ingrdients food = new Ingredients(i);*/

                Console.WriteLine("---------------------------------------------");
                Console.Write($"Name of ingredient {i+1}: ");
                String nameOfIngredient = Console.ReadLine();

                Console.Write($"What is the quantity of the ingredient {i+1}: ");
                int numberOfQuantity = Convert.ToInt32(Console.ReadLine());

                Console.Write($"What is the unit of measurement {i+1}: ");
                int numberofUnit = Convert.ToInt32(Console.ReadLine());

                Console.Write($"How many Calories in {i + 1}: ");
                double numberOfCalories = Convert.ToDouble(Console.ReadLine());

                Console.Write($"What is the Food Group {i + 1}: ");
                string foodGroup = Console.ReadLine();

                
                ingredients.Name = nameOfIngredient;
                ingredients.Quantity = numberOfQuantity;
                ingredients.Unit = numberofUnit;
                ingredients.Calories = numberOfCalories;
                ingredients.FoodGroup = foodGroup;

                Console.WriteLine("---------------------------------------------");
                }

            Console.Write("How many steps for the ingredients");
            numberOfSteps = Convert.ToInt32(Console.ReadLine());

            /* steps = new Ingredients[numberOfSteps];*/
            Ingredients steps = new Ingredients();
            for (int i = 0; i < numberOfSteps; i++)
            {
                Console.Write($"Step {i + 1}: ");
                string step = Console.ReadLine();

                if (step == "")
                {
                    break;
                }

                steps.Steps = step;
            }
        }

        public void show()
        {
            Console.WriteLine("The Ingredients");
            foreach (var foods in food)
            {
                Console.WriteLine(foods.ToString());
            }

            for(int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"Step {steps[i].Steps}");
            }
        }

        public void Scale()
        {
             //Declaration
            double factor;

            //Ask user of the factor they want to enter
            Console.WriteLine("What factor do u want to scale the Quantity of the Ingrdients");
            Console.WriteLine("[0.5 (Half)] or [2.0 (Double)] or [3.0 (trible)] ");

            //User Input
            factor = Convert.ToDouble(Console.ReadLine());

            if (factor == 0.5 || factor == 2 || factor == 3)
            {
                for (int i = 0; i < numberOfIngredients; i++)
                {
                    //factor the quantity by 0.5 multiply by 0.5
                    food[i].Quantity *= factor;
                }
            }
            else
            {
                Console.WriteLine("Invalid amount");
            }
        }

        public void Reset()
        {
            food[i].Quantity = food[i].Quantity;
        }

        public void Clear()
        {
            food.Clear();
            steps.Clear();
        }
    }
}
