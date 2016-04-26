using UnityEngine;
using System.Collections;

public class setTileColor : MonoBehaviour {
    int counter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        counter++;

        if (counter > 5)
        {
            GetComponent<SpriteRenderer>().color = new Color(1F, 1F, 1F, 1F);
            counter = 0;
        }
        
    }
}
