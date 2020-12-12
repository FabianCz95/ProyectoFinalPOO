using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
	[SerializeField] GameObject lightingParticles;
	[SerializeField] GameObject burstParticles;

	private SpriteRenderer _rederer;

	private void Awake()
	{
		_rederer = GetComponent<SpriteRenderer>();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player")) {
			_rederer.enabled = false;
			lightingParticles.SetActive(false);
			burstParticles.SetActive(true);

			Destroy(gameObject, 2f);
		}
	}
}
