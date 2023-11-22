﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories.Models
{
    public class Dough
    {
        private const double BaseCaloriesPerGram = 2;
        public Dictionary<string, double> flourTypeCalories;
        public Dictionary<string, double> bakingTechniqueCalories;

        private string flourType;
        private string bakingTechnique;
        private double weight;
        public Dough(string flourType, string bakingTechnique, double weight)
        {
            flourTypeCalories = new Dictionary<string, double> { { "white", 1.5 }, { "wholegrain", 1.0 } };
            bakingTechniqueCalories = new Dictionary<string, double> { { "crispy", 0.9 }, { "chewy", 1.1 }, { "homemade", 1.0 } };
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (!flourTypeCalories.ContainsKey(value.ToLower()))
                    throw new ArgumentException("Invalid type of dough.");
                flourType = value.ToLower();
            }
        }
        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (!bakingTechniqueCalories.ContainsKey(value.ToLower()))
                    throw new ArgumentException("Invalid type of dough.");
                bakingTechnique = value.ToLower();
            }
        }
        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }
        public double Calories
        {
            get
            {

                double flourTypeModifier = flourTypeCalories[FlourType];
                double bakkingTechniqueModifier = bakingTechniqueCalories[BakingTechnique];
                return BaseCaloriesPerGram * Weight * flourTypeModifier * bakkingTechniqueModifier;
            }
        }
    }
}
