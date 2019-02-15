using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {
	public GameObject Block;
	public TextMesh TimerText;
	int intthisSec = 0;
	// Use this for initialization
	void Start () {
		Instantiate (Block);
	}
	
	// Update is called once per frame
	void Update () {
		TimerText.text = Time.timeSinceLevelLoad.ToString("0.0");
		if((int)Time.timeSinceLevelLoad % 10 == 0 && (int)Time.timeSinceLevelLoad != intthisSec)
		{
			intthisSec = (int)Time.timeSinceLevelLoad;
            Instantiate (Block);
		}
	}
}