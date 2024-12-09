using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIChase : MonoBehaviour
{
    public GameObject Player;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Calculate direction towards the player
        Vector2 direction = (Player.transform.position - transform.position).normalized;

        // Move the boss towards the player
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
    }
}
