using UnityEngine;
using System.Collections;

public class collectionScr : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D(Collider2D other)
    {

        if (other.tag == "rocks")
        {
            inventoryScript.stone++;
        }

    }
}
