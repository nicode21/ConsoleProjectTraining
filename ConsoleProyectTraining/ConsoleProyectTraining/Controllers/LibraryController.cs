using DomainLayer.Entities;
using ServiceLayer.Helpers;
using ServiceLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProyectTraining.Controllers
{
    public class LibraryController
    {
        private readonly LibraryService _libraryService;


        public LibraryController()
        {
            _libraryService = new LibraryService();
        }

        public void Create()
        {
            try
            {
                ConsoleColor.DarkMagenta.WriteConsole("Add library name : ");

                string name = Console.ReadLine();

                ConsoleColor.DarkMagenta.WriteConsole("Add library seat count : ");

            SeatCount: string seatcountStr = Console.ReadLine();

                int seatcount;

                bool isParseSeatCount = int.TryParse(seatcountStr, out seatcount);

                if (isParseSeatCount)
                {

                    Library library = new()
                    {
                        Name = name,
                        SeatCount = seatcount,
                    };

                    //library =null;

                    var result = _libraryService.Create(library);

                    ConsoleColor.Green.WriteConsole($"Id : {result.Id}, Name : {result.Name}, SeatCount : {result.SeatCount}");


                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct seat count : ");
                    goto SeatCount;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            




        }

        public void GetById()
        {
            try
            {
                ConsoleColor.DarkMagenta.WriteConsole("Add library Id : ");

                id: string idStr = Console.ReadLine();

                int id;

                bool isParseId = int.TryParse(idStr, out id);

                if (isParseId)
                {
                    var result = _libraryService.GetById(id);

                    if (result is null)
                    {
                        ConsoleColor.Red.WriteConsole("Library not found, please try again : ");

                        goto id;
                    }

                    ConsoleColor.Green.WriteConsole($"Id : {result.Id}, Name : {result.Name}, SeatCount : {result.SeatCount}");


                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please add correct id : ");
                    goto id;
                }
            }
            catch (Exception ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
            }
        }
    }
}
