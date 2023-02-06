using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5f;
    private GameObject folcalPoint;

    private Rigidbody playerRB;
    private float vertical;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        folcalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");

        playerRB.AddForce(folcalPoint.transform.forward * speed * vertical);
    }
}
