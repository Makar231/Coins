using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public Transofrm target;
    [SerializeField] public int playerDamage = 2;

    private void Update()
    {
        Transofrm.position =
        Vector3.MoveTowards(transform.position,
        target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(playerDamage);
    }
}
