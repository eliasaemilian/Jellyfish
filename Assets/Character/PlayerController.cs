using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent( typeof( Rigidbody ) )]
public class PlayerController : MonoBehaviour {
	[SerializeField] private float burstIntervalInSeconds = 0.8f, burstValue = 6;
	[SerializeField] private float rotationModifier = 40;
	private float cooldown = 0;
	private bool isMoving = false;
	private Rigidbody playerRigidBody;

	private float xAngularVelocity, zAngularVelocity;


	public PlayerInput input;

	private void OnEnable() {
		input.Enable();
	}

	private void OnDisable() {
		input.Disable();
	}

	public void Awake() {
		playerRigidBody = GetComponent<Rigidbody>();

		input = new PlayerInput();


		input.Ingame.Accelerate.performed += ctx => Accelerate();
		input.Ingame.Accelerate.canceled += ctx => StopMoving();

		input.Ingame.Steer_Vertical.performed += ctx => XRotate( ctx.ReadValue<float>() );
		input.Ingame.Steer_Vertical.canceled += ctx => XRotate( 0 );


		input.Ingame.Steer_Horizontal.performed += ctx => ZRotate( ctx.ReadValue<float>() );
		input.Ingame.Steer_Horizontal.canceled += ctx => ZRotate( 0 );
	}

	public void Update() {

		//acceleration
		if ( isMoving ) {

			Debug.Log( "Am moving" );

			if ( cooldown > 0 )
				cooldown -= Time.deltaTime;
			else {
				Accelerate();
			}
		}
	}

	public void FixedUpdate() {
		//rotation
		Vector3 AngularVelocity = new Vector3( xAngularVelocity, 0, zAngularVelocity );

		Quaternion deltaRotation = Quaternion.Euler( AngularVelocity * Time.fixedDeltaTime * rotationModifier );

		playerRigidBody.MoveRotation( playerRigidBody.rotation * deltaRotation );
	}

	private void Accelerate() {
		isMoving = true;

		Debug.Log( "Burst" );

		playerRigidBody.AddForce( Vector3.up * burstValue );

		cooldown = burstIntervalInSeconds;
	}

	private void StopMoving() {
		isMoving = false;
	}

	private void ZRotate( float value ) {
		zAngularVelocity = value * -1;
	}
	private void XRotate( float value ) {
		xAngularVelocity = value;
	}
}
