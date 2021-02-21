using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMoveRight : MonoBehaviour
{
    private Paddle _paddle = null;

    void Start()
    {
        _paddle = GameObject.FindObjectOfType<Paddle>();
    }

    private void OnMouseDrag()
    {
        if (_paddle != null)
        {
            Vector3 paddlePos = new Vector3(_paddle.transform.position.x, _paddle.transform.position.y, 0f);
            paddlePos.x = _paddle.transform.position.x + _paddle.paddleSpeed * Time.deltaTime;
            _paddle.transform.position = paddlePos;
        }
    }
}
