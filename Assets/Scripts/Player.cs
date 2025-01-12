using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        
    }

    private void Update()
    {
        // Player moves up, down, left, right depending on W, S, A, D keyboard input
        if (Input.GetKey(KeyCode.W))
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);

        // Player plants seed when pressing space
        if (Input.GetKey(KeyCode.Space))
            PlantSeed(); 
    }

    public void PlantSeed ()
    {
        // Spawns plant 
        Instantiate(_plantPrefab);

        _numSeeds -= 1; 

        _numSeedsLeft = _numSeeds;

        _numSeedsPlanted += 1; 


        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
