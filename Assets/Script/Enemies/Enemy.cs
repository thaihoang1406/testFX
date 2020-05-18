using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string Race;
    public string Rank;
    public float Ratio;
    public float Speed;
    public int HP;
    public int Atk;
    public int Def;


    public void initInfo(string race, string rank, float ratio, float speed, int hp, int atk, int def)
    {
        this.Race = race;
        this.Rank = rank;
        this.Ratio = ratio;
        this.Speed = speed;
        this.HP = hp;
        this.Atk = atk;
        this.Def = def;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
