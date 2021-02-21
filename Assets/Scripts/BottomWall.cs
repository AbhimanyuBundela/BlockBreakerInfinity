using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWall : MonoBehaviour
{
    public void PlaceWall()
    {
        this.gameObject.transform.position = new Vector3(8, -0.15f, 0);
        StartCoroutine(ResetWall(5));
    }

    IEnumerator ResetWall(float t)
    {
        yield return new WaitForSeconds(t);
        this.gameObject.transform.position = new Vector3(8, -8, 0);
    }
}
