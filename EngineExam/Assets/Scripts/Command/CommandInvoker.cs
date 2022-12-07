using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{

    static Queue<ICommand> commandBuffer;
    static List<ICommand> commandHistory;

    static int counter;

    // Start is called before the first frame update
    void Start()
    {
        commandBuffer = new Queue<ICommand>();
        commandHistory = new List<ICommand>();
    }

    public void InvertCommand()
    {
        PlayerController.instance.invertValue = -1;
        counter++;
        while (commandHistory.Count > counter)
        {
            commandHistory.RemoveAt(counter);
        }
            
	}

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.lives == 1)
		{
            InvertCommand();
		}

        if(commandBuffer.Count >0)
		{
            ICommand c = commandBuffer.Dequeue();

            commandHistory.Add(c);
            counter++;
            Debug.Log("Command history length is " + commandHistory.Count);
		}
    }
}
