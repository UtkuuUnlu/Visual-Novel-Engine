using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;

namespace TESTING
{
    public class TestingArchitect : MonoBehaviour
    {   
        DialogueSystem ds;
        TextArchitect architect;

        string[] lines = new string[5]
        {
            "Berke <3",
            "Minecraft oynamak ister misin?",
            "Skibidi!",
            "What the sigma ?",
            "GGs."

        };
        // Start is called before the first frame update
        void Start()
        {
            ds = DialogueSystem.instance;
            architect= new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.fade;
        }

        // Update is called once per frame
        void Update()
        {   
            string longLine = "This is a big rant about writing a big long line because I need to test the hurryup function to make sure if it works or not. why the fuck am i still writing this I dunno.asdasdasdasdasdas dasdasdasdasdasdasdda sdsdadsasdasdasdasd asddasdasdasdasdasdasddadasdasd asdasdasdasdasd";
            if (Input.GetKeyDown(KeyCode.Space))
                {
                    if(architect.isBuilding)
                    {
                        if(!architect.hurryUp)
                            architect.hurryUp = true;
                        else
                            architect.ForceComplete();
                    }
                    
                    else
                    architect.Build(lines[Random.Range(0,lines.Length)]);
                    //architect.Build(longLine);
                }

            else if (Input.GetKeyDown(KeyCode.A))
             {
                architect.Append(lines[Random.Range(0,lines.Length)]);
                //architect.Append(longLine);
             }
        }
    }
}