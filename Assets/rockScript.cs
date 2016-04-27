using UnityEngine;
using System.Collections;

public class rockScript : MonoBehaviour {


    // variables
    public int stoneValue;         // the actual value of the stone this has after the randomizing
    public int life;            // the life should be 100 unless you hit it when 0 then it is stone not a rock
    private int index = 0;
  

	// Use this for initialization
	void Start ()
    {
        // set stone value
        stoneValue = 10;

        // life is set to 100
        life = 100;
        
	}
	

    void hit(int damage)
    {
        life = life - damage;

        Debug.Log(objectScript.collectableItems[0].gameObject.transform.position);

        if( life <= 0 )
        {
            if (checkOpenResource() >= 0)
            {
                int tempI = checkOpenResource();
                objectScript.collectableItems[tempI].gameObject.name = "rockItem";
                objectScript.collectableItems[tempI].gameObject.transform.position = transform.position;
                objectScript.collectableItems[tempI].gameObject.transform.position += new Vector3(0.5f, 0, 0);
            }
            else
            {
                Debug.Log("No Items Avaliable for Gabs");
            }

            if (checkOpenResource() >= 0)
            {
                int tempI = checkOpenResource();
                objectScript.collectableItems[tempI].gameObject.name = "rockItem1";
                objectScript.collectableItems[tempI].gameObject.transform.position = transform.position;
                objectScript.collectableItems[tempI].gameObject.transform.position += new Vector3(-0.5f, 0, 0);
            }
            else
            {
                Debug.Log("No Items Avaliable for Gabs");
            }

            // set the position of the stone
            transform.position += new Vector3(100,100,-6);

            life = 100;
        }
    }


    int checkOpenResource()
    {
        int index = -1;

        for( int i = 0; i < 10; i++)
        {
           if( objectScript.collectableItems[i].gameObject.transform.position.z == -6)
            {
                index = i;
            }
        }
        return index;
    }

    
}
