using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private Transform tf;
    public float movementSpeed = 1;
    public float speed = 1;

   // public Vector3 target = player.tf.position;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.enemiesList.Add(this.gameObject);

        tf = gameObject.GetComponent<Transform>();
        // Aim at the player at start
        // Vector3 directionToLook = target.position - tf.position; // Find the vector from us to the target
        // tf.right = directionToLook;                              // Set our local right to be the look vector
    }

    // Update is called once per frame
    void Update()
    {
        // Always move forward
        tf.position += tf.up * movementSpeed * Time.deltaTime;
    }

    void OnDestroy()
    {
        GameManager.instance.enemiesList.Remove(this.gameObject);
    }

    void OnCollisionEnter2D(Collision2D otherObject)
    {
        Debug.Log("[Collision Entered] The GameObject of the other object is named: " + otherObject.gameObject.name);

        Destroy(otherObject.gameObject);
        Destroy(this.gameObject);
    }
}
