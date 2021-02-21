using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSizeIncrease : PowerUps
{
    private Paddle _paddle;

    public override void ActivatePower()
    {
        _paddle = GameObject.FindObjectOfType<Paddle>();
        _paddle.IncreaseSize();
        Destroy(this.gameObject);
    }

}
