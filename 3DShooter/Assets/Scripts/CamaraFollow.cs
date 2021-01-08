using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
    }

    /* 
    void Update()
    {
        
    }
    */
    void FixedUpdate()
    {
        Vector3 targetCameraPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCameraPosition, Time.deltaTime * smoothing);
    }
}
