using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace UC5MoodAnalyser
{
    class MoodAnalyserFactory
    {
        private string message;
        public MoodAnalyserFactory(string message)
        {
            this.message = message;
        }

       

        // UC-5
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new CException(CException.ExceptionType.no_such_class, "Class not found");
                    throw new CException(CException.ExceptionType.no_such_method, "Constructor is not found");
                }
            }
            else
            {
                throw new CException(CException.ExceptionType.no_such_class, "Class not found");

            }
        }
    }
}
