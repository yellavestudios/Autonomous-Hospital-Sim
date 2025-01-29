using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Worldstate
{
    public string key;
    public int value;
}
public class WorldState
{
    public Dictionary<string, int> state;

    public WorldState()
    {
        state = new Dictionary<string, int>();
    }
}
