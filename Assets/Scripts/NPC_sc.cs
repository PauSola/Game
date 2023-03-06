using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_sc : MonoBehaviour
{
    public bool rotate;

    public int x;
    
    void Start()
    {
        
    }

    void Update()
    {
        
        transform.Translate(2 * Time.deltaTime,0,0);
    
    }
    

    public void OnCollisionEnter(Collision collision_1)
    {
        if(collision_1.gameObject.tag=="Wall")
        {
            x = Random.Range(1,3);
            
            if(x == 1){
            transform.Rotate(0, 90, 0);
            }
            if(x == 2){
            transform.Rotate(0, 180, 0);
            }
            if(x == 3){
            transform.Rotate(0, 270, 0);
            }
        }
    }

    public void OnTriggerStay(Collider colliider_1)
    {
        if(colliider_1.gameObject.name=="Player")
        {
            
        }
    }

    // public void OnCollisionExit(Collision collision_1)
    // {
    //     if(collision_1.gameObject.tag=="Wall")
    //     {
    //         rotate = false;
    //     }
    // }
}
