using UnityEngine;
using UnityEngine.Events;


public class PlayeColliede : MonoBehaviour
{
    [SerializeField]

    private string obstacleTag = "Obstacle";
    [SerializeField]

    private UnityEvent onObstacleCollision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(obstacleTag))
        {
            onObstacleCollision?.Invoke();
        }
    }


}
