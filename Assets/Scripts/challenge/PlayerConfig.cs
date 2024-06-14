using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayer", menuName = "Configs/Player", order = 1)]
public class PlayerConfig : ScriptableObject
{
    public string playerName;
    public int health;
    public int score;
    public Sprite profile;
    public float speed = 0;
    public Vector3 sizePlayer;
}
