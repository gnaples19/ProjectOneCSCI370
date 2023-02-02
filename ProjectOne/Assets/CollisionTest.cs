using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    public GameObject sparks;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        print("Entering Collision with asteroid");
        Instantiate(sparks);
        if (col.gameObject.tag == "Asteroid") {
            Destroy(col.gameObject);
            Instantiate(sparks);
            //GameManager.Instance.IncScore(1);
        }
    }
}
