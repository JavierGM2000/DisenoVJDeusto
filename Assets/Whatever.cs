using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Whatever : MonoBehaviour
{
    private Player player;
    private List<Enemy> enemies;

    // Start is called before the first frame update
    void Start()
    {
        player = new Player("Ermenejildo");
        enemies = new List<Enemy>();
        for (int i = 0; i < 10; i++)
        {
            enemies.Add(new Enemy((char)(i+65)+" will kill"));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
