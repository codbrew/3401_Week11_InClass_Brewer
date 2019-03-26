using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    public GameObject[] cubePool;
    public int cubePoolSize = 100;

    public GameObject cubePrefab;
    public Text cubeCountText;
    public int cubesPerFrame = 10;

    int _currentCubeCount = 0;
    // Start is called before the first frame update
    void Start()
    {

        SpawnCubePool();



    }
    void SpawnCubePool()
    {
        cubePool = new GameObject[cubePoolSize];
        for (int i = 0; i < cubePoolSize; ++i)
        {
            GameObject cubeInstance = Instantiate(cubePrefab, transform.position, Quaternion.identity);
            cubePool[i] = cubeInstance;
            //makes cube inactive. Can be turned off and on
            cubeInstance.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cubePool.Length; i++)
        {
            if (!cubePool[i].activeSelf)
            {
                cubePool[i].SetActive(true);
                cubePool[i].transform.position = transform.position;

                break;
            }
        }
        //for (int i = 0; i < cubesPerFrame; i++)
        //{
        //    Instantiate(cubePrefab, transform.position, Quaternion.identity);
        //    _currentCubeCount += 1;

        //}

        //cubeCountText.text = _currentCubeCount.ToString();

    }
}
