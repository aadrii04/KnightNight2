using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Vector3 targetPosition1;
    public Vector3 targetPosition2;
    public Vector3 targetPosition3;

    public GameObject MainCamera;
    public void ChangeCameraPosition1()
    {
        MainCamera.transform.position = targetPosition1;
    }

    public void ChangeCamerPosition2()
    {
        MainCamera.transform.position = targetPosition2;
    }

    public void ChangeCamerPosition3()
    {
        MainCamera.transform.position = targetPosition3;
    }
}
