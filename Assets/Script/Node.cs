using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public bool walkable;
    public Vector2 worldPosition;
    public int gridX;
    public int gridY;
    public int costToGo;
    public int heuristicCost;
    public Node parent;

    public Node(bool _walkable, Vector2 _worldPosition, int _gridX, int _gridY)
    {
        walkable = _walkable;
        worldPosition  =  _worldPosition;
        gridX = _gridX;
        gridY = _gridY;
    }

    public int fCost{
        get 
        {
            {
                return costToGo + heuristicCost;
            }
        }
    }
}
