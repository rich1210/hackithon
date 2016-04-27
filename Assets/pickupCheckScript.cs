using UnityEngine;
using System.Collections;

public class pickupCheckScript : MonoBehaviour {

    private bool checking;
    private GameObject collidingObj;

	// Use this for initialization
	void Start () {
        checking = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(checking)
        {
            if ((collidingObj.transform.position.x + 1 ) <= (controllerScript.mouseX / 3) && (collidingObj.transform.position.x + 2) >= (controllerScript.mouseX / 3))
            {
                Debug.Log("in X rang");
                if ((collidingObj.transform.position.y + 1) >= (controllerScript.mouseY / 3) && (collidingObj.transform.position.y) <= (controllerScript.mouseY / 3))
                 {
                    objectScript.objSelect = true;
                    collidingObj.gameObject.GetComponent<SpriteRenderer>().color = new Color(0F, 0.95F, 1F, 1F);
                   
                }
                else
                {
                    objectScript.objSelect = false;
                    collidingObj.gameObject.GetComponent<SpriteRenderer>().color = new Color(1F, 1F, 1F, 1F);
                }
            }
            else
            {
                objectScript.objSelect = false;
                collidingObj.gameObject.GetComponent<SpriteRenderer>().color = new Color(1F, 1F, 1F, 1F);
            }
        }

        if(objectScript.objSelect)
        {
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Hit");
                collidingObj.SendMessage("hit", 25);
            }
        }
	
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "mining")
        {
            checking = true;
            collidingObj = other.gameObject;
        }
        
    }

    void OnTiggerExit2D(Collider2D other)
    {
        checking = false;
        Debug.Log("exiting");
    }
}
