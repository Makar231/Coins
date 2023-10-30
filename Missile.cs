using UnityEngine;

public class Missile : MonoBehaviour
{
    [SerializeField] public float speed = 3f;
    public void Move()
    {
        transform.position +=
        transform.forward *
        speed * Time.deltaTime;

        void Update()
        {
            Destroy(gameObject, 3);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
        {  
            Destroy(enemy.gameObject);

        }
    }
}
