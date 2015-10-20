//ANDY CULLEN
//DUE DATE: 10/20/15
//ASSIGNMENT 3: Inheritance, Abstract Classes, Interfaces, and Polymorphism

//IDROID INTERFACE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    interface IDroid
    {
        //INTERFACE METHODS
        void CalculateTotalCost();

        //INTERFACE GETTER/SETTER
        decimal TotalCost
        { 
            get; 
            set; 
        }
    }
}
