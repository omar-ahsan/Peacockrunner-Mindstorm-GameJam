using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    ThiefMovement tm;
    public GameObject script;
    private void Start()
    {
        
    }

    private void Update()
    {
        if(GetComponent<Points>().points == 20 && tm.thiefSpeed >= 0)
        {
            tm.thiefSpeed = tm.thiefSpeed - 0.1f;
            Debug.Log("Thief speed reduced");

            
        }

       
    }

    private void Awake()
    {
        tm = script.GetComponent<ThiefMovement>();
    }
    private void OnTriggerEnter(Collider Col)
    {
        
        if(Col.gameObject.tag == "Feather")
        {
            GetComponent<Points>().points++; // Add 1 Point
            Col.gameObject.SetActive(false);
        }
    }
}
