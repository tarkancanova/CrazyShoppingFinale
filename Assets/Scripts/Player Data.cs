using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
    public bool sausage2Open = false;
    public bool sausage3Open = false;
    public bool sausage4Open = false;
    public float Money = 0;
}
