using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamra : MonoBehaviour
{
    public float angle =15;
    private float horizontal;

    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up,angle*horizontal* Time.deltaTime);
    }
}
