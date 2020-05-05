using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;

    private PlayerController player;

    public GameObject deathParticle;

    public float deathDelay;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();        
    }

    public void GameOver()
    {
        StartCoroutine("GameOverCo");
    }

    public IEnumerator GameOverCo()
    {
        Instantiate(deathParticle, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        Debug.Log("Game Over");
        yield return new WaitForSeconds(deathDelay);
        SceneManager.LoadScene("Player2Wins");
    }
}
