using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Shoot _shootScript;

    void Start()
    {
        _shootScript = GameObject.FindObjectOfType<Shoot>();
    }

    void OnCollisionEnter2D (Collision2D collision) {
		// Ball does not trigger sound when brick is destoyed.
		// Not 100% sure why, possibly because brick isn't there.
		Vector2 tweak = new Vector2 (Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));

        if (_shootScript != null)
        {
            if (_shootScript.hasStarted)
            {
                GetComponent<AudioSource>().Play();
                GetComponent<Rigidbody2D>().velocity += tweak;
            }
        }
	}
}
