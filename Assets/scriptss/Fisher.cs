using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
public class DialogueReader : MonoBehaviour
{
    public TextAsset Dialogue;
    private int currentLine;
    private int currentChar;
    private int lineLimit = 10;
    void LoadResources()
    {
        
    }
    private string[] allLines;
    private int lineLength;
    void ReadLine()
    {
       
        if (currentChar == lineLength)
        {
           
            NextLine();
        }
        Debug.Log(lineLength);
        Debug.Log(currentChar);
        if (currentChar + lineLimit >= lineLength) { rawSubstring = allLines[currentLine].Substring(currentChar, currentChar + lineLimit); currentChar = lineLength; }
        else { rawSubstring = allLines[currentLine].Substring(currentChar, currentChar + lineLimit); currentChar += lineLimit; }
        FormatSubString();
        Debug.Log(formattedSubString);
    }
    string rawSubstring;
    string formattedSubString;
    {
        if (rawSubstring.StartsWith("Fisher"))
        {
            rawSubstring.Remove(0);
        }
        formattedSubString = rawSubstring;
    }
    void NextLine()
    {

        currentChar = 0;
        if (allLines[currentLine + 1] != "Fisher")
        {
            Debug.Log("Passes");
            currentLine++;
        }
        else
        {
            EndDialogue();
        }
        lineLength = allLines[currentLine].Length;
    }
    void CompileLines()
    {
        currentLine = 0;
        currentChar = 0;
        for (int i = 0; i < allLines.Length; i++)
        { Debug.Log(allLines[i]); }
        lineLength = allLines[currentLine].Length;
    }
    void EndDialogue()
    {
        Debug.Log("End");
    }
    private void Start()
    {
        CompileLines();
    }
    public void Next()
    {
        ReadLine();
    }
}


