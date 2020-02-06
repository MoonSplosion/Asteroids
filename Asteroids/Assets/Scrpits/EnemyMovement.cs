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
    }
    // Update is called once per frame
    void Update()
    {
        tform.position += tform.right * EnemySpeed * Time.deltaTime;
    }

    void OnDestroy()
    {
        GameManager.instance.EnemyRespawn();
    }
}
