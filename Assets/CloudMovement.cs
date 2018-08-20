using UnityEngine;

public class CloudMovement : MonoBehaviour {

	private int speed;
	private Vector3 translation;

	void Start(){
		speed = Random.Range(1, 3);
		translation = new Vector3(speed, 0, 0);
	}

	void Update () {
		gameObject.transform.Translate(translation);
	}
}
