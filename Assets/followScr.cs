using UnityEngine;
using System.Collections;

public class followScr : MonoBehaviour {
	public GameObject followThis;
	public float speed = 3;
	Vector3 target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		target = followThis.transform.position;
		target.z = transform.position.z;
		transform.position = Vector3.MoveTowards (transform.position, target, speed * Time.deltaTime);
	}
}
