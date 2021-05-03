using UnityEngine;
using WeaponPack;

public class Weapon : MonoBehaviour
{
    private void Start()
    {
        WeaponPack.Weapon sword = new WeaponPack.Weapon();
        Shield s = new Shield();
    }

    private void Update()
    {
        
    }
}
