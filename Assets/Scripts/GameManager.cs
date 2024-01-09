using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // public GameObject[] ghosts;
    public Player1 player1;

    public Transform pellets;

    public int score {get; private set; }
    public int respawns {get; private set; }

    private void Start()
    {
        NewGame();
    }
    private void NewGame()
    {
        SetScore(0);
        SetRespawns(3);
        // NewRound()
    }
    // private void NewRound()
    // {
    //     foreach (Transform pellet in this.pellets){
    //         pellet.GameObject.SetActive(True);
    //     }
    //     for (int i = 0; i<this.ghosts.Length; i++){
    //         this.ghosts[i].gameObject.SetActive(true);
    //     }
    //     this.player1.gameObject.SetActive(true);
    // }
    private void SetScore(int score)
    {
        this.score = score;
    }
    private void SetRespawns(int respawns)
    {
        this.respawns = respawns;
    }
    public void PelletEaten(Pellet pellet)
    {
        pellet.gameObject.SetActive(false);
        SetScore(this.score + pellet.points);
    }

    public void PowerupEaten(Powerup pellet)
    {
        PelletEaten(pellet);
    }
}
