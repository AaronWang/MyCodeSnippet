using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using System;

namespace leetcode
{
    class Program
    {
        //    System.Reflection.Assembly myAssembly = Assembly.LoadFile("");
        //    myAssembly.ManifestModule.FindTypes()
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Type[] types = GetTypesInNamespace(Assembly.GetExecutingAssembly(), "Main");
            types = GetTypesByClassName(Assembly.GetExecutingAssembly(),"Solution");
            foreach (Type t in types)
            {
                // Console.WriteLine(t.Name);
                // Console.WriteLine(t.GetMethod("MainTest").Name);
                // Console.WriteLine(t.GetMethod("MainTest"));
                if (t.GetMethod("MainTest") != null)
                {
                    object obj = Activator.CreateInstance(t);
                    dynamic newObject = Convert.ChangeType(obj,t);
                    newObject.MainTest(null);
                    // obj.MainTest();
                }
            }
        }
        private static Type[] GetTypesByClassName(Assembly assembly,string className)
        {
            return
              assembly.GetTypes()
                      .Where(t => String.Equals(t.Name,className , StringComparison.Ordinal))
                      .ToArray();
        }
        private static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return
              assembly.GetTypes()
                      .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                      .ToArray();
        }
    }
}