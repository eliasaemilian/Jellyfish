using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float burstIntervalInSeconds, burstValue;
    private float cooldown = 0;
    private Rigidbody playerRigidBody;

    public PlayerInput input;

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    public void Awake()
    {
        playerRigidBody = GetComponent<Rigidbody>();

        input = new PlayerInput();

        input.Ingame.Accelerate.performed += ctx => Accelerate();
    }

    public void Update()
    {
        if (cooldown > 0)
            cooldown -= Time.deltaTime;
    }

    private void Accelerate()
    {
        if (cooldown <= 0)
        {
            Debug.Log("Burst");

            playerRigidBody.AddForce(Vector3.up * burstValue);

            cooldown = burstIntervalInSeconds;
        }
    }
}
