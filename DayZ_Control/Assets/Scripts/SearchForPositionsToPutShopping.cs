using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchForPositionsToPutShopping : MonoBehaviour {

    public List<GameObject> positionsToPutShopping;

    void Start()
    {
        positionsToPutShopping = new List<GameObject>(GameObject.FindGameObjectsWithTag("PositionToShopping"));

        for (int i = 0; i < positionsToPutShopping.Count; i++)
        {
                Instantiate(Resources.Load("Prefabs/CityPrefabs/Shopping/Shopping"), new Vector3(positionsToPutShopping[i].transform.position.x,
                                                                                            positionsToPutShopping[i].transform.position.y,
                                                                                            positionsToPutShopping[i].transform.position.z),
                                                                                            Quaternion.identity, positionsToPutShopping[i].transform);
        }
    }
}
