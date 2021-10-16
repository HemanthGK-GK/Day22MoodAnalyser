using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace UC6MoodAnalyser
{
    class MoodAnalyserFactory
    {
        private string message;
        public MoodAnalyserFactory(string message)
        {
            this.message = message;
        }



        // UC-5
        public static string InvokeAnalyserMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("Day20_MoodAnalyser_Test_Assignment.MoodAnalyser");
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyseParameterizedConstructor("Day20_MoodAnalyser_Test_Assignment.MoodAnalyser", "MoodAnalyser", message);
                MethodInfo analyseMoodInfo = type.GetMethod(methodName);
                object mood = analyseMoodInfo.Invoke(moodAnalyserObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new CException(CException.ExceptionType.no_such_method, "Method is Not Found");
            }
        }
    }
}
