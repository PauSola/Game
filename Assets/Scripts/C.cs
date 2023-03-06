using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{
    public bool respawn;

    // Start is called before the first frame update
    void Start()
    {
        respawn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collider_1)
    {
        if(collider_1.gameObject.name=="Plane" && respawn)
        {
            this.transform.position= new Vector3(-2, 3, -1);
        }

        if(collider_1.gameObject.name=="Hole")
        {
            respawn = false;
        }

    }
}
