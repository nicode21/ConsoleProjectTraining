





using ConsoleProyectTraining.Controllers;
using ServiceLayer.Helpers;

LibraryController libraryController = new ();



while (true)
{

    ConsoleColor.Blue.WriteConsole("Select one option : ");
    ConsoleColor.Blue.WriteConsole("Library Options : 1 - Create , 2 - Get by id , 3 - Delete");


SelectOption: string option = Console.ReadLine();

    int selectedOption; //4

    bool isParseOption = int.TryParse(option, out selectedOption);


    if (isParseOption)
    {
        switch (selectedOption)
        {
            case 1:
                libraryController.Create();
                break;
            case 2:
                libraryController.GetById();
                break;
            case 3:
                Console.WriteLine("Delete");
                break;
            default:
                ConsoleColor.Red.WriteConsole("Select again true option : ");
                goto SelectOption;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Select again true option : ");
        goto SelectOption;
    }
}

