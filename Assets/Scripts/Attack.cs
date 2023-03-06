using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    
    public GameObject Rock;

    public bool delante;
    public bool detras;
    public bool izquierda;
    public bool derecha;

    public bool ataque;

    public bool Enemy_Area;


    void Start()
    {
        ataque = false;
    }

    void Update()
    {
        if(ataque == false && Enemy_Area == true)
        {
            if(Input.GetButtonDown("Fire1") && delante)
            {
                Rock.GetComponent<Rigidbody>().AddForce(-1000,0,0);
            }

            if(Input.GetButtonDown("Fire1") && detras)
            {
                Rock.GetComponent<Rigidbody>().AddForce(1000,0,0);        
            }

            if(Input.GetButtonDown("Fire1") && derecha)
            {
                Rock.GetComponent<Rigidbody>().AddForce(0,0,-1000);
            }

            if(Input.GetButtonDown("Fire1") && izquierda)
            {
                Rock.GetComponent<Rigidbody>().AddForce(0,0,1000);
            }
        }

        if(ataque == true  && Enemy_Area == true)
        {
            if(Input.GetButtonDown("Fire1") && delante)
            {
                Rock.GetComponent<Rigidbody>().AddForce(-2000,0,0);
            }

            if(Input.GetButtonDown("Fire1") && detras)
            {
                Rock.GetComponent<Rigidbody>().AddForce(2000,0,0);        
            }

            if(Input.GetButtonDown("Fire1") && derecha)
            {
                Rock.GetComponent<Rigidbody>().AddForce(0,0,-2000);
            }

            if(Input.GetButtonDown("Fire1") && izquierda)
            {
                Rock.GetComponent<Rigidbody>().AddForce(0,0,2000);
            }
        }

    }

    void OnTriggerStay(Collider Collider_1)
    {
        if(Collider_1.gameObject.name=="Up1"){
            delante = true;
        }
        if(Collider_1.gameObject.name=="Down1"){

            detras=true;
        }
        if(Collider_1.gameObject.name=="Left1"){

            derecha=true;
        }
        if(Collider_1.gameObject.name=="Right1"){

            izquierda=true;
        }

        if(Collider_1.gameObject.tag=="Enemy area"){
            Enemy_Area=true;
            Rock = Collider_1.gameObject;    

        }
    }

    void OnTriggerExit(Collider Collider_1)
    {
        if(Collider_1.gameObject.name=="Up1"){
            delante = false;
    
        }
        if(Collider_1.gameObject.name=="Down1"){

            detras=false;
            
        }
        if(Collider_1.gameObject.name=="Left1"){

            
            derecha=false;
        }
        if(Collider_1.gameObject.name=="Right1"){

            izquierda=false;
            
        }

         if(Collider_1.gameObject.tag=="Enemy area"){
            Enemy_Area=false;
        }

    }
}