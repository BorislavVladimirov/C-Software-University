using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core.Contracts
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string CommandConst = "Command";
        public string Read(string args)
        {
            string[] array = args.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string commandName = array[0] + CommandConst;
            string[] commandArgs = array.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();
            Type[] types = assembly.GetTypes();
            Type typeToCreate = types.FirstOrDefault(t => t.Name == commandName);

            //if (typeToCreate == null)
            //{
                //throw new InvalidOperationException("Invalid Command Type!");
            //}

            Object instance = Activator.CreateInstance(typeToCreate);
            ICommand command = (ICommand)instance;
            string result = command.Execute(commandArgs);
            return result;
        }
        
    }
}
