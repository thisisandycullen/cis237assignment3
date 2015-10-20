//ANDY CULLEN
//DUE DATE: 10/20/15
//ASSIGNMENT 3: Inheritance, Abstract Classes, Interfaces, and Polymorphism

//USERINTERFACE CLASS

//THIS CLASS HANDLES USER INPUT, ASSIGNS VALUES FOR NEW DROID OBJECTS, AND PRINTS INFORMATION TO THE CONSOLE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {   //CLASS VARIABLES
        private int userInputInt;
        private string userInputString;

        //DROID VALUES
        private string modelType;
        private string materialType;
        private string paintColor;

        private int languageCount;

        private bool hasToolbox = false;
        private bool computerConnected = false;
        private bool hasArm = false;

        private bool hasTrashCompactor = false;
        private bool hasVacuum = false;

        private bool hasExtinguisher = false;
        private int shipCount;

        //MENU STRINGS
        private string modelTypesList = string.Format("1 - Protocol{0}2 - Utility{0}3 - Janitor{0}4 - Astromech{0}", Environment.NewLine);
        private string materialTypesList = string.Format("1 - Iron{0}2 - Bronzium{0}3 - Carbonite{0}4 - Duralium{0}5 - Quadranium{0}6 - Agrinium{0}7 - Gold{0}8 - Platinum{0}", Environment.NewLine);
        private string paintColorsList = string.Format("1 - None{0}2 - White{0}3 - Black{0}4 - Red{0}5 - Blue{0}6 - Green{0}7 - Yellow{0}8 - Gold{0}", Environment.NewLine);

        //OBJECTS
        private DroidCollector droidCollector = new DroidCollector();

        //CONSTRUCTOR
        public UserInterface()
        {   
            ShowMenu(); //DISPLAY USER INTERFACE MENU
        }

        //DISPLAYS USER INTERFACE MENU
        private void ShowMenu()
        {
            Console.WriteLine("{0}Select an option:{0}{0}1 - Add New Droid{0}2 - List All Droids{0}3 - Exit Droid Manager{0}", Environment.NewLine);

            try
            {
                GetUserInputInt();  //GET INPUT CHOICE FROM THE USER

            }
            catch
            {
                ThrowInputError();  //THROW AN ERROR WITH BAD INPUT
                ShowMenu();         //SHOW THE MENU AGAIN
            }

            switch (userInputInt)
            {
                case 1:
                    AddDroid();         //START THE PROCESS OF ADDING A DROID TO THE DROID LIST
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}Droid added successfully.",Environment.NewLine);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    ShowDroidList();    //DISPLAY THE LIST OF ADDED DROIDS
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0}Thank you for utilizing the Jawa Droid Manager!{0}", Environment.NewLine);
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);    //END THE PROGRAM
                    break;
                default:
                    ThrowInputError();
                    ShowMenu();
                    break;
            }

            ShowMenu();     //RECURSION LOOP -- REPEATS MAIN MENU
        }

        //DISPLAYS THE LIST OF ADDED DROIDS IN CYAN
        private void ShowDroidList()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(droidCollector.ShowDroidList());
            Console.ForegroundColor = ConsoleColor.White;
        }

        //BEGINS THE PROCESS OF ADDING A DROID TO THE DROID LIST
        private void AddDroid()
        {
            AssignDroidModel();         //GET THE DROID MODEL FROM THE USER
            AssignDroidMaterial();      //GET THE MATERIAL FROM THE USER
            AssignDroidColor();         //GET THE PAINT COLOR FROM THE USER
            AssignAdditionalFeatures(); //ASSIGN OTHER PROPERTIES DEPENDING ON DROID MODEL
        }

        //GETS THE DROID MODEL FROM THE USER
        private void AssignDroidModel()
        {
            Console.WriteLine("{0}Select a droid model:{0}{0}" + modelTypesList, Environment.NewLine);
            
            try
            {
                GetUserInputInt();
            }
            catch
            {
                ThrowInputError();
                AssignDroidModel();
            }

            switch (userInputInt)
            {
                case 1:
                    modelType = "Protocol"; break;
                case 2:
                    modelType = "Utility"; break;
                case 3:
                    modelType = "Janitor"; break;
                case 4:
                    modelType = "Astromech"; break;
                default:
                    ThrowInputError();
                    AssignDroidModel(); break;
            }
        }

        //GETS THE MATERIAL FROM THE USER
        private void AssignDroidMaterial()
        {

            Console.WriteLine("{0}Select a manufacturing material:{0}{0}" + materialTypesList, Environment.NewLine);

            try
            {
                GetUserInputInt();
            }
            catch
            {
                ThrowInputError();
                AssignDroidMaterial();
            }

            switch (userInputInt)
            {
                case 1:
                    materialType = "Iron"; break;
                case 2:
                    materialType = "Bronzium"; break;
                case 3:
                    materialType = "Carbonite"; break;
                case 4:
                    materialType = "Duralium"; break;
                case 5:
                    materialType = "Quadranium"; break;
                case 6:
                    materialType = "Agrinium"; break;
                case 7:
                    materialType = "Gold"; break;
                case 8:
                    materialType = "Platinum"; break;
                default:
                    ThrowInputError();
                    AssignDroidMaterial(); break;
            }
        }

        //GETS THE PAINT COLOR FROM THE USER
        private void AssignDroidColor()
        {
            Console.WriteLine("{0}Select a paint color:{0}{0}" + paintColorsList, Environment.NewLine);

            try
            {
                GetUserInputInt();
            }
            catch
            {
                ThrowInputError();
                AssignDroidColor();
            }

            switch (userInputInt)
            {
                case 1:
                    paintColor = "None"; break;
                case 2:
                    paintColor = "White"; break;
                case 3:
                    paintColor = "Black"; break;
                case 4:
                    paintColor = "Red"; break;
                case 5:
                    paintColor = "Blue"; break;
                case 6:
                    paintColor = "Green"; break;
                case 7:
                    paintColor = "Yellow"; break;
                case 8:
                    paintColor = "Gold"; break;
                default:
                    ThrowInputError();
                    AssignDroidColor(); break;
            }
        }

        //ASSIGNS OTHER PROPERTIES DEPENDING ON DROID MODEL
        private void AssignAdditionalFeatures()
        {
            switch (modelType)
            {
                case "Protocol":
                    AssignLanguageCount(); break;   //GET THE LANGUAGE COUNT FROM THE USER
                case "Utility":
                case "Janitor":
                case "Astromech":
                    AssignUtilityFeatures(); break; //ASSIGN MORE FEATURES FOR UTILITY DROIDS
            }
        }

        //GETS THE LANGUAGE COUNT FROM THE USER
        private void AssignLanguageCount() {
            Console.WriteLine("{0}How many languages are loaded? ", Environment.NewLine);

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                languageCount = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch
            {
                ThrowInputError();
                AssignLanguageCount();
            }

            //ADD THE FINISHED PROTOCOL DROID TO THE DROID LIST IN THE DROIDCOLLECTOR
            droidCollector.addDroid(modelType, materialType, paintColor, languageCount);
        }

        //ASSIGNS MORE FEATURES FOR UTILITY DROIDS
        private void AssignUtilityFeatures() {

            CheckForToolbox();              //ASK USER IF TOOLBOX IS INCLUDED
            CheckForComputerConnection();   //ASK USER IF COMPCONNECTION IS INCLUDED
            CheckForArm();                  //ASK USER IF ARM IS INCLUDED
            CheckAdditionalFeatures();      //CHECK IF OTHER FEATURES SHOULD BE INCLUDED (FOR SPECIFIC UTILITY DROIDS TYPES)
        }

        //ASKS USER IF TOOLBOX IS INCLUDED
        private void CheckForToolbox() {
            Console.WriteLine("{0}Is this droid equipped with a Toolbox? Y or N: ", Environment.NewLine);
            
            GetUserInputString();

            switch (userInputString)
            {
                case "Y":
                    hasToolbox = true; break;
                case "N":
                    hasToolbox = false; break;
                default:
                    ThrowInputError();
                    CheckForToolbox(); break;
            }
        }

        //ASK USER IF COMPCONNECTION IS INCLUDED
        private void CheckForComputerConnection() {
            Console.WriteLine("{0}Does this droid have a computer connection? Y or N: ", Environment.NewLine);

            GetUserInputString();

            switch (userInputString)
            {
                case "Y":
                    computerConnected = true; break;
                case "N":
                    computerConnected = false; break;
                default:
                    ThrowInputError();
                    CheckForComputerConnection(); break;
            }
        }

        //ASK USER IF ARM IS INCLUDED
        private void CheckForArm() {
            Console.WriteLine("{0}Is this droid equipped with an arm? Y or N: ", Environment.NewLine);

            GetUserInputString();

            switch (userInputString)
            {
                case "Y":
                    hasArm = true; break;
                case "N":
                    hasArm = false; break;
                default:
                    ThrowInputError();
                    CheckForArm(); break;
            }
        }

        //CHECKS IF OTHER FEATURES SHOULD BE INCLUDED (FOR SPECIFIC UTILITY DROIDS TYPES)
        private void CheckAdditionalFeatures() {

            switch (modelType)
            {
                case "Utility":
                    //ADD THE FINISHED UTILITY DROID TO THE DROID LIST IN THE DROIDCOLLECTOR
                    droidCollector.addDroid(modelType, materialType, paintColor, hasToolbox, computerConnected, hasArm);
                    break;
                case "Janitor":
                    CheckForTrashCompactor();   //ASK USER IF TRASH COMPACTOR IS INCLUDED
                    CheckForVacuum();           //ASK USER IF VACUUM IS INCLUDED
                    break;
                case "Astromech":
                    CheckForExtinguisher();     //ASK USER IF EXTINGUISHER IS INCLUDED
                    AssignShipCount();          //GET SHIP COUNT FROM THE USER
                    break;
            }
        }

        //ASKS USER IF TRASH COMPACTOR IS INCLUDED
        private void CheckForTrashCompactor() {
            Console.WriteLine("{0}Is this droid equipped with a trash compactor? Y or N: ", Environment.NewLine);

            GetUserInputString();

            switch (userInputString)
            {
                case "Y":
                    hasTrashCompactor = true; break;
                case "N":
                    hasTrashCompactor = false; break;
                default:
                    ThrowInputError();
                    CheckForTrashCompactor(); break;
            }
        }

        //ASKS USER IF VACUUM IS INCLUDED
        private void CheckForVacuum() {
            Console.WriteLine("{0}Is this droid equipped with a vacuum? Y or N: ", Environment.NewLine);

            GetUserInputString();

            switch (userInputString)
            {
                case "Y":
                    hasVacuum = true; break;
                case "N":
                    hasVacuum = false; break;
                default:
                    ThrowInputError();
                    CheckForVacuum(); break;
            }

            //ADD THE FINISHED JANITOR DROID TO THE DROID LIST IN THE DROIDCOLLECTOR
            droidCollector.addDroid(modelType, materialType, paintColor, hasToolbox, computerConnected, hasArm, hasTrashCompactor, hasVacuum);

        }

        //ASKS USER IF EXTINGUISHER IS INCLUDED
        private void CheckForExtinguisher() {
            Console.WriteLine("{0}Is this droid equipped with a fire extinguisher? Y or N: ", Environment.NewLine);

            GetUserInputString();

            switch (userInputString)
            {
                case "Y":
                    hasExtinguisher = true; break;
                case "N":
                    hasExtinguisher = false; break;
                default:
                    ThrowInputError();
                    CheckForExtinguisher(); break;
            }
        }

        //GETS SHIP COUNT FROM THE USER
        private void AssignShipCount() {
            Console.WriteLine("{0}How many ship models is this droid compatible with? ", Environment.NewLine);

            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                shipCount = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch
            {
                ThrowInputError();
                AssignShipCount();
            }

            //ADD THE FINISHED ASTROMECH DROID TO THE DROID LIST IN THE DROIDCOLLECTOR
            droidCollector.addDroid(modelType, materialType, paintColor, hasToolbox, computerConnected, hasArm, hasExtinguisher, shipCount);
        }

        //GET THE INPUT # CHOSEN BY THE USER
        private void GetUserInputInt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            userInputInt = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        //GET THE INPUT STRING CHOSEN BY THE USER
        private void GetUserInputString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            userInputString = Console.ReadLine().Trim().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
        }

        //THROW AN ERROR ON BAD INPUT IN RED
        private void ThrowInputError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}Invalid input.", Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;
        }

    } //END OF USERINTERFACE CLASS
} //END OF NAMESPACE
