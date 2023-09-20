using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform spawn1;
    public Transform spawn2;
    public Transform spawn3;

    public void Spawn1()
    {
        gameObject.transform.SetPositionAndRotation(spawn1.transform.position, spawn1.transform.rotation);
    }
    public void Spawn2()
    {
        gameObject.transform.SetPositionAndRotation(spawn2.transform.position, spawn2.transform.rotation);
    }

    public void Spawn3()
    {
        gameObject.transform.SetPositionAndRotation(spawn3.transform.position, spawn3.transform.rotation);
    }


}
