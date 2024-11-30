using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSetController : MonoBehaviour
{
    public GameObject[] weaponSet;

    void Start()
    {
        DeactivateAllWeapons();
        ActivateWeaponSet(0);

        WeaponUpgradeCheck();
    }

    private void DeactivateAllWeapons()
    {
        foreach (GameObject go in weaponSet)
        {
            go.SetActive(false);
        }
    }

    public void ActivateWeaponSet(int upgradeLevel)
    {
        for (int i = 0; i < weaponSet.Length; i++)
        {
            if (i == upgradeLevel)
            {
                weaponSet[i].SetActive(true);
            }
            else
            {
                weaponSet[i].SetActive(false);
            }
        }
    }
    
    public void WeaponUpgradeCheck()
    {
        int upgradeLevel = GetComponents<WeaponUpgrade>().Length;

        if (upgradeLevel >= weaponSet.Length)
        {
            upgradeLevel = weaponSet.Length -1;
        }
        
        ActivateWeaponSet(upgradeLevel);
    }
}
