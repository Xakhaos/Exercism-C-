using System;

public static class LogAnalysis 
{
public static string SubstringAfter(this string log, string delimiter)
    {
        
        return log.Substring(log.IndexOf(delimiter) + delimiter.Length);
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
public static string SubstringBetween(this string log, string firstDelimiter, string secondDelimiter)
{
    string log2 = log.Substring(log.IndexOf(firstDelimiter) + firstDelimiter.Length);
    return log2.Remove(log2.IndexOf(secondDelimiter));
}    
    // TODO: define the 'Message()' extension method on the `string` type
public static string Message(this string mensagem)
{
    return mensagem.Substring(mensagem.IndexOf(": ")+2);
}
    // TODO: define the 'LogLevel()' extension method on the `string` type
public static string LogLevel(this string mensagem)
{
    return mensagem.Substring(mensagem.IndexOf("[")+1,mensagem.IndexOf("]")-1);
}
}