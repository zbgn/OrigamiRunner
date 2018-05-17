using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour
{
    public float speed = 8f;
	private AudioSource sound;

    void Start()
    {
		sound = GetComponent<AudioSource> ();
		sound.Play ();
    }
	
	void Update()
	{
		Move();
	}
	
	void Move()
	{
		transform.Translate(speed * Time.deltaTime, 0, 0);
	}
}