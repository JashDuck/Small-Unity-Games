using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    private int score;
    public Text scoreText;

    public ParticleSystem Pickup;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("coin")) {
            score++;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);

            Pickup.Play();
        }
    }
}
