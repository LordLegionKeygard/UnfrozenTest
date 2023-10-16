using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionSpawner : MonoBehaviour
{
    [SerializeField] private MissionInfo[] _allMission;
    [SerializeField] private Transform _parent;
    [SerializeField] private GameObject _missionPrefab;

    private void Start()
    {
        SpawnAllMission();
    }

    private void SpawnAllMission()
    {
        for (int i = 0; i < _allMission.Length; i++)
        {
            var prefab = Instantiate(_missionPrefab, new Vector3(_allMission[i].MapPosition.x, _allMission[i].MapPosition.y, 0), Quaternion.identity);
            prefab.GetComponent<MissionSlot>().MissionInfo = _allMission[i];
            prefab.transform.SetParent(_parent);
        }
        CustomEvents.FireSetStartMissionSlotsInfo();
    }
}
