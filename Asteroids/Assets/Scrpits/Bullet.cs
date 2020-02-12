using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     Transform tf;

    public float bulletSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tf.position += tf.right * bulletSpeed * Time.deltaTime;
    }
}
