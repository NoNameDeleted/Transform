using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + transform.forward, _speed * Time.deltaTime);
    }
}
