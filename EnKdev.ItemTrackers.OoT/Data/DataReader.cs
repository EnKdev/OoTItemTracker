﻿using System;
using System.IO;
using System.Windows;
using EnKdev.ItemTrackers.OoT.Internal;
using EnKdev.ItemTrackers.OoT.Models;
using Newtonsoft.Json;

namespace EnKdev.ItemTrackers.OoT.Data;

public static class DataReader
{
    public static TrackerData? ReadData()
    {
        var parsedData = new TrackerData();

        try
        {
            var contents = File.ReadAllText($"./trackerState");
            var data = CryptoHelper.DecodeAndDecrypt(contents);
            parsedData = JsonConvert.DeserializeObject<TrackerData>(data);

            if (parsedData == null)
            {
                MessageBox.Show("Something went wrong with reading the saved data!");
                parsedData = null;
            }

        }
        catch (Exception ex)
        {
            Logger.LogException(ex);
        }

        return parsedData;
    }
}