using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageInfo
{
    public class TileInfo
    {
        public int kind;        // 0: PathTile, 1: DeployTile, 2: StartTile, 3: DestTile, 4: ObstacleTile
        public int chapterNo;
        public int prefabNo;
        public List<Tile.Node> nodes;

        public TileInfo()
        {
            kind = 0;
            chapterNo = 0;
            prefabNo = 0;
            nodes = new List<Tile.Node>();
        }
    }

    public int width;
    public int height;
    public List<TileInfo> tileInfo;
    public List<Path> pathInfo;

    public StageInfo()
    {
        width = 0;
        height = 0;
        tileInfo = new List<TileInfo>();
        pathInfo = new List<Path>();
    }
}
