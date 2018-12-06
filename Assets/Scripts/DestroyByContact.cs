using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    public GameObject playerExplosion;
    public GameObject badGuyExplosion;

    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Boundary" && other.tag != "Bad Guy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            gameController.addScore(10);
            if (other.tag == "Player")
            {
                Instantiate(playerExplosion, other.transform.position, playerExplosion.transform.rotation);
                gameController.gameOver();
            }
            Instantiate(badGuyExplosion, transform.position, badGuyExplosion.transform.rotation);
        }
    }
}
