using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
	float rotateSpeed;
	float moveSpeed;
	// Use this for initialization
	void Start () {
		float rand = Random.Range (-5.5f, 5.5f);
		Debug.Log (rand);
		transform.position = new Vector3(rand, -10, 0);
		rotateSpeed = Random.Range (-50, 50);
		moveSpeed = (float)(2.11 * (1.0 + Time.timeSinceLevelLoad/100.0));
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,0,Time.deltaTime * rotateSpeed);
		transform.Translate (new Vector3 (0, 1, 0) * Time.deltaTime * moveSpeed,Space.World);
		if(transform.position.y > 10)
		{
			Instantiate (this.gameObject);
			Destroy (this.gameObject);
		}
	}
}
