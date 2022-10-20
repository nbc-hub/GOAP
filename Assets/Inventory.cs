using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public int flourLevel = 5;
	public int breadLevel = 0;
	public int offSet=0;
	public int delivaryLevel=0;
	public string guiName;
	
	void OnGUI()
	{
		GUI.Box(new Rect(0, 0+offSet, 100, 100), guiName);
		GUI.Label(new Rect(10, 20+offSet, 100, 20), "Flour: " + flourLevel);
		GUI.Label(new Rect(10, 35+offSet, 100, 20), "Bread: " + breadLevel);
		GUI.Label(new Rect(10, 50+offSet, 100, 20), "Delivary: " + delivaryLevel);
	}
}
