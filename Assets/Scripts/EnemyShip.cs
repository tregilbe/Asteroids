using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    private Transform tf;
    public float movementSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.enemiesList.Add(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // Adjust rotation every update for heat seeking behaviour
    
        // Always fly forward
        tf.position += tf.right * movementSpeed * Time.deltaTime;
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
