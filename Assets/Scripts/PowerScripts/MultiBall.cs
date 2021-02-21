using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBall : PowerUps
{
    public GameObject _ballPrefab;

    private Ball _ball;

    public override void ActivatePower()
    {
        _ball = GameObject.FindObjectOfType<Ball>();
        GameObject _ball1 = Instantiate(_ballPrefab, _ball.transform.position, Quaternion.identity);
        GameObject _ball2 = Instantiate(_ballPrefab, _ball.transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
