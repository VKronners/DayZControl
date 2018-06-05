using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchForPositionsToPutRestaurant : MonoBehaviour {

    public List<GameObject> positionsToPutRestaurant;

    void Start()
    {
        positionsToPutRestaurant = new List<GameObject>(GameObject.FindGameObjectsWithTag("PositionToRestaurant"));

        for (int i = 0; i < positionsToPutRestaurant.Count; i++)
        {
            Instantiate(Resources.Load("Prefabs/CityPrefabs/Restaurant/Restaurant"), new Vector3(positionsToPutRestaurant[i].transform.position.x,
                                                                                            positionsToPutRestaurant[i].transform.position.y,
                                                                                            positionsToPutRestaurant[i].transform.position.z),
                                                                                            Quaternion.identity, positionsToPutRestaurant[i].transform);
        }
    }
}