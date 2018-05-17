using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public float speed = 8f;
	public List<GameObject> enemy = new List<GameObject> ();

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
		//transform.Rotate(new Vector3(Time.deltaTime * 15f, 0, 0));
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "bat") {
			other.gameObject.SetActive(false);
		}
	}
}