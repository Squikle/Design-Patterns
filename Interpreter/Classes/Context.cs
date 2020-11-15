using System.Collections.Generic;

namespace Interpreter.Classes
{
    class Context
    {
        private readonly Dictionary<string, double> _variables = new Dictionary<string, double>();

        public void SetVariable(string key, double variable)
        {
            _variables[key] = variable;
        }

        public double GetVariable(string key)
        {
            return _variables[key];
        }
    }
}