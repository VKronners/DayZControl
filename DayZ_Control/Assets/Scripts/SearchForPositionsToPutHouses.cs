using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchForPositionsToPutHouses : MonoBehaviour {

    public List<GameObject> positionsToPutHouses;

	void Start () {
        positionsToPutHouses = new List<GameObject>(GameObject.FindGameObjectsWithTag("PositionToHouse"));

        for (int i = 0; i < positionsToPutHouses.Count; i++)
        {
            int whatHouse = Random.Range(0, 2);
            Debug.Log(Resources.Load("Prefabs/CityPrefabs/Houses/Casa1"));
            if (whatHouse == 0)
            {
                Instantiate(Resources.Load("Prefabs/CityPrefabs/Houses/Casa1"), new Vector3(positionsToPutHouses[i].transform.position.x,
                                                                                            positionsToPutHouses[i].transform.position.y,
                                                                                            positionsToPutHouses[i].transform.position.z),
                                                                                            Quaternion.identity, positionsToPutHouses[i].transform);
            }
            else
            {
                Instantiate(Resources.Load("Prefabs/CityPrefabs/Houses/Casa2"), new Vector3(positionsToPutHouses[i].transform.position.x,
                                                                                            positionsToPutHouses[i].transform.position.y,
                                                                                            positionsToPutHouses[i].transform.position.z),
                                                                                            Quaternion.identity, positionsToPutHouses[i].transform);
            }
            
        }
    }
	
	void Update () {
		
	}
}
