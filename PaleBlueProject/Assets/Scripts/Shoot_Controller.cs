using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Shoot_Controller : MonoBehaviour {

	public GameObject bullet;
	bool canShoot = true;
	float shootCooldown = 0.7f;

	// Update is called once per frame
	void Update () {
		if(canShoot)
		{
			if(Input.GetMouseButtonDown(0))
			{
				GameObject obj = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
				obj.rigidbody.AddForce(transform.forward * 900, ForceMode.Force);
				audio.Play();
				canShoot = false;
				shootCooldown = 0.7f;
			}
		}
		else
		{
			if(shootCooldown <= 0.0f)
				canShoot = true;
			else
				shootCooldown -= Time.deltaTime;
		}
	}
}
