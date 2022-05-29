using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerCollisionHendler : MonoBehaviour
{
    private Player _bird;

    private void Start()
    {
        _bird = GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ScoreZone scoreZone))
            _bird.AddScore();

        else
        _bird.Die();
    }
 
}
