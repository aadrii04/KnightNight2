using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GemController : MonoBehaviour
{

    public GameObject door;
    public UnityEvent GetKey;
    private CapsuleCollider2D _box;

    private void Start()
    {
        _box = GetComponent<CapsuleCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        door.SetActive(true);


        GetKey.Invoke();
        _box.isTrigger = true;
    }
}
