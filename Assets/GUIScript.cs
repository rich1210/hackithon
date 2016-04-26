using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIScript : MonoBehaviour {

	public static int inventoryNum; 
	public static float threatVal; //Give it a value between 0 and 100.
	public static float healthVal; //Value between 0 - 100. 75 = 75 health left.
	public Scrollbar threatBar;
	public Scrollbar healthBar;
	//public Text healthTextObj;
	//public Text popUpTextObj;
	//public InputField userInputField;

	string playerName;
	bool userNameCollected; 

	// Use this for initialization
	void Start () 
	{
		inventoryNum = 1;
		threatVal = 0;
		healthVal = 100;
	}

	void onGUI()
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		threatBar.size = threatVal/100;
		healthBar.size = healthVal/100;
		
	}

	/*
	void popUpWindow(string popUpText)
	{

	}

	void getUserName()
	{
		userInputField.enabled;

		if (userInputField.OnSubmit) 
		{
			
		}
	}
	*/

}
