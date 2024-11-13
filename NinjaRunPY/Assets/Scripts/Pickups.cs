using UnityEngine;

public class Pickups : MonoBehaviour {
    public GameObject door;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("coin")) {
            Destroy(door);
            Destroy(other.gameObject);
        }
    }
}
