using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        string message = "Whatever.";
        if (IsSilence(statement))
        {
           return message = "Fine. Be that way!";
        }
          if (IsYell(statement) && IsQuestion(statement) )
        {
           return message = "Calm down, I know what I'm doing!";
        }
        if (IsYell(statement))
        {
           return message = "Whoa, chill out!";
        }      

        if (IsQuestion(statement))
        {
            message = "Sure.";
        }
        
        return message;

        throw new NotImplementedException("You need to implement this function.");
  
    }   

          
        private static bool IsSilence(string message)
        {
            return string.IsNullOrWhiteSpace(message);
        }

        private static bool IsYell(string message)
        {
           // return message.ToUpper() == message;
           return message.Any(char.IsLetter) && message.ToUpperInvariant() == message;
        }


        private static bool IsQuestion(string message)
        {
            return message.TrimEnd().EndsWith("?");
        }
    
}