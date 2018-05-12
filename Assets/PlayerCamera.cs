using UnityEngine;

public class PlayerCamera : MonoBehaviour {

	public Transform player;
	public float smoothSpeed = 0.125f;

	public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
		Vector3 desiredPosition = player.position + offset;
		Vector3 playerPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
		transform.LookAt(player);
	}
}
