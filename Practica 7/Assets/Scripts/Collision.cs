using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject poke;
    public GameObject InvPanel;
    public GameObject Inventory;
    void Start()
    {
        InvPanel.SetActive(false);

    }

    void Update()
    {


        if (Input.GetKeyUp(KeyCode.I))
        {

            InvPanel.SetActive(true);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered trigger");
        if (other.CompareTag("Pokeball"))
        {
            print("Colision de pokebola");
            Inventory.SetActive(true);
            //InvPanel.SetActive(true);
            //Destroy(poke);
        }
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log("Object is within trigger");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Object exited the trigger");
    }

    // void onCollisionEnter(Collision col)
    // {
    //     print(col.gameObject.name);
    //     if (col.gameObject.name == "Pikachu")
    //     {
    //         print("Pikachu capturado con collision");
    //     }
    // }
    // void OnTriggerEnter(Collider other)
    // {
    //     print(other.gameObject.name);


    //     if (other.gameObject.name == "Pikachu")
    //     {
    //         poke.SetActive(true);
    //         print("pikachu capturado");
    //     }
    //     if (other.gameObject.name == "Larvitar")
    //     {
    //         poke.SetActive(true);
    //         print("larvitar capturado");
    //     }
    //     print("Pokebola lanzada");
    // }


}

