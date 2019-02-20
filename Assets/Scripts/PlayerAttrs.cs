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

public class PlayerAttrs : MonoBehaviour {

	// we're gonna use this to enumerate pretty much everything about the player. for now that'll just amount to team number, health remaining, is-human boolean, and name.

	public int team_number = 1;					// this will function both as which team you're on in team-based modes, AND as which number player you are in free-for-alls
												// this is to help prevent bullets shot by you or your teammates from hurting you.
	public int health_remaining = 100; 			// self-explanatory
	public bool is_human = true;				// check for whether the player is a human or a bot
	public string handle = "hybridnoisebloom";	// using my username on games as a placeholder here :)


	void Start () {
		
	}
	
	void Update () {
		// TODO: in the future we'll use the update to check if you've died and whatnot.
		// TODO: also we'll use this to do some veeeery basic AI, if is_human is false for whatever player.
		// so basically this is a pretty general behaviour script.
	}
}
