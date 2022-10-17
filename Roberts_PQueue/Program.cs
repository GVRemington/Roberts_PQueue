// See https://aka.ms/new-console-template for more information
using Roberts_PQueue;
//Rayleen Roberts
//IT 113
//Notes: My first test with the hard codes comes out correctly all around
//       However, when I start using user input, they do not go according to plan
//       For example: if priority 1 is selected, the new patient will be placed
//                    between Fred Flintstone and Johny Quest. If I add 2 number 1s
//                    they will go between AND flipped backward.
//       If however, priority selection is 4 or higher,
//                   they all go in and come out correctly haha!!
//       I think that the problem is in my loop logic, not sure how, and using the 
//       debugger on a menu loop is proving to be daunting.
//Behaviors Not Implemented:
//       None that I know of....albeit my menu and menu loop logic are a bit buggy.
//                               




Emergency_Room ER = new Emergency_Room();

ER.addPatient("Mickey Mouse", 2);
ER.addPatient("Fred FlintStone", 1);
ER.addPatient("George Jetson", 2);
ER.addPatient("Barney Rubble", 3);
ER.addPatient("Johny Quest", 1);

//test print
Console.WriteLine("\n");
foreach (string patient in ER.patientList())
{
    Console.WriteLine(patient);
}
Console.WriteLine("\n If requeue was done correctly, Fred Flintstone should appear here => " + ER.testFiFo() + " <= success!");
//end of test print



Console.Write("\n\tTo Add New Patient Select 1...to List all Patients Select 2...if you wish to exit Select 3\t");
int selection = int.Parse(Console.ReadLine());

while (selection != 3)
{
    if (selection == 1)
    {
        Console.Write("\tPlease enter the patient's Full name\t\t");
        string newPat = Console.ReadLine();
        Console.Write("\tPlease Enter Priority Level\t\t");
        int priority = int.Parse(Console.ReadLine());

        ER.addPatient(newPat, priority);

        Console.Write("\n\tTo Add New Patient Select 1...to List all Patients Select 2...if you wish to exit Select 3\t");
        selection = int.Parse(Console.ReadLine());

    }
    if (selection == 2)
    {
        Console.WriteLine("\n");
        foreach (string patient in ER.patientList())
        {
            Console.WriteLine(patient);
        }
        Console.Write("\n\tTo Add New Patient Select 1...to List all Patients Select 2...if you wish to exit Select 3\t");
        selection = int.Parse(Console.ReadLine());

    }
}
if (selection == 3)
{
    Console.WriteLine("\n\tThis verifies that requeue was correct.  Fred Flintstone should appear here => " + ER.testFiFo() + " <= success!");
    Console.WriteLine("\n\tGood Bye");
}








