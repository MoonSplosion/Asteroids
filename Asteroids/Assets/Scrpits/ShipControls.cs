using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{
    private Transform tf;
    public float rotationSpeed = 1.0f;
    public float shipSpeed = 1.0f;
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += tf.right * shipSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0,0,-rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0,0,rotationSpeed * Time.deltaTime);
        }
    }

    public void Shoot()
    {
        throw new NotImplementedException();
    }

    void OnCollisionEnter2D(Collision2D otherObject)
    {

    }

    void OnCollisionExit2D(Collision2D otherObject)
    {

    }

    void OnDestroy()
    {
        // If the Player dies, they lose a life.
        GameManager.instance.lives -= 1;
        if (GameManager.instance.lives > 0)
        {
            GameManager.instance.Respawn();
        }
        else
        {
            Debug.Log("Game Over");
        }
    }
}
