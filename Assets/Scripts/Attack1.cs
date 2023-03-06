using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1 : MonoBehaviour
{
    
    public GameObject bullet;

    public bool Right;
    public bool Left;
    public bool Up;
    public bool Down;

    public bool ataque;

    public float force = 1000;
    public float mass;

    void Start()
    {
        ataque = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Right = true;
            Left = false;
            Down = false;
            Up = false;
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            Right = false;
            Left = true;
            Down = false;
            Up = false;
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            Right = false;
            Left = false;
            Down = true;
            Up = false;
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            Right = false;
            Left = false;
            Down = false;
            Up = true;
        }
        
        if(Input.GetButton("Fire1") && bullet.GetComponent<Rigidbody>().mass <= 8){
            bullet.GetComponent<Rigidbody>().mass += 0.05f;
            bullet.transform.localScale += new Vector3(0.003f, 0.003f, 0.003f) ;
            force += 50;
        }
        
        if(Input.GetButtonUp("Fire1"))
        {
            
            if(Up){
                GameObject bala_pref = Instantiate(bullet, transform.position + new Vector3(-0.1f ,0 ,0), Quaternion.identity);
                bala_pref.GetComponent<Rigidbody>().AddForce(new Vector3((-1)*force, 0, 0));
                Destroy(bala_pref,1);
            }

            if(Down){
                GameObject bala_pref = Instantiate(bullet, transform.position + new Vector3(0.1f ,0 ,0), Quaternion.identity);
                bala_pref.GetComponent<Rigidbody>().AddForce(new Vector3(force, 0, 0));
                Destroy(bala_pref,1);
            }

            if(Right){
                GameObject bala_pref = Instantiate(bullet, transform.position+ new Vector3(0 ,0 ,0.1f), Quaternion.identity);
                bala_pref.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, force));
                Destroy(bala_pref,1);
            }

            if(Left){
                GameObject bala_pref = Instantiate(bullet, transform.position+ new Vector3(0 ,0 ,-0.1f), Quaternion.identity);
                bala_pref.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, (-1)*force));
                Destroy(bala_pref,1);
            }
            force = 1000;
            bullet.GetComponent<Rigidbody>().mass = 1;
            bullet.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f) ;
            
        }
        

    }
    
}