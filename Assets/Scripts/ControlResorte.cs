using UnityEngine;
using System.Collections;

public class ControlResorte : MonoBehaviour {
    Animator Anim;

	// Use this for initialization
	void Start () {
        Anim = GetComponent<Animator> ();
	}
	
    void OnCollisionEnter(Collision collision)
    {
        Anim.Play("Base Layer.Presionboton");
        }

    }
