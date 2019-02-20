using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * this code was written by draven r stedman
 * this code spits in the face of copyright and
 * capitalism's other dead gods, and is licensed
 * under both the GNU General Public License v3
 * and the Crimethinc. N©! license. see
 * license.txt for details.
 */

public class shooty : MonoBehaviour {

	public GameObject origbullet;
	public GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			shoot ();
		}
	}

	void shoot ()
	{
		GameObject tempbullet = Instantiate( origbullet, transform.position, transform.rotation ) as GameObject;
		AudioSource pew = GetComponent<AudioSource> ();
		pew.Play ();
		Rigidbody projectile = tempbullet.GetComponent<Rigidbody>();
		projectile.velocity = Camera.main.transform.forward * 20f;
		tempbullet.GetComponent<BulletAttrs> ().shooter = player.GetComponent<PlayerAttrs> ().team_number;
	}
}
