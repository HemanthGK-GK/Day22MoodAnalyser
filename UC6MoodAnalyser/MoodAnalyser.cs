using System;
using System.Collections.Generic;
using System.Text;

namespace UC6MoodAnalyser
{
    class MoodAnalyser
    {
        string message;

        public MoodAnalyser()
        {
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {

            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CException(CException.ExceptionType.empty_message, "Mood should not be EMPTY");
                    throw new Exception();
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException e)
            {
                return e.Message;


            }
        }
    }
}
