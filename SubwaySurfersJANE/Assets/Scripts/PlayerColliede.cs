using UnityEngine;
using UnityEngine.Events;


public class PlayeColliede : MonoBehaviour
{
    [SerializeField]

    private string obstacleTag = "Obstacle";
    [SerializeField]

    private string coinTag = "coin";
    [SerializeField]

    private UnityEvent<Transform> onObstacleCollision;
    [SerializeField]

    private UnityEvent<Transform> onCoinCollected;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(obstacleTag))
        {
            onObstacleCollision?.Invoke(transform);
        }
        else if (other.CompareTag(coinTag))
        {
            onCoinCollected?.Invoke(transform);
            other.gameObject.SetActive(false);
        }
    }
}
