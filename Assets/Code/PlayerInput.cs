using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float Movement { get; private set; }
    public bool IsAttack {  get; private set; }

    // Update is called once per frame
    void Update()
    {
        Movement = Input.GetAxis("Horizontal");
        IsAttack = Input.GetMouseButtonDown(0);
    }
}
