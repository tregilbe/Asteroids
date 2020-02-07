using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : MonoBehaviour
{
    private Transform tf;

    public float movementSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        tf = gameObject.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        tf.position += Vector3.down * movementSpeed * Time.deltaTime;
    }
}
