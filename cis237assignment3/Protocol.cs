//ANDY CULLEN
//DUE DATE: 10/20/15
//ASSIGNMENT 3: Inheritance, Abstract Classes, Interfaces, and Polymorphism

//PROTOCOL CLASS

//THE PROTOCOL CLASS CALCULATES THE TOTAL COST OF A PROTOCOL DROID BY ADDING ADDITIONAL COST FOR ADDED FEATURES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {   //CLASS CONSTANTS
        private const decimal LANGUAGE_COST = 1m;
        private const decimal BASE_COST = 1000m;
       
        //CLASS VARIABLES
        private int languageCount;

        //CLASS CONSTRUCTOR
        public Protocol(string ModelType, string MaterialType, string PaintColor, int LanguageCount)
            : base(ModelType, MaterialType, PaintColor)
        {
            this.languageCount = LanguageCount;

            this.CalculateTotalCost();
        }

        //OVERRIDDEN TO STRING METHOD
        public override string ToString()
        {
            return base.ToString() + string.Format("{0} - Languages: {1}", Environment.NewLine, this.languageCount);
        }

        //CALCULATES THE TOTAL COST OF A PROTOCOL DROID BY ADDING ADDITIONAL COST FOR ADDED FEATURES
        public override void CalculateTotalCost()
        {
            decimal languagesCost = this.languageCount * LANGUAGE_COST;
            this.TotalCost = BASE_COST + this.MaterialCost + languagesCost;
        }
    }
}
