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

public class FireBullet : MonoBehaviour
{
	public GameObject bulletPrefab;

	public GameObject playerInstance;

	private void Start()
    {
	}

    private void Update()
    {
		if (Input.GetMouseButtonDown(0))
        {
			Shoot();
		}
	}

	private void Shoot()
	{
		GameObject projectile = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;

        AudioSource pew = GetComponent<AudioSource>();
		pew.Play();

        Rigidbody body = projectile.GetComponent<Rigidbody>();
		body.velocity = Camera.main.transform.forward * 60.0f;

        PlayerAttrs playerAttrs = playerInstance.GetComponent<PlayerAttrs>();

        if (playerAttrs != null)
            projectile.GetComponent<BulletAttrs>().shooter = playerAttrs.team_number;
	}
}
