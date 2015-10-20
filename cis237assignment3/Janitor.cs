//ANDY CULLEN
//DUE DATE: 10/20/15
//ASSIGNMENT 3: Inheritance, Abstract Classes, Interfaces, and Polymorphism

//JANITOR CLASS

//THE JANITOR CLASS CALCULATES THE TOTAL COST OF A JANITOR DROID BY ADDING ADDITIONAL COST FOR ADDED FEATURES
//IT INHERITS FROM THE UTILITY CLASS


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        //CLASS VARIABLES
        private bool hasTrashCompactor;
        private bool hasVacuum;

        //CLASS CONSTRUCTOR
        public Janitor(string ModelType, string MaterialType, string PaintColor, bool HasToolbox, bool ComputerConnected, bool HasArm, bool HasTrashCompactor, bool HasVacuum)
            : base(ModelType, MaterialType, PaintColor, HasToolbox, ComputerConnected, HasArm)
        {
            this.hasTrashCompactor = HasTrashCompactor;
            this.hasVacuum = HasVacuum;

            this.CalculateTotalCost();
        }

        //OVERRIDDEN TO STRING METHOD
        public override string ToString()
        {
            return base.ToString() + string.Format("{0} - Has Trash Compactor: {1}{0} - Has Vacuum: {2}", Environment.NewLine, this.hasTrashCompactor, this.hasVacuum);
        }

        //CALCULATES THE TOTAL COST OF A JANITOR DROID BY ADDING ADDITIONAL COST FOR ADDED FEATURES
        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();

            if (hasTrashCompactor)
            {
                this.TotalCost += 300;
            }

            if (hasVacuum)
            {
                this.TotalCost += 200;
            }
        }
    }
}

