using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string logMessage, string separator) => logMessage.Split(separator)[1];

    public static string SubstringBetween(this string logMessage, string lSeparator, string rSeparator){
        logMessage = logMessage.Split(lSeparator)[1];
        return logMessage.Split(rSeparator)[0];
    }
    
    public static string Message(this string logMessage) => logMessage.SubstringAfter(": ");

    public static string LogLevel(this string logMessage) => logMessage.SubstringBetween("[","]");
    
}