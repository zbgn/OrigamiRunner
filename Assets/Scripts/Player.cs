using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    
    public bool isgrounded;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

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

        // Shoot
        if (Input.GetKeyDown(KeyCode.N) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, new Quaternion(0,0,0,0));
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
