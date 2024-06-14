using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public PlayerConfig playerConfig;
    public Image profile;
    public string username;
    public int health;
    public int score;
    public float speed = 0;
    void Start()
    {
        transform.localScale = playerConfig.sizePlayer;
        profile.sprite = playerConfig.profile;
        SetupInformation();
    }

    private void SetupInformation()
    {
        username = playerConfig.playerName;
        health = playerConfig.health;
        score = playerConfig.score;
        speed = playerConfig.speed;
    }

}
