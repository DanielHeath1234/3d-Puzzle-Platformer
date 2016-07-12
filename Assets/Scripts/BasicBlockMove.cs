using UnityEngine;
using System.Collections;

public class BasicBlockMove : MonoBehaviour {

    public float moveSpeed = 0.01f;
    private bool dirforward = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        if(dirforward)
        {
            pos += transform.forward * moveSpeed;
        }
        else
        {
            pos -= transform.forward * moveSpeed;
        }
        transform.position = pos;    
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            this.dirforward = !this.dirforward;
        }     
    }
    //asana, trello, casual.pm
}
