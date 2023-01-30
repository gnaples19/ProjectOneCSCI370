using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Left : MonoBehaviour
{

    private Rigidbody2D rb2D;
        public float speed = 75f;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(transform.right * -180);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2D.transform.position.x < -8.75f) {
            Destroy(gameObject);
        }

         transform.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
