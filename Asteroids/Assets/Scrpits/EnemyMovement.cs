using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour

{
    private Transform tform;
    public float EnemySpeed = 1.0f;
    void Start()
    {
        tform = gameObject.GetComponent<Transform>();
        GameManager.instance.enemiesList.Add(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        tform.position += tform.right * EnemySpeed * Time.deltaTime;
    }

    void OnDestroy()
    {
        //GameManager.instance.EnemyRespawn();
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
