using UnityEngine;

public class Projectile : Entity
{
    [SerializeField] SO_Projectile _projectileSO;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _projectileSO.Speed);
    }
}
