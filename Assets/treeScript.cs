using UnityEngine;
using System.Collections;

public class treeScript : MonoBehaviour
{

    // variables
    public int woodValue;               // Random number between 10 per height segment for now no 
    public int life;                    // this will start at 100, 0 is dead
    public GameObject gameManager;      // this should be handed the reference to the gamemanager 
    public GameObject woodPrefab;       // this should hold the prefab to the wood object
    public GameObject wood;             // the wood prefab will be made into this instance with the wood value correct
    public GameObject treeTopPrefab;    // this is the reference to the top part of the tree if this is a tall tree
    public GameObject treeTop;          // the actual gameobject if a tall tree
    public bool tallTree;               // this is for the tall tree
	// Use this for initialization
	void Start ()
    {
        // set the life to 100
        life = 100; // 100 

        // now that we know the wood value lets create the wood
        wood = Instantiate<GameObject>(woodPrefab);

        // set the wood value to the wood value of the tree
        wood.GetComponent<woodScript>().value = woodValue;

        // set the wood to inactive for later
        wood.SetActive(false);

        // set the position of the wood to the position of the tree
        wood.transform.position = transform.position;
        wood.transform.rotation = transform.rotation;

        // if gamemanager is not set find one
        if( gameManager == null )
        {
            Debug.Log("the gameManager is not set! in the treescript");
        }

        // if the tree this script is attached to is tall
        if( tallTree )
        {
            // this is a tallTree


        }


	}
	
	// Update is called once per frame
    /*
	void update()
    {
        // 
    }
    */

    // hurt function
    void hurt( int hitPoints )
    {
        // you have been hurt
        life = (life - hitPoints);

        // if the life of the rock is less than of equal to 0
        if(life <= 0)
        {

            // replace with wood
            wood.transform.position = transform.position;
            wood.transform.rotation = transform.rotation;
            wood.SetActive(true);

            // turn yourself off
            gameObject.SetActive(false);

        }

    }



}
