using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Hero" && Input.GetKeyDown(KeyCode.E))
        {
            collision.gameObject.GetComponent<Animator>().SetTrigger("openDoor");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
