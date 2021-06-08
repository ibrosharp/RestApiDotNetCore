using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommand()
        {
            var commands = new List<Command> 
            {
                new Command{Id=0, HowTo = "Boil an egg", Line = "new line",Platform = "Web"},
                new Command{Id =1, HowTo = "Boil an egg", Line = "new line",Platform = "Web"},
                new Command{Id =2, HowTo = "Boil an egg", Line = "new line",Platform = "Web"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id =0, HowTo = "Boil an egg", Line = "new line",Platform = "Web"};

        }
    }
}