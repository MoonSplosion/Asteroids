using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    private Transform tf;

    public float asteroidSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.enemiesList.Add(this.gameObject);
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tf.position += tf.right * asteroidSpeed * Time.deltaTime;
    }

    void OnDestroy()
    {
        GameManager.instance.enemiesList.Remove(this.gameObject);
    }

    void OnCollisionEnter2D(Collision2D otherObject)
    {
        
        if (otherObject.gameObject.name == "Player")
        {
            Destroy(otherObject.gameObject);
            Destroy(this.gameObject);

        }
    }
}
