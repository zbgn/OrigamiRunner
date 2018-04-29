using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    
    public bool isgrounded;

    // Use this for initialization
    void Start()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
        // Jump
        if (isgrounded && Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * 70, ForceMode2D.Impulse);
        }
    }

    void OnTriggerEnter2D(Collider2D theCollision)
    {
        if (theCollision.tag == "floor")
        {
            isgrounded = true;
        }
    }

    //consider when character is jumping .. it will exit collision.
    void OnTriggerExit2D(Collider2D theCollision)
    {
        if (theCollision.tag == "floor")
        {
            isgrounded = false;
        }
    }
}
