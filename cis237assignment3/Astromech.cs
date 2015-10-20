//ANDY CULLEN
//DUE DATE: 10/20/15
//ASSIGNMENT 3: Inheritance, Abstract Classes, Interfaces, and Polymorphism

//ASTROMECH CLASS

//THE ASTROMECH CLASS CALCULATES THE TOTAL COST OF A ASTROMECH DROID BY ADDING ADDITIONAL COST FOR ADDED FEATURES
//IT INHERITS FROM THE UTILITY CLASS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        //CLASS CONSTANTS
        private const decimal SHIP_COST = 1;

        //CLASS VARIABLES
        private bool hasFireExtinguisher;
        private int shipCount;

        //CLASS CONSTRUCTOR
        public Astromech(string ModelType, string MaterialType, string PaintColor, bool HasToolbox, bool ComputerConnected, bool HasArm, bool HasFireExtinguisher, int ShipCount)
            : base(ModelType, MaterialType, PaintColor, HasToolbox, ComputerConnected, HasArm)
        {
            this.hasFireExtinguisher = HasFireExtinguisher;
            this.shipCount = ShipCount;

            this.CalculateTotalCost();
        }

        //OVERRIDDEN TO STRING METHOD
        public override string ToString()
        {
            return base.ToString() + string.Format("{0} - Fire Extinguisher: {1}{0} - Ships: {2}", Environment.NewLine, this.hasFireExtinguisher, this.shipCount);
        }

        //CALCULATES THE TOTAL COST OF AN ASTROMECH DROID BY ADDING ADDITIONAL COST FOR ADDED FEATURES
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();

            TotalCost += (SHIP_COST * this.shipCount);

            if (this.hasFireExtinguisher)
            {
                this.TotalCost += 200;
            }
        }
    }
}
