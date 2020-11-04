using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
//        BoxCollider My = transform.GetComponent<BoxCollider>();
//        My.enabled = false;

        for (int i = 0; i < 4; i++)
        {
            Foo();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Foo()
    {
        Vector3 mov = Vector3.left;

        Rigidbody rgBdy = transform.GetComponent<Rigidbody>();
        rgBdy.AddForce(mov*speed);
    }
}
