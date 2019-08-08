using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    private void Update() {
        transform.position= player.transform.position+offset;
    }
}
