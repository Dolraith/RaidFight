using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour {
    //TODO: settings and disabling categories
    //TODO: settings file in general

    public  enum CATEGORY {BATTLE_INIT, BATTLE_RUNTIME, USER, DATA}
    private enum SEVERITY {INFO, WARNING, ERROR}

    /// <summary>
    /// Log an error message provided both the category and severity are enabled.
    /// </summary>
    /// <param name="cat">The category of the message.</param>
    /// <param name="message">The message to print.</param>
    public static void Error(CATEGORY cat, string message)
    {
        LogMessage(SEVERITY.ERROR, cat, message);
    }

    /// <summary>
    /// Log an informational message provided both the category and severity are enabled.
    /// </summary>
    /// <param name="cat">The category of the message.</param>
    /// <param name="message">The message to print.</param>
    public static void Info(CATEGORY cat, string message)
    {
        LogMessage(SEVERITY.INFO, cat, message);
    }

    /// <summary>
    /// Log a warning message provided both the category and severity are enabled.
    /// </summary>
    /// <param name="cat">The category of the message.</param>
    /// <param name="message">The message to print.</param>
    public static void Warning(CATEGORY cat, string message)
    {
        LogMessage(SEVERITY.WARNING, cat, message);
    }

    private static string GetTimestamp()
    {
        //TODO: timestamp formats / enable disable
        return System.DateTime.Now.ToShortDateString() + " | " + System.DateTime.Now.ToLongTimeString() + ": ";
    }

    /// <summary>
    /// Filter out the messages that shouldn't be logged, otherwsie tag 'em & bag 'em
    /// </summary>
    /// <param name="severity"></param>
    /// <param name="cat"></param>
    /// <param name="message"></param>
    private static void LogMessage(SEVERITY severity, CATEGORY cat, string message)
    {
        string timestamp = GetTimestamp();

        string finalMessage = timestamp + message;

        switch(severity)
        {
            case SEVERITY.INFO:
                Debug.Log(finalMessage);
                break;
            case SEVERITY.WARNING:
                Debug.LogWarning(finalMessage);
                break;
            case SEVERITY.ERROR:
                Debug.LogError(finalMessage);
                break;
        }
    }
}
