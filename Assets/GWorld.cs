using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private WorldStates world;  // Remove 'static' to make it an instance variable

    // Correct the property name and provide a backing field
    public static GWorld Instance
    {
        get { return instance; }
    }

    static GWorld()
    {
        instance.world = new WorldStates();  // Access 'world' through the 'instance'
    }

    private GWorld()
    {

    }

    public WorldStates GetWorld()
    {
        return world;
    }
}

