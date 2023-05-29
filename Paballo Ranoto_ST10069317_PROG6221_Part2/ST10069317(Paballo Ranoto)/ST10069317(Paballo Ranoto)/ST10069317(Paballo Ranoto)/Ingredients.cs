using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10069317_Paballo_Ranoto_
{
    public class Ingredients
    {
        private string? name;
        private string? recipeName;
        private double quantity;
        private double unit;
        private string? steps;
        private double calories;
        private string? foodGroup;
        //set ans get
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string RecipeName
        {
            get { return recipeName; }
            set { recipeName = value; }
        }

        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public string Steps
        {
            get { return steps; }
            set { steps = value; }
        }

        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public string FoodGroup
        {
            get { return foodGroup; }
            set { foodGroup = value; }
        }
    }
}
