using UnityEngine;

public class Blast : MonoBehaviour
{
    protected float _maxDistance;
    protected float _currentDistance = 0f;
    protected float _speed = 5f;

    public float MaxDistance { set { _maxDistance = value; } }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBlast();
    }

    protected void MoveBlast()
    {
        float distanceToMove = _speed * Time.deltaTime;
        transform.Translate(Vector3.forward * distanceToMove);
        _currentDistance += distanceToMove;

        if (_currentDistance >= _maxDistance)
        {
            Destroy(gameObject);
        }
    }
}
