//ANDY CULLEN
//DUE DATE: 10/20/15
//ASSIGNMENT 3: Inheritance, Abstract Classes, Interfaces, and Polymorphism

//DROID CLASS

//THE DROID CLASS ASSIGNS THE MATERIAL COST OF A DROID

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {   //CLASS VARIABLES
        private string modelType;
        private string materialType;
        private string paintColor;
        private decimal materialCostDecimal;
        private decimal totalCostDecimal;

        //DEFAULT CONSTRUCTOR
        public Droid() { }

        //OVERLOADED CONSTRUCTOR
        public Droid(string ModelType, string MaterialType, string PaintColor)
        {
            this.modelType = ModelType;
            this.materialType = MaterialType;
            this.paintColor = PaintColor;

            this.SetMaterialCost();             //SET THE COST OF MATERIALS FOR THE DROID
        }

        //GETTERS AND SETTERS
        public string ModelType
        {
            get { return modelType; }
            set { modelType = value; }
        }

        public string MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }

        public string PaintColor
        {
            get { return paintColor; }
            set { paintColor = value; }
        }

        public decimal MaterialCost
        {
            get { return materialCostDecimal; }
            set { materialCostDecimal = value; }
        }

        public decimal TotalCost
        {
            get { return totalCostDecimal; }
            set { totalCostDecimal = value; }
        }

        //OVERRIDDEN TOSTRING METHOD
        public override string ToString()
        {
            return string.Format("{0}{1} Droid{0} - Material: {2}{0} - Paint Color: {3}", Environment.NewLine,
                                    this.modelType, this.materialType, this.paintColor);
        }

        //SETS THE COST OF MATERIALS FOR THE DROID
        public virtual void SetMaterialCost()
        {
            switch (this.materialType) 
            {
                default:
                    this.materialCostDecimal = 100; break;
                case "Iron":
                    this.materialCostDecimal = 1500; break;
                case "Bronzium":
                    this.materialCostDecimal = 2000; break;
                case "Carbonite":
                    this.materialCostDecimal = 2500; break;
                case "Duralium":
                    this.materialCostDecimal = 3000; break;
                case "Quadranium":
                    this.materialCostDecimal = 3500; break;
                case "Agrinium":
                    this.materialCostDecimal = 4000; break;
                case "Gold":
                    this.materialCostDecimal = 4500; break;
                case "Platinum":
                    this.materialCostDecimal = 5000; break;
            }
        }

        public abstract void CalculateTotalCost();

    }
}