using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public GameObject Respawn1;
    public GameObject Respawn2;

    public GameObject Zona1;
    public GameObject Zona2;

    // Start is called before the first frame update
    void Start()
    {
        Zona1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider_1)
    {
        if(collider_1.gameObject.name=="Portal 2"){
            this.transform.position = Respawn1.transform.position;
            Zona1.SetActive(true);
            Zona2.SetActive(false);
        }

        if(collider_1.gameObject.name=="Portal 1"){
            this.transform.position = Respawn2.transform.position;
            Zona2.SetActive(true);
            Zona1.SetActive(false);
        }

    }


}
