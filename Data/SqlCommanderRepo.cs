using System.Collections.Generic;
using System.Linq;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public SqlCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommand()
        {
           return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            // return new Command{Id =0, HowTo = "Boil an egg", Line = "new line",Platform = "Web"};
            return _context.Commands.FirstOrDefault(p => p.Id == id);

        }
    }
}