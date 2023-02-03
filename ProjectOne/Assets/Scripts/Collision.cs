using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{

    IEnumerator FreezeForSeconds() {
        yield return new WaitForSeconds(5f);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Asteroid") {
            Invoke("Restart", 0.1f);
        }
    }

    void Restart() {
        StartCoroutine(FreezeForSeconds());
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
