using UnityEngine;
using System.IO;

public class writeToLog : MonoBehaviour
{
    // Path for the log file
    private string logFilePath;

    private void Start()
    {
        // Define the path for the log file
        logFilePath = Application.persistentDataPath + "/logTESTING.txt";
    }

    public void WriteToLogFile(string message)
    {
        // Append the log message to the file
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine(message);
        }
    }
}
