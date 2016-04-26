using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class inventoryScript : MonoBehaviour {
 
	public KeyCode relatedKey;
	public GameObject buttonRef;
	public GameObject guiManager;
	public Text textButton;

	//bool buttonColorToggle = false;
	int compareVal;
	string tempString;
	Event currentEvent;
	KeyCode currentKey;
	ColorBlock tempCB;
	Button tempBut; 
	string buttonName;
	int itemCount;
	bool ocupiedSpace;
	Text invenCount;
	Vector3 buttonPos; 
		 	
	// Use this for initialization
	void Start () 
	{
		buttonPos = Camera.main.WorldToScreenPoint(buttonRef.transform.position);
		tempBut = buttonRef.GetComponent<Button> ();
		tempCB = tempBut.colors;
		buttonName = buttonRef.name;
		ocupiedSpace = false;
		if(itemCount > 0)
			textButton.text = itemCount.ToString();
		else 
			textButton.text = "";
		setItemPick ("log", tempBut);
	}

	void OnGUI()
	{
		currentEvent = Event.current;

		if (currentEvent.isKey)
			currentKey = currentEvent.keyCode;
		else
			currentKey = KeyCode.Space;
	}

	void setItemPick(string spriteName, Button buttonObj)
	{
		//buttonObj.GetComponent<Sprite>() = (Texture)Resources.Load (spriteName);
	}

	void setInventoryNum(int invNum)
	{
		GUIScript.inventoryNum = invNum;
	}

	// Update is called once per frame
	void Update () 
	{
		if(true) //  UIBoolCheck) //Eventually to check if the GUI has controll of the Keyboard input. 
		{
			switch(currentKey)
			{
				case KeyCode.Alpha1:
				case KeyCode.Alpha2:
				case KeyCode.Alpha3:
				case KeyCode.Alpha4:
				case KeyCode.Alpha5:
				case KeyCode.Alpha6:
				case KeyCode.Alpha7:
				case KeyCode.Alpha8:
				case KeyCode.Alpha9:

				if (relatedKey ==  currentKey ) //|| buttonColorToggle) 
				{ 
					tempCB.normalColor = Color.red;
					tempBut.colors = tempCB;
					setInventoryNum ((buttonName [5])-48);
				} 
				else
				{
					tempCB.normalColor = Color.white;
					tempBut.colors = tempCB;
				}
					break;
			}

		}
			
	}
}
