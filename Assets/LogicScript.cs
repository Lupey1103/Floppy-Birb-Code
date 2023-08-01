using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;
   public GameObject gameOverScreen;
   public AudioSource point;

    [ContextMenu("Increase Score")]
   public void addScore(int scoreToAdd)
   {
    playerScore = playerScore + scoreToAdd;
    scoreText.text = playerScore.ToString();
   }

   public void restartGame()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void gameOver()
   {
    gameOverScreen.SetActive(true);
   }

   private void OnTriggerEnter(Collider other)
{
   if (other.CompareTag("Player"))
      GetComponent<AudioSource>().Play();
}
}
