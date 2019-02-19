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

public class bulletcollision : MonoBehaviour {
	void Start () {}
	void Update () {}

	void OnCollisionEnter(Collision collision){
		// once we get this to a point where we need to detect collision between bullets and players we'll do that here but for now we'll just make them stop dead in their tracks.
		Debug.Log("Collision.");
		Rigidbody body = GetComponent<Rigidbody>();
		body.velocity = Vector3.zero;
	}
}
