using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;
    public int size;
    public GameObject[] prefabs;
    [SerializeField] private List<PoolObject> poolObjects;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        InstantiateObjects();
    }

    private void InstantiateObjects()
    {   
        poolObjects = new List<PoolObject>();

        for (int i = 0; i < size; i++)
        {
            foreach(GameObject go in prefabs)
            {
                poolObjects.Add(Instantiate(go, transform).GetComponent<PoolObject>());
            }
        }
    }

    public PoolObject RequestObject(PoolObjectType type)
    {
        foreach(PoolObject po in poolObjects)
        {
            if (po.type == type && !po.isActive())
            {
                return po;
            }
        }
        Debug.LogWarning($"No inactive object of type {type} found in the pool.");
        return null;
    }

    public static ObjectPool GetInstance()
    {
        return instance;
    }
	
	public void DeactivateAllObjects()
	{
		foreach (PoolObject po in poolObjects)
		{
			po.deactivate();
		}
	}
}