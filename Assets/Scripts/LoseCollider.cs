using UnityEngine;

public class LoseCollider : MonoBehaviour
{

	private LevelManager levelManager;
	
	void OnTriggerEnter2D (Collider2D trigger)
    {
        if (trigger.CompareTag("Ball"))
        {
            levelManager = GameObject.FindObjectOfType<LevelManager>();
            levelManager.LoadLevel("Lose Screen");
        }
        if (trigger.CompareTag("PowerUps"))
        {
            Debug.Log("PowerUp!");
            Destroy(trigger.gameObject);
        }
    }
	
	void OnCollisionEnter2D (Collision2D collision)
    {
		print ("Collision");	
	}
	
}
