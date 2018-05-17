using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour
{
    public float speed = 8f;

    void Start()
    {
    }
	
	void Update()
	{
		Move();
	}
	
	void Move()
	{
		transform.Translate(speed * Time.deltaTime, 0, 0);
		transform.Rotate(new Vector3(Time.deltaTime * 15f, 0, 0));
	}

	void OnTriggerEnter2D(Collider2D theCollision)
    {
        if (theCollision.tag == "bat")
        {
			Destroy(theCollision.gameObject);
			GameController.instance.RunnerScored(3);			
        }
    }
}