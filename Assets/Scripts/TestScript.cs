using System;
using System.Collections;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    
    public void RunTest()
    {
        GetStats();
    }

    public void GetStats() 
    {
        PlayFab.PlayFabClientAPI.GetPlayerStatistics(new GetPlayerStatisticsRequest(), 
        OnGetStats, OnSharedError);
    }

    private void OnSharedError(PlayFabError obj)
    {
        Debug.Log(obj.GenerateErrorReport());
    }

    private void OnGetStats(GetPlayerStatisticsResult result)
    {
        Debug.Log("Received the following Statistics:");
        foreach(var eachStat in result.Statistics)
        {
            Debug.Log("Statistic (" + eachStat.StatisticName + "):" + eachStat.Value);
        }
    }
}
