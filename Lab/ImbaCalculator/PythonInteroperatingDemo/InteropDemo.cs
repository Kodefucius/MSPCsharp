using System;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace PythonInteroperatingDemo
{
    public class InteropDemo
    {
        private readonly ScriptEngine _scriptEngine;
        private ScriptScope _scope;

        public InteropDemo()
        {
            _scriptEngine = Python.CreateEngine();
            ScriptScope scriptScope = _scriptEngine.CreateScope();
        }

        public string ExecuteMethod(string method)
        {
            ScriptSource scriptSourceFromFile = _scriptEngine.CreateScriptSourceFromFile("script.py");
            _scope = _scriptEngine.CreateScope();
            dynamic execute = scriptSourceFromFile.Execute(_scope);
            Func<string> variable = _scope.GetVariable<Func<string>>(method);
            return variable();
        }
    }
}