using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {
    public GameObject GameOver;
	// Use this for initialization
	void Start () {
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth/2, Camera.main.pixelHeight * (float)(11/12.0), 14));
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) 
		{
			transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch (0).position.x, Camera.main.pixelHeight * (float)(11/12.0), 14));
		}
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Block")
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
