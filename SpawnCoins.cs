using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    [SerializeField] private GameObject _coinObject;
    [SerializeField] private Transform _pathPoints;
    [SerializeField] private float _speedSpawn;

    private Transform[] _points;

    private void Start()
    {
        _points = new Transform[_pathPoints.childCount];

        for(int i = 0; i < _points.Length; i++)
        {
            _points[i] = _pathPoints.GetChild(i);
        }

        StartCoroutine(SpawnCoinInPoints(_speedSpawn));
    }

    private IEnumerator SpawnCoinInPoints(float speed)
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(speed);
        for(int i = 0; i < _points.Length; i++)
        {
            Instantiate(_coinObject, _points[i]);
            yield return waitForSeconds;
        }
    }
}
