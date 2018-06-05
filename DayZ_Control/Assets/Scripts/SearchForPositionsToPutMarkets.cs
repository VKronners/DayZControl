using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchForPositionsToPutMarkets : MonoBehaviour {

    public List<GameObject> positionsToPutMarket;

    void Start()
    {
        positionsToPutMarket = new List<GameObject>(GameObject.FindGameObjectsWithTag("PositionToMarket"));

        for (int i = 0; i < positionsToPutMarket.Count; i++)
        {
            int whatMarket = Random.Range(0, 2);
            if (whatMarket == 0)
            {
                Instantiate(Resources.Load("Prefabs/CityPrefabs/Markets/Market"), new Vector3(positionsToPutMarket[i].transform.position.x,
                                                                                              positionsToPutMarket[i].transform.position.y,
                                                                                              positionsToPutMarket[i].transform.position.z),
                                                                                              Quaternion.identity, positionsToPutMarket[i].transform);
            }
            else
            {
                Instantiate(Resources.Load("Prefabs/CityPrefabs/Markets/Market2"), new Vector3(positionsToPutMarket[i].transform.position.x,
                                                                                               positionsToPutMarket[i].transform.position.y,
                                                                                               positionsToPutMarket[i].transform.position.z),
                                                                                               Quaternion.identity, positionsToPutMarket[i].transform);
            }

        }
    }
}

