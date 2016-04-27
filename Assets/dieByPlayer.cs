using UnityEngine;
using System.Collections;

public class dieByPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay2D(Collider2D other)
    {
       
        if (other.name == "MainCharacter")
        {
           if(gameObject.tag == "rocks")
            {
                gameObject.transform.position = new Vector3(100, 100, -6);
            }
        }

    }
}
