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

public class BulletAttrs : MonoBehaviour {
	public int shooter = -1;	// who shot J.R.?
	public int weapon = 0;		// which weapon is this from; we'll use this later to determine which bullet model to use
	public bool done = false;	// whether this bullet has already hit something

	void Start () {}
	void Update () {}
}
