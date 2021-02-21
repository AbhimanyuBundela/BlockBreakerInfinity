using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPower : PowerUps
{
    private BottomWall _bottomWall;

    public override void ActivatePower()
    {
        _bottomWall = GameObject.FindObjectOfType<BottomWall>();
        _bottomWall.PlaceWall();
        Destroy(this.gameObject);
    }
}
