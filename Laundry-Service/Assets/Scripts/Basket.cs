using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public GameObject clothe;
    private Vector3 spawnPoint;
    public static int _spawnCounter;
    public int _spawnLimit;

    public Canvas canva;

    public GameObject parentClothes; 


    // timer
    public float _timer;
    private float _timerEqual;
    void Start()
    {
        _timerEqual = _timer;
        spawnPoint = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -1);
        _spawnCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ClotheSpawner();
    }
    public void ClotheSpawner()
    {
        _timer -= Time.deltaTime;
        if (_timer <= 0 && _spawnCounter<_spawnLimit)
        {

            GameObject go = Instantiate(clothe, spawnPoint, Quaternion.identity) as GameObject;
            go.transform.SetParent(parentClothes.transform);
            go.transform.localScale = new Vector3(100, 100, 100);
            _timer = _timerEqual;
            _spawnCounter += 1;
        }
    }
  



}
