using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="new HitPoints", menuName = "HitPoints")]
public class HitPoints : ScriptableObject
{
    public int health;
    public int maxHealth;
    public int startingHealth;
}
