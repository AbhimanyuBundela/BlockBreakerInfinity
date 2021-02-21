using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUps : MonoBehaviour
{
    public float _speed = 5f;
    // Start is called before the first frame update
    private Vector3 powerUpPosition;

    void Start()
    {
        powerUpPosition = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        powerUpPosition = this.transform.position;
        powerUpPosition.y -= _speed * Time.deltaTime;
        this.transform.position = powerUpPosition;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Debug.Log("Paddle Collided");
            ActivatePower();
        }
    }

    public abstract void ActivatePower();

}
