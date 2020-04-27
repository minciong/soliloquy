using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOverController : MonoBehaviour {

	// Use this for initialization
	public Text scoreText;
	void Start () {
		Invoke("GoBackToStart", 5);
		scoreText.text = "Game Over! Final Score: \n" + PlayerPrefs.GetInt("score").ToString();
		Debug.Log(PlayerPrefs.GetInt("score").ToString());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void GoBackToStart(){
		SceneManager.LoadScene("IntroScene");
	}
}
