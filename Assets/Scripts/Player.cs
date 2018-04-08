using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public static Animator anim;
    public Transform checkFloor;
    public LayerMask Floor;

    public bool colidFloor = false;
	float sizeFloor = 0.3f;
	

	// Use this for initialization
	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate()
	{
		colidFloor = Physics2D.OverlapCircle(checkFloor.position, sizeFloor, Floor);
		anim.SetBool("floor", colidFloor);
	}
	
	// Update is called once per frame
	void Update ()
	{
        // Jump
        if (colidFloor && Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 225));
        }
    }
}
