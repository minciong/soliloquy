using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
	protected int score = 0;
	public GameObject actorObject;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision(8,9); //don't let the  player layer collide with itself
		// Physics2D.IgnoreLayerCollision(0, 8); //don't allow the familiar to collide with terrain
	}

	// Update is called once per frame
	void Update () {
		// var v3 = Input.mousePosition;
		// v3 = Camera.main.ScreenToWorldPoint(v3);
		//Debug.Log(v3);

		scoreText.text = "SCORE: " + score;
	 }
	public void UpdateScore(int value){
		score+=value;
		PlayerPrefs.SetInt("score", score);

	}
	 void OnDestroy()
    {
        PlayerPrefs.SetInt("score", score); // save only OnDestroy, aka when going out of the scene
    }
	// public void UpdateHealth(int value){
	// 	witchCurrHealth = value;
	// }
	// public void UpdateMana(int value){
	// 	witchCurrMana = value;
	// }

}
