using Unity.VisualScripting;
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

    private void Start()
    {
        // all this must be done first in Start() before the game begins.
        // establishes the number of seeds the player has & the lack of seeds planted.
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        // check on console if the amount has been set correctly.
        Debug.Log("Number of seeds left : " + _numSeedsLeft);
        Debug.Log("Number of seeds planted : " + _numSeedsPlanted);

        // updates the UI to show number of seeds left/planted.
        _plantCountUI = gameObject.AddComponent<PlantCountUI>();
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        // Player moves up, down, left, right depending on W, S, A, D keyboard input.
        if (Input.GetKey(KeyCode.W))
            _playerTransform.Translate(Vector3.up * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            _playerTransform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            _playerTransform.Translate(Vector3.left * _speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            _playerTransform.Translate(Vector3.right * _speed * Time.deltaTime);


        // Player plants seed when pressing space.
        if (_numSeedsLeft > 0 && Input.GetKeyDown(KeyCode.Space))
            PlantSeed(); 
    }

    public void PlantSeed ()
    {
        // spawns prefab directly where the player's position is
        Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        
        // subtracts one seed from the number of seeds the player has left
        _numSeeds = _numSeeds - 1; 
        _numSeedsLeft = _numSeeds;

        // adds the amount of seeds planted on the main scene
        _numSeedsPlanted = _numSeedsPlanted + 1;

        // updates the UI text 
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
