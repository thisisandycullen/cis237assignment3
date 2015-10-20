//ANDY CULLEN
//DUE DATE: 10/20/15
//ASSIGNMENT 3: Inheritance, Abstract Classes, Interfaces, and Polymorphism

//UTILITY CLASS

//THE UTILITY CLASS CALCULATES THE TOTAL COST OF A UTILITY DROID BY ADDING ADDITIONAL COST FOR ADDED FEATURES
//IT INHERITS FROM THE DROID CLASS


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {   //CLASS CONSTANTS
        private const decimal BASE_COST = 1500m;

        //CLASS VARIABLES
        private bool hasToolbox;
        private bool computerConnected;
        private bool hasArm;

        //CLASS CONSTRUCTOR
        public Utility(string ModelType, string MaterialType, string PaintColor, bool HasToolbox, bool ComputerConnected, bool HasArm)
            : base(ModelType, MaterialType, PaintColor)
        {
            this.hasToolbox = HasToolbox;
            this.computerConnected = ComputerConnected;
            this.hasArm = HasArm;

            this.CalculateTotalCost();
        }

        //GETTERS AND SETTERS
        public bool HasToolbox
        {
            get { return hasToolbox; }
            set { hasToolbox = value; }
        }

        public bool ComputerConnected
        {
            get { return computerConnected; }
            set { computerConnected = value; }
        }

        public bool HasArm
        {
            get { return hasArm; }
            set { hasArm = value; }
        }

        //OVERRIDDEN TO STRING METHOD
        public override string ToString()
        {
            return base.ToString() + string.Format("{0} - Has Toolbox: {1}{0} - Computer Connected: {2}{0} - Has Arm: {3}", Environment.NewLine, this.hasToolbox, this.computerConnected, this.hasArm);
        }

        //CALCULATES THE TOTAL COST OF A UTILITY DROID BY ADDING ADDITIONAL COST FOR ADDED FEATURES
        public override void CalculateTotalCost()
        {
            this.TotalCost += (BASE_COST + this.MaterialCost);

            if (hasToolbox)
            {
                this.TotalCost += 500;
            }

            if (computerConnected)
            {
                this.TotalCost += 1200;
            }

            if (hasArm)
            {
                this.TotalCost += 300;
            }
        }
    }
}