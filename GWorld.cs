using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWorld // Singleton
{
    private static readonly GWorld instance = new GWorld();

    public static Worldstate world;

    static GWorld() // Dictionary for GWorld
    {
        world = new Worldstate();
    }

    private GWorld() 
    { 
    
    }

    public static GWorld Instance 
    { 
        get { return instance; }
    }

    public Worldstate GetWorld()
    { 
        return world;
    }   

}
