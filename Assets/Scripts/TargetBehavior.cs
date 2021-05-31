using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{

    public GameObject npc;
    public bool isDownstairs;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == npc.name)
        {
            SetPosition();
        }
    }

    private void SetPosition()
    {
        float x, y, z;
        x = Random.Range(-56, -43);
        z = Random.Range(20, 40);

        if (isDownstairs) // true
        {
            this.transform.position = new Vector3(x, 18, z);
            isDownstairs = false;

        }
        else // false 
        {
            this.transform.position = new Vector3(x, 4, z);
            isDownstairs = true;
        }   
        
    }
}
