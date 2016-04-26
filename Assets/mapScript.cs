using UnityEngine;
using System.Collections;

public class mapScript : MonoBehaviour {
   
    public int maxSizeX = 10,
               maxSizeY = 10;
    public GameObject mainTile;
    public static Sprite[] spritePannel = new Sprite[10];

    public static GameObject hightLighter;
    public static GameObject [,] floor1,
                    floor2;
    int x = 0,
        y = 0;
    


	// Use this for initialization
	void Start () {
        spritePannel = Resources.LoadAll<Sprite>("Map");
        hightLighter = (GameObject)Instantiate(mainTile, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        hightLighter.GetComponent<SpriteRenderer>().sprite = spritePannel[4];

        floor1 = floor2 = new GameObject[maxSizeX, maxSizeY];

        for (int y = 0; y < maxSizeY; y++)
        {
            for (int x = 0; x < maxSizeX; x++)
            {
                Vector3 pos = new Vector3(0.32f * x, 0.32f * -y, 1);
                //this is where we want to check our map array
                GameObject tempTile = (GameObject)Instantiate(mainTile, pos, Quaternion.Euler(0, 0, 0));
                tempTile.GetComponent<SpriteRenderer>().sprite = spritePannel[0];
                int index = ((y) + (x * 30));
                tempTile.name = index.ToString();
                tempTile.transform.parent = transform;
                floor1[x, y] = tempTile;
            }
        }

        // layer two of tiled map 
        for (int y = 0; y < maxSizeY; y++)
        {
            for (int x = 0; x < maxSizeX; x++)
            {
                Vector3 pos = new Vector3(0.32f * x, 0.32f * -y, -0.5f);
                //this is where we want to check our map array
                GameObject tempTile = (GameObject)Instantiate(mainTile, pos, Quaternion.Euler(0, 0, 0));
                tempTile.GetComponent<SpriteRenderer>().sprite = spritePannel[1];
                int index = ((y) + (x * 30));
                tempTile.name = index.ToString();
                tempTile.transform.parent = transform;
                floor2[x, y] = tempTile;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
