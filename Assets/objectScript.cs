using UnityEngine;
using System.Collections;

public class objectScript : MonoBehaviour {
    public static bool objSelect = false;
    public static GameObject[] collectableItems = new GameObject[10];
    public GameObject mainItems;
	// Use this for initialization
	void Start ()
    { 
        for( int i = 0; i < 10; i++ )
        {
            collectableItems[i] = (GameObject)Instantiate(mainItems, new Vector3(100,100,-6), Quaternion.Euler(0, 0, 0));
            
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
