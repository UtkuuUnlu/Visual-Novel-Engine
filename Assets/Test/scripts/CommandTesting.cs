using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using COMMANDS;
public class CommandTesting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Running());

    }
    IEnumerator Running()
    {
        yield return CommandManager.instance.Execute("print");
        yield return CommandManager.instance.Execute("print_1p", "Hello world");
        yield return CommandManager.instance.Execute("print_mp", "Line1", "Line2", "Line3");

        yield return CommandManager.instance.Execute("lambda");
        yield return CommandManager.instance.Execute("lambda_1p", "Hello lambda!");
        yield return CommandManager.instance.Execute("lambda_mp", "Lambda1", "Lambda2", "Lambda3");

        yield return CommandManager.instance.Execute("process");
        yield return CommandManager.instance.Execute("process_1p", "3");
        yield return CommandManager.instance.Execute("process_mp", "Process Line 1", "Process Line 2", "Process Line 3");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            CommandManager.instance.Execute("MoveCharDemo", "left");
        else if (Input.GetKeyDown(KeyCode.RightArrow))
            CommandManager.instance.Execute("MoveCharDemo", "right");
    }
}
