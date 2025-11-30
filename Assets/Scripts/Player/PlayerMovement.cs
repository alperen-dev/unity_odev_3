//using System.Numerics;
using System.Transactions;
using UnityEngine;
//using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5.0f;
    [SerializeField] private float rotationSpeed = 3.0f;
	private float vercitalRotation = 0.0f; 
	

	void Update()
	{
		// move
		Vector3 localMovement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Fly"), Input.GetAxis("Vertical"));
		
		if (localMovement.magnitude > 1)
		{
			localMovement.Normalize();
		}
		Vector3 movement = transform.TransformDirection(localMovement) * movementSpeed * Time.deltaTime;
		transform.position += movement;
	
		// rotate
		float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

		transform.Rotate(Vector3.up * mouseX);

		vercitalRotation -= mouseY;
		
		vercitalRotation = Mathf.Clamp(vercitalRotation, -90f, 90f);
		transform.localEulerAngles = new Vector3(vercitalRotation, transform.localEulerAngles.y, 0f);
		
	}
}
