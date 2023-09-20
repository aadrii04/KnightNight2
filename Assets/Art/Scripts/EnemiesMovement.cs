using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMovement : MonoBehaviour
{
    [SerializeField] public float SpeedVelocity;
    [SerializeField] private Transform[] MovementPoints;
    [SerializeField] private float MinDistance;

    private int RandomNum;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        RandomNum = Random.Range(0, MovementPoints.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();
        Turn();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, MovementPoints[RandomNum].position, SpeedVelocity * Time.deltaTime);

        if(Vector2.Distance(transform.position, MovementPoints[RandomNum].position) < MinDistance)
        {
            RandomNum = Random.Range(0, MovementPoints.Length);
            Turn();
        }
    }

    private void Turn()
    {
        if (transform.position.x < MovementPoints[RandomNum].position.x)
        {
            spriteRenderer.flipX = false;
        }
        else
            spriteRenderer.flipX = true;
    }
}
