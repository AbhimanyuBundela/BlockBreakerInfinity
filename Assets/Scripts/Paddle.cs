using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	public float minX, maxX;
    public float paddleSpeed = 2f;

	private Ball ball;
	
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
		
	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
            ClampPaddlePosition();
        } else {
			AutoPlay();
		}
	}
	
	void AutoPlay() {
		Vector3 paddlePos = new Vector3 (0.5f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, minX, maxX);
        this.transform.position = paddlePos;
    }

    void ClampPaddlePosition()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
        paddlePos.x = Mathf.Clamp(this.transform.position.x, minX, maxX);
        this.transform.position = paddlePos;
    }

    public void IncreaseSize()
    {
        this.transform.localScale = new Vector3(2, 1, 1);
        StartCoroutine(RestoreSize(4));
    }

    IEnumerator RestoreSize(float t)
    {
        yield return new WaitForSeconds(t);
        this.transform.localScale = new Vector3(1, 1, 1);
    }

    public void DecreaseSize()
    {
        this.transform.localScale = new Vector3(0.5f, 1, 1);
        StartCoroutine(RestoreSize(4));
    }

}
