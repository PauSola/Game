using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texto : MonoBehaviour
{

    public Text texto;

    public bool no_text;
    
    void Start()
    {
        no_text = true;        

    }

    void Update()
    {
        if(no_text){
            texto.text="Muevete con las teclas WASD";
        }
    }

    private void OnTriggerEnter(Collider collider_1)
    {
        if(collider_1.gameObject.tag=="Enemy area"){
            texto.text = "Puedes disparar al enemigo con el click Izquierdo \n Contra mas mantengas mas fuerte dispararas";
            no_text = false;

        }

        if(collider_1.gameObject.name=="Portal_"){
            texto.text = "Entra al portal para teletransportarte";
            no_text = false;
        }


    }

    private void OnTriggerExit(Collider collider_1)
    {
        if(collider_1.gameObject.tag=="Enemy area"){
            texto.text="";
        }

        if(collider_1.gameObject.name=="Portal_"){
            texto.text="";
        }
    }

    private void OnCollisionStay(Collision collider_1){
        if(collider_1.gameObject.name=="Terra1"){
            texto.text = "Has desbloqueado el salto \n Salta con el Clic Derecho";
            no_text = false;
        }
    }
}
