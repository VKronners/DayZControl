using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchForPositionsToPutGalpao : MonoBehaviour {

    public List<GameObject> positionsToPutGalpao;

    void Start()
    {
        positionsToPutGalpao = new List<GameObject>(GameObject.FindGameObjectsWithTag("PositionToGalpao"));
        for (int i = 0; i < positionsToPutGalpao.Count; i++)
        {
            int whatGalpao = Random.Range(0, 2);
            if (whatGalpao == 0)
            {
                Instantiate(Resources.Load("Prefabs/CityPrefabs/Galpao/Galpao"), new Vector3(positionsToPutGalpao[i].transform.position.x,
                                                                                            positionsToPutGalpao[i].transform.position.y,
                                                                                            positionsToPutGalpao[i].transform.position.z),
                                                                                            Quaternion.identity, positionsToPutGalpao[i].transform);
            }
            else
            {
                Instantiate(Resources.Load("Prefabs/CityPrefabs/Galpao/Galpao1"), new Vector3(positionsToPutGalpao[i].transform.position.x,
                                                                                            positionsToPutGalpao[i].transform.position.y,
                                                                                            positionsToPutGalpao[i].transform.position.z),
                                                                                            Quaternion.identity, positionsToPutGalpao[i].transform);
            }

        }
    }
}
