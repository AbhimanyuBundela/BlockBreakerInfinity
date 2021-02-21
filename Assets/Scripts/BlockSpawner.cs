using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    private LevelManager _levelManager = null;
    // Start is called before the first frame update
    void Start()
    {
        _levelManager = GameObject.FindObjectOfType<LevelManager>();

        if (_levelManager != null)
        {
            float randomValue = Random.value;
            if (_levelManager._bricks.Count >= 4)
            {
                if (randomValue >= 0 && randomValue < 0.5f)
                    Instantiate(_levelManager._bricks[0], this.transform, false);
                else if (randomValue >= 0.5f && randomValue < 0.8f)
                    Instantiate(_levelManager._bricks[1], this.transform, false);
                else if (randomValue >= 0.8f && randomValue < 0.9f)
                    Instantiate(_levelManager._bricks[2], this.transform, false);
                else
                    Instantiate(_levelManager._bricks[3], this.transform, false);
            }

        }
    }

}
