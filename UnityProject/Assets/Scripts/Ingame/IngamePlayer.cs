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
        resource = new Resource();
    }

    public class Resource
    {
        int gold;
    }

    public bool CheckResource(IngamePlayer.Resource cost)
    {
        if(resource.gold > cost.gold)
        {
            return true;
        }

        return false;
    }

    public bool CheckLife(int damage)
    {
        if(life < damage)
        {
            return false;
        }
        return true;
    }

    public bool CheckDeployEnable(int cost)
    {
        if(currentTowerNumber + cost < maxTowerNumber)
        {
            return true;
        }
        return false;
    }

    public void SetResource(IngamePlayer.Resource value)
    {
        resource.gold = value.gold;
    }
}
