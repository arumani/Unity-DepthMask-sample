using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
	const float moveLength = 5;

	float initialZ;

    void Start()
    {
		initialZ = transform.position.z;
    }
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y,
            initialZ - (moveLength / 2) + Mathf.PingPong(Time.time * 2, moveLength));
    }
}
