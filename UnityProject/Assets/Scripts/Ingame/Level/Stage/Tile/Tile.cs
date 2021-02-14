using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [System.Serializable]
    public class Node
    {
        public bool isEnable;
        public float randRange;
        public Vector3 position;

        public Node()
        {
            isEnable = false;
            randRange = 0.0f;
            position = new Vector3(0, 0, 0);
        }

        public Node(Node node)
        {
            isEnable = node.isEnable;
            randRange = node.randRange;
            position = node.position;
        }
    }

    public List<Node> nodes;
    [HideInInspector]public Tile[] neighbors;

    private void Awake()
    {
        Init();
    }

    public void Init()
    {
        nodes = new List<Node>();
        neighbors = new Tile[4];
    }
}
