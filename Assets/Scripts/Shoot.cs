using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Ball _ball = null;
    private Paddle _paddle = null;
    private Vector3 _paddleToBallVector;

    public bool hasStarted = false;

    void Start()
    {
        _ball = GameObject.FindObjectOfType<Ball>();
        _paddle = GameObject.FindObjectOfType<Paddle>();
        _paddleToBallVector = _ball.transform.position - _paddle.transform.position;      
    }

    void Update()
    {
        if (!hasStarted)
        {
            _ball.transform.position = _paddle.transform.position + _paddleToBallVector;
        }
    }

    private void OnMouseDown()
    {
        if (_ball != null && !hasStarted)
        {
            print("Mouse clicked, launch ball");
            hasStarted = true;
            _ball.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
    }
}
