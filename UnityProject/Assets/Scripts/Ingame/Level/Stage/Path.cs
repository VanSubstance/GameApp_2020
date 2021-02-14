using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path
{
    public List<int> tiles;
    public List<int> nodes;
    public int length;

    public Path()
    {
        tiles = new List<int>();
        nodes = new List<int>();
        length = 0;
    }

    public Path(Path path)
    {
        tiles = new List<int>();
        nodes = new List<int>();

        for (int i = 0; i < path.tiles.Count; i++)
        {
            tiles.Add(path.tiles[i]);
        }
        for (int i = 0; i < path.nodes.Count; i++)
        {
            tiles.Add(path.nodes[i]);
        }
        length = path.length;
    }
}
