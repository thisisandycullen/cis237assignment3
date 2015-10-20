//ANDY CULLEN
//DUE DATE: 10/20/15
//ASSIGNMENT 3: Inheritance, Abstract Classes, Interfaces, and Polymorphism

//PROGRAM CLASS

//THIS CLASS PRINTS THE WELCOME HEADER, THEN CREATES A USERINTERFACE OBJECT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {   //PRINT WELCOME HEADER
            Console.WriteLine("    Jawa Droid Manager" + Environment.NewLine);
            Console.WriteLine("         ,-----.{0}       ,'_/_|_\\_`.{0}      /<<::8[O]::>\\{0}     _|-----------|_{0} :::|  | ====-=- |  |:::{0} :::|  | -=-==== |  |:::{0} :::\\  | ::::|()||  /:::{0} ::::| | ....|()|| |::::{0}     | |_________| |{0}     | |\\_______/| |{0}    /   \\ /   \\ /   \\{0}    `---' `---' `---'{0}", Environment.NewLine);
            
            //START PROGRAM PROCESSES
            UserInterface userInterface = new UserInterface();
        }
    }
}
