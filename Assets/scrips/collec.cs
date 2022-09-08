using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collec : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == "PickUp")
        {
            // Do something  
            Destroy(col.gameObject);
            
        }
    }

}
