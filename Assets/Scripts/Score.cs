using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
	public Text ScoreText;

	private float timer;
	private int score;

	void Update() {
		if (Time.timeScale == 0) {
			if (ScoreText.text.StartsWith("Game Over\n")) return;
			ScoreText.text = "Game Over\n" + ScoreText.text;
			//ScoreText.transform.position = new Vector3 (0, -540, 0);
			return;
		}
		timer += Time.deltaTime;
		if (timer > 1f) {
			score += 1;
			ScoreText.text = "Score: "+score.ToString();
			timer -= 1;
		}
	}
}