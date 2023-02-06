using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 4;

    private GameObject player;
    private Rigidbody enemyRB;


    // Start is called before the first frame update
    void Start()
    {
        enemyRB= GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerDirection = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(playerDirection*speed);


        if (transform.position.y < -6)
            Destroy(this.gameObject);
        
    }

   
}
