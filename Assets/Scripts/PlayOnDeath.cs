using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlayOnDeath : MonoBehaviour
{
	void OnEnable()
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}
}