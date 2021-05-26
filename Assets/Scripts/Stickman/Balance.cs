using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    public float        targetRotation = 0.0f;
    public Rigidbody2D  rig            = null;
    public float        force          = 100.0f;

    private void Start() {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        rig.MoveRotation(Mathf.LerpAngle(rig.rotation, targetRotation, force * Time.fixedDeltaTime));
    }
}
