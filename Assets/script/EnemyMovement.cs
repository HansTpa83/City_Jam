using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float Speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * -Speed * Time.deltaTime);
    }
}
