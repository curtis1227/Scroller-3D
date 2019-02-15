using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour {

    void Reset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }
	// Use this for initialization
	void Start () {
	}
	
    void OnEnable()
    {
        this.transform.GetChild(0).gameObject.GetComponent<Button>().onClick.AddListener(Reset);
        this.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Game Over\nYour Score:\n" + Time.timeSinceLevelLoad.ToString("0.0");
    }

}
