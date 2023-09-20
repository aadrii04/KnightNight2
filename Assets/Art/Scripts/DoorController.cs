using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 

public class DoorController : MonoBehaviour
{

    private Animator animDoor;
    public UnityEvent OnCollision;
    private bool _open;
    private BoxCollider2D _box;


    private void Start()
    {
        animDoor = GetComponent<Animator>();
        _open = false;
    }


    public void OpenDoor()
    {
        animDoor.SetBool("open", true);
        _open = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        /*if(_open == false)
        {
            _box.isTrigger = false;
        }*/
        if(_open == true)
        {
            OnCollision.Invoke();
        }
    }
}
