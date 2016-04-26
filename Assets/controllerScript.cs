using UnityEngine;
using System.Collections;

public class controllerScript : MonoBehaviour {
	public float speed = 1.5f;
	private Vector3 target;
    public static int mouseX, 
        mouseY,
        playerX,
        playerY;
    public static float rawMouseX;
    float camCurrentPos;
    public float scrollSpeed = 0.5f;

    Vector2 mousePosition;

    // Use this for initialization
    void Start () {
		target = transform.position;
        camCurrentPos = Camera.main.orthographicSize;

    }

	// Update is called once per frame
	void Update () {

        camCurrentPos += (Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);
        Camera.main.orthographicSize = camCurrentPos;

            target = Input.mousePosition;
            rawMouseX = target.x;
			target.z = 2.8f;
			target = Camera.main.ScreenToWorldPoint (target);

            mouseX = (int)(target.x / 0.32f);
            mouseY = (int)(target.y / 0.32f);
 

            playerX = (int)(transform.position.x / 0.32f);
            playerY = (int)(transform.position.y / 0.32f);


       
       
        if (inRange())
        {
            mapScript.floor2[mouseX, -mouseY].GetComponent<SpriteRenderer>().color = new Color(0F, 0.95F, 1F, 1F);
        }
        else
        {
            mapScript.floor2[mouseX, -mouseY].GetComponent<SpriteRenderer>().color = new Color(1F, 1F, 1F, 1F);
        }
        

        if (Input.GetMouseButton(0))
        {
            // if in range of object
            if (objectScript.objSelect)
            {
            }
            else
            {
                if (inRange())
                {
                    mapScript.floor2[mouseX, -mouseY].GetComponent<SpriteRenderer>().sprite = mapScript.spritePannel[2];

                    //Debug.Log(mapScript.floor2[mouseX, -mouseY].name);
                }
            }
        }
       

        //mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
       
        /*
        target.z = 0.8f;
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
	    */



        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

   
    private bool inRange()
    {
        //Debug.Log((playerPos - 1) + "  " + mousePos + " " + (playerPos + 1));
        if ((mouseX -2 ) <= playerX && (mouseX ) >= playerX)
        {
         
            if ((mouseY ) <= playerY  && (mouseY + 2) >= playerY)
            {
                return true;
            }
            else
            {
                return false;
            }
          
            //return true;
            
           
        }
        else
        {
            return false;
        }
    }
    
}
