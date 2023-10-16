using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MissionView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _numberText;
    [SerializeField] private GameObject _viewObject;
    [SerializeField] private Button _button;
    [SerializeField] private Image _image;

    public void UpdateMissionView(MissionInfo missionInfo)
    {
        _numberText.text = missionInfo.NumberText;
    }

    public void CheckState(MissionState missionState)
    {
        switch (missionState)
        {
            case MissionState.Active:
                _viewObject.SetActive(true);
                _button.enabled = true;
                _image.color = Color.white;
                break;
            case MissionState.Blocked:
                _viewObject.SetActive(false);
                break;
            case MissionState.TemporarilyBlocked:
                _viewObject.SetActive(true);
                _button.enabled = false;
                _image.color = Color.gray;
                break;
            case MissionState.Passed:
                _viewObject.SetActive(true);
                _button.enabled = false;
                _image.color = Color.green;
                break;
        }
    }
}
