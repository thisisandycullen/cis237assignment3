//ANDY CULLEN
//DUE DATE: 10/20/15
//ASSIGNMENT 3: Inheritance, Abstract Classes, Interfaces, and Polymorphism

//DROIDCOLLECTOR CLASS

//THIS CLASS ACCEPTS NEW DROIDS FROM THE USER INTERFACE AND STORES THEM IN A LIST

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollector
    {
        //THIS LIST STORES THE DROID OBJECTS
        List<Droid> droidCollection = new List<Droid>();

        //DEFAULT CONSTRUCTOR
        public DroidCollector() {}

        //CONSTRUCTOR THAT ADDS A NEW PROTOCOL DROID
        public void addDroid(string ModelType, string MaterialType, string PaintColor, int LanguageCount)
        {
            Protocol newDroid = new Protocol(ModelType, MaterialType, PaintColor, LanguageCount);
            droidCollection.Add(newDroid);
        }

        //CONSTRUCTOR THAT ADDS A NEW UTILITY DROID
        public void addDroid(string ModelType, string MaterialType, string PaintColor, bool HasToolbox, bool ComputerConnected, bool HasArm)
        {
            Utility newDroid = new Utility(ModelType, MaterialType, PaintColor, HasToolbox, ComputerConnected, HasArm);
            droidCollection.Add(newDroid);
        }

        //CONSTRUCTOR THAT ADDS A NEW JANITOR DROID
        public void addDroid(string ModelType, string MaterialType, string PaintColor, bool HasToolbox, bool ComputerConnected, bool HasArm, bool HasTrashCompactor, bool HasVacuum)
        {
            Janitor newDroid = new Janitor(ModelType, MaterialType, PaintColor, HasToolbox, ComputerConnected, HasArm, HasTrashCompactor, HasVacuum);
            droidCollection.Add(newDroid);
        }

        //CONSTRUCTOR THAT ADDS A NEW ASTROMECH DROID
        public void addDroid(string ModelType, string MaterialType, string PaintColor, bool HasToolbox, bool ComputerConnected, bool HasArm, bool HasFireExtinguisher, int ShipsCount)
        {
            Astromech newDroid = new Astromech(ModelType, MaterialType, PaintColor, HasToolbox, ComputerConnected, HasArm, HasFireExtinguisher, ShipsCount);
            droidCollection.Add(newDroid);
        }

        //EITHER RETURNS THE LIST OF DROIDS IN A STRING, OR STATES THAT NONE HAVE BEEN LOGGED (SENT TO USERINTERFACE)
        public string ShowDroidList()
        {   
            string droidCollectionString = "";

            if (droidCollection.Count > 0)
            {
                foreach (var droid in droidCollection)
                {
                    droidCollectionString += string.Format(droid.ToString() + "{0} - Price: " + droid.TotalCost.ToString("N") + " credits{0}", Environment.NewLine);
                }
            }
            else
            {
                droidCollectionString = string.Format("{0}No droids have been logged.", Environment.NewLine);
            }

            return droidCollectionString;
        }
    }
}

