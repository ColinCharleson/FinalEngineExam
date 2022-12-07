using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertCommand : ICommand
{
	public void Invert()
	{
		PlayerController.instance.invertValue = -1;
	}

}
