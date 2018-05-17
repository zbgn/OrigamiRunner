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
	}
}