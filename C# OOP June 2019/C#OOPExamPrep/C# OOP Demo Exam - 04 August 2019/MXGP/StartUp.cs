using System;

namespace MXGP
{
    using MXGP.Core;
    using MXGP.Core.Contracts;
    using MXGP.IO;
    using MXGP.IO.Contracts;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Races.Contracts;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Repositories;
    using MXGP.Repositories.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IChampionshipController championshipController = new ChampionshipController();

            IReader consoleReader = new ConsoleReader();
            IWriter consoleWriter = new ConsoleWriter();

            IEngine engine = new Engine(consoleReader, consoleWriter, championshipController);

            engine.Run();
        }
    }
}
