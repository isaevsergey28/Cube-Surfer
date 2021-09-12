using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private AudioClip _coinCollectSound;

    public delegate void OnCoinSelected();
    public static event OnCoinSelected onCoinSelectedEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<ActiveCube>(out ActiveCube activeCube))
        {
            AudioSource.PlayClipAtPoint(_coinCollectSound, transform.position);
            onCoinSelectedEvent?.Invoke();
            Destroy(this.gameObject);
        }
    }
}
