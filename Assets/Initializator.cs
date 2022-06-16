using UnityEngine;
using GameAnalyticsSDK;

public class Initializator : MonoBehaviour
{
    private void Start()
    {
        GameAnalytics.Initialize();
    }
}
