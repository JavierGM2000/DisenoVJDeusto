using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string name { get; private set; }

    public Character()
    {
        name = "Generic";
    }

    public Character(string inName)
    {
        name = inName;
        Debug.Log($"Hola shoy {name}");
    }


    ~Character()  // finalizer
    {
        Debug.Log($"{name} ha sido eliminado");
    }
}

public class Player : Character
{
    public Player(string name) : base(name) { }
}

public class Enemy : Character
{
    public Enemy(string name) : base(name) { }
}
