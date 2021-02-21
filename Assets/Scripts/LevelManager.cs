using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _brickCollections = new List<GameObject>();
    public List<GameObject> _bricks = new List<GameObject>();

	public void LoadLevel(string name)
    {
		//Debug.Log ("New Level load: " + name);
		Brick.breakableCount = 0;
		SceneManager.LoadScene (name);
	}

	public void QuitRequest()
    {
		//Debug.Log ("Quit requested");
		Application.Quit ();
	}
	
	public void LoadNextLevel()
    {
		Brick.breakableCount = 0;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    void Update()
    {
        if (Brick.breakableCount <= 0)
        {
            //LoadNextLevel();
            if (_brickCollections.Count > 0)
            {
                Instantiate(_brickCollections[Random.Range(0, _brickCollections.Count - 1)], Vector3.zero, Quaternion.identity);
            }
        }
    }

}
