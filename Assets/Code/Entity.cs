using UnityEngine;

public enum EntityData
{
    Projectile,
    Player,
}

public class Entity : MonoBehaviour
{
    public EntityData EntityData;
}