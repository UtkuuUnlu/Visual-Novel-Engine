using System.Collections;
using System.Collections.Generic;
using DIALOGUE;
using UnityEngine;

namespace TESTING
{
public class TestParsing : MonoBehaviour
{
    [SerializeField] private TextAsset file;
    // Start is called before the first frame update
    void Start()
    {
        SendFileToParse();
        
    }

    void SendFileToParse()
    {
        List<string> lines = FileManager.readTextAsset(file,false);

        foreach(string line in lines)
        {   
            DIALOGUE_LINE dl = DialogueParser.Parse(line);
        }
    }
}
}