using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text scoreText;
	public Text cakeText;

	public int cakeHealth = 20;
	public int score = 0;

	public void LoseCake(int l = 1){
		cakeHealth -= l;
		if (cakeHealth <= 0) {
			//fim do jogo
			GameOver();
		}
	}

	public void GameOver(){
		print ("Game Over");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	void Update(){
		scoreText.text = "Score: " + score.ToString();
		cakeText.text = "Cake: " + cakeHealth.ToString();
	}
}
