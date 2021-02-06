using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngamePlayer:MonoBehaviour
{
    public Resource resource;
    public int life;
    public int currentTowerNumber;
    public int maxTowerNumber;

    private void Awake()
    {
        Init();    
    }

    private void Init()
    { 

    }

    public class Resource
    {
        int gold;
    }

    public bool CheckResource(IngamePlayer.Resource cost)
    {
        return true;
    }

    public bool CheckLife(int damage)
    {
        return true;
    }

    public bool CheckDeployEnable(int cost)
    {
        return true;
    }

    public bool ChangeResource(IngamePlayer.Resource change)
    {
        return true;
    }

    public void SetResource(IngamePlayer.Resource value)
    {

    }
}
