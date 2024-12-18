using UnityEngine;

public enum EntityData
{
    Projectile,
    Player,
    Blocker,
}

public class Entity : MonoBehaviour
{
    public EntityData EntityData;
}