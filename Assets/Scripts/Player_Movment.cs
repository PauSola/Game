using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    private bool vertical;
    private bool horizontal;

    public bool floor;

    public bool salto;


    void Start()
    {
        salto = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W) && horizontal == false || Input.GetKey(KeyCode.S) && horizontal == false)
        {
            transform.Translate((-1)*Input.GetAxis("Vertical")*3 * Time.deltaTime,0,0);
            vertical = true;
            horizontal = false;
        }

        if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            vertical = false;
        }

        if(Input.GetKey(KeyCode.D) && vertical == false || Input.GetKey(KeyCode.A) && vertical == false)
        {
            horizontal = true;
            vertical = false;
            transform.Translate(0,0,Input.GetAxis("Horizontal")*3 * Time.deltaTime);
        }

        if(Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            horizontal = false;
        }

        if(Input.GetButtonDown("Fire2") && floor == true && salto == true)
        {
            this.GetComponent<Rigidbody>().AddForce(0,200,0);
        }

        // if(Input.GetKeyDown(KeyCode.RightArrow))
        // {
        //     vista.transform.LookAt(Right.transform);
        // }

        // if(Input.GetKeyDown(KeyCode.LeftArrow))
        // {
        //     vista.transform.LookAt(Left.transform);
        // }

        // if(Input.GetKeyDown(KeyCode.DownArrow))
        // {
        //     vista.transform.LookAt(Down.transform);
        // }

        // if(Input.GetKeyDown(KeyCode.UpArrow))
        // {
        //     vista.transform.LookAt(Up.transform);
        // }
    }

    public void OnCollisionStay(Collision collision_1)
    {
        if(collision_1.gameObject.tag=="floor")
        {
            floor = true;
        }

        if(collision_1.gameObject.name=="Terra1"){
            salto = true;
        }
    }

    public void OnCollisionExit(Collision collision_1)
    {
        if(collision_1.gameObject.tag=="floor")
        {
            floor = false;
        }
    }

    public void OnTriggerEnter(Collider collider_1)
    {
        if(collider_1.gameObject.name=="Plane")
        {
            this.transform.position= new Vector3(0.71f, 1.04f, -0.47f);
        }

        if(collider_1.gameObject.name=="Plane2")
        {
            this.transform.position= new Vector3(0.71f, 1.04f, 30);
        }

    }


}
