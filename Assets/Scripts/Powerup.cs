
using UnityEngine;

public class Powerup : Pellet
{
    public float duration = 8.0f;

    protected override void Eat()
    {
        FindObjectOfType<GameManager>().PowerupEaten(this);
    }

}