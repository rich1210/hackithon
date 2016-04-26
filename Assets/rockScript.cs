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

        if( life <= 0 )
        {
          // while(objectScript.collectableItems[index].gameObject.transform.position.y != -6 )
           // {
            //    index++;
           // }
            objectScript.collectableItems[0].gameObject.name = "rockItem";
            objectScript.collectableItems[0].gameObject.transform.position = transform.position;
            objectScript.collectableItems[0].gameObject.transform.position += new Vector3(0.5f, 0, 0);
            //index = 0;

            //while (objectScript.collectableItems[index].gameObject.transform.position.y != -6)
           // {
            //    index++;
           // }
            objectScript.collectableItems[1].gameObject.name = "rockItem1";
            objectScript.collectableItems[1].gameObject.transform.position = transform.position;
            objectScript.collectableItems[1].gameObject.transform.position += new Vector3(-0.5f, 0, 0);
            //index = 0;
            
            // set the position of the stone
            transform.position += new Vector3(100,100,10);

            
        }
    }




}
