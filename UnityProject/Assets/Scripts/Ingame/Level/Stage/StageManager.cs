using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class StageManager : MonoBehaviour
{
    public int width;
    public int height;
    public List<Tile> tiles;
    public List<Path> paths;
    public List<StartTile> starts;
    public List<DestTile> dests;

    private void Awake()
    {
        Init();
    }

    public void Init()
    {
        width = 0;
        height = 0;
        tiles = new List<Tile>();
        paths = new List<Path>();
        starts = new List<StartTile>();
        dests = new List<DestTile>();
    }

    public void MakeStage(StageInfo stageInfo)
    {
        GameObject tileGameObject;
        Tile tile;
        Path path;

        width = stageInfo.width;
        height = stageInfo.height;

        /* 
         * ���� ī�޶� ������ ���õ� �ڵ� 
         */

        // Ÿ�� ���ӿ�����Ʈ ���� �� Ÿ�Ϻ����鿡 ���� --> ��Ȳ���� new�� �ƴ϶� ������ ���� ��� Ȱ���� �����Ҽ��� ����
        for (int i = 0; i < stageInfo.tileInfo.Count; i++)
        {
            switch (stageInfo.tileInfo[i].kind)
            {
                case Constants.Tile.pathTile:
                    {
                        tile = new PathTile();
                        break;
                    }
                case Constants.Tile.deployTile:
                    {
                        tile = new DeployTile();
                        break;
                    }
                case Constants.Tile.startTile:
                    {
                        tile = new StartTile();
                        starts.Add((StartTile)tile);
                        break;
                    }
                case Constants.Tile.destTile:
                    {
                        tile = new DestTile();
                        dests.Add((DestTile)tile);
                        break;
                    }
                case Constants.Tile.obstacleTile:
                    {
                        tile = new ObstacleTile();
                        break;
                    }
                default:
                    {
                        tile = null;
                        break;
                    }
            }
            if (!tile)
            {
                Debug.Log("tile[" + i + "] setting error!");
                break;
            }
            tiles.Add(tile);

            /*
             * �������� �̿��� ���ӿ�����Ʈ ���� �� width, height�� ����� Ÿ���� ��ġ�� ���õ� �ڵ�
             */
        }

        SetTiles(stageInfo);

        for (int i = 0; i < stageInfo.pathInfo.Count; i++)
        {
            path = new Path(stageInfo.pathInfo[i]);
            paths.Add(path);
        }
    }

    public void SetTiles(StageInfo stageInfo)
    {
        for (int i = 0; i < tiles.Count; i++)
        {
            // ���� �̿� Ȯ�� �� ���
            if (i % width == 1)
                tiles[i].neighbors[0] = null;
            else
                tiles[i].neighbors[0] = tiles[i - 1];

            // ���� �̿� Ȯ�� �� ���
            if (i % height == 1)
                tiles[i].neighbors[1] = null;
            else
                tiles[i].neighbors[1] = tiles[i - width];

            // ������ �̿� Ȯ�� �� ���
            if (i % width == width - 1)
                tiles[i].neighbors[2] = null;
            else
                tiles[i].neighbors[2] = tiles[i + 1];

            // ���� �̿� Ȯ�� �� ���
            if (i % height == height - 1)
                tiles[i].neighbors[3] = null;
            else
                tiles[i].neighbors[3] = tiles[i + width];

            // Ÿ���� ��� ������ �����´�.
            for(int j = 0; j < stageInfo.tileInfo[i].nodes.Count; j++)
            {
                tiles[i].nodes[j].isEnable = stageInfo.tileInfo[i].nodes[j].isEnable;
                tiles[i].nodes[j].randRange = stageInfo.tileInfo[i].nodes[j].randRange;
                tiles[i].nodes[j].position = stageInfo.tileInfo[i].nodes[j].position;
            }
        }
    }

    public Vector3 NextDirection(int pathNo, int currentOrder)
    {
        Vector3 next;
        int nextTile;
        int nextNode;

        nextTile = paths[pathNo].tiles[currentOrder + 1];
        nextNode = paths[pathNo].nodes[currentOrder + 1];

        next = tiles[nextTile].nodes[nextNode].position;

        return next;
    }
}
