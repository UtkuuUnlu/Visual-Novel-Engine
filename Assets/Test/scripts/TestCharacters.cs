using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CHARACTERS;
using DIALOGUE;

namespace TESTING
{
    public class TestCharacters : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //Character Elen = CharacterManager.instance.CreateCharacter("Elen");
            //Character Stella = CharacterManager.instance.CreateCharacter("Stella");
            //Character Stella2 = CharacterManager.instance.CreateCharacter("Stella");
            //Character Adam = CharacterManager.instance.CreateCharacter("Adam");
            StartCoroutine(Test());
        }
        IEnumerator Test()
        {
            Character Elen = CharacterManager.instance.CreateCharacter("Elen");
            Character Adam = CharacterManager.instance.CreateCharacter("Adam");
            Character Sarah = CharacterManager.instance.CreateCharacter("Sarah");
            List<string> lines = new List<string>()
            {
                "\"Hi!\"",
                "This is a line.",
                "And another.",
                "And a last one."
            };
            yield return Elen.Say(lines);
            lines = new List<string>()
            {
                "I am Adam",
                "This is a line.",
                "And another.",
                "And a last one."
            };
            yield return Adam.Say(lines);
            lines = new List<string>()
             {
                "I am Sarah",
                "This is a line.",
                "And another.",
                "And a last one."
            };
            yield return Sarah.Say(lines);
            Debug.Log("Finished");
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}