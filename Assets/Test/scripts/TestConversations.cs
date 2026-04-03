using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;
public class TestConversations : MonoBehaviour
{
   [SerializeField] private TextAsset fileToRead = null;
    // Start is called before the first frame update
    void Start()
    {
        StartConversation();
        
    }

    void StartConversation()
    {
        List<string> lines = FileManager.readTextAsset(fileToRead);
        /*
       foreach (string line in lines)
        {
            if (string.IsNullOrEmpty(line))
        {
            continue;
        }
            
            DIALOGUE_LINE dlLine = DialogueParser.Parse(line);

            for(int i = 0; i<dlLine.commandData.commands.Count;i++)
            {
                DL_COMMAND_DATA.Command command = dlLine.commandData.commands[i];
                Debug.Log($"Command [{i}] '{command.name}' has arguments [{string.Join(", ", command.arguments)}]");
            }
        }
        */
       // debug log
        /*
        foreach (string line in lines)
        {
            if (string.IsNullOrEmpty(line))
        {
            continue;
        }
            Debug.Log($"Segmenting Line '{line}'");
            DIALOGUE_LINE dlLine = DialogueParser.Parse(line);

            int i = 0;
            foreach(DL_DIALOGUE_DATA.DIALOGUE_SEGMENT segment in dlLine.dialogue.segments)
            {
                Debug.Log($"Segment [{i++}] = '{segment.dialogue}' [signal={segment.startSignal.ToString()}{(segment.SignalDelay > 0 ? $" {segment.SignalDelay}" : $"")}]");
            }
        }
        */
        /*
        for(int i = 0; i<lines.Count; i++)
        {

            
            string line = lines[i];

            if (string.IsNullOrEmpty(line))
        {
            continue;
        }
            DIALOGUE_LINE dl = DialogueParser.Parse(line);

            Debug.Log($"{dl.speaker.name} as [{(dl.speaker.castName != string.Empty ? dl.speaker.castName : dl.speaker.name)}]at {dl.speaker.castPosition}");

            List<(int l, string ex)> expr = dl.speaker.CastExpressions;

            for (int c=0; c<expr.Count; c++)
            {
                Debug.Log($"[Layer[{expr[c].l}]= '{expr[c].ex}']");
            }
        }
        */
        
        DialogueSystem.instance.Say(lines);
    }
}
