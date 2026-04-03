using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileManager
{
    public static List<string> readTextFile(string filePath, bool includeBlankLines = true)
    {
        if(!filePath.StartsWith('/'))
            filePath = FilePaths.root+filePath;

        List<string> lines = new List<string>();
        try
        {
            using(StreamReader sr = new StreamReader(filePath))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (includeBlankLines || !string.IsNullOrWhiteSpace(line))
                        lines.Add(line);
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Debug.LogError($"File not found: '{ex.FileName}'");
        }
        return lines;
    }
    public static List<string> readTextAsset(string filePath, bool includeBlankLines = true)
    {
        TextAsset asset = Resources.Load<TextAsset>(filePath);
        if(asset == null)
        {
            Debug.LogError($"Asset not found '{filePath}'");
            return null;
        }
        return  readTextAsset(asset, includeBlankLines);
    }
    public static List<string> readTextAsset(TextAsset asset, bool includeBlankLines = true)
    {
        List<string> lines = new List<string>();
        using (StringReader sr = new StringReader(asset.text))
        {
            while(sr.Peek() > -1)
            {
                string line = sr.ReadLine();
                    if (includeBlankLines || !string.IsNullOrWhiteSpace(line))
                        lines.Add(line);
            }
        }
        return lines;
    } 
}
