using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public bool isgrounded;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;
	private AudioSource fireSound;
  	private Animator	anim;
    // Use this for initialization
    void Start()
	{
    	anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (Time.timeScale == 0) {
			if (Input.anyKey) {
				Time.timeScale = 1;
				SceneManager.LoadScene (0);
			}
			return;
		}
		// Jump
		if (isgrounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0)))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * 70, ForceMode2D.Impulse);
        }

        // Shoot
		if ((Input.GetKeyDown(KeyCode.N) || Input.GetKeyDown(KeyCode.Mouse1)) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, new Quaternion(0,0,0,0));
			fireSound = shot.GetComponent<AudioSource> ();
			fireSound.Play ();
        }
    }

    void OnTriggerEnter2D(Collider2D theCollision)
    {
        if (theCollision.tag == "floor") {
            isgrounded = true;
		} else if (theCollision.tag == "Respawn" || theCollision.tag == "bat") {
          anim.SetBool("isDead", true);
          Time.timeScale = 0;
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
