﻿using UnityEngine;
using System.Collections;

public class Component : MonoBehaviour {

    public ComponentType componennt;
    public string description;
    public Sprite image;
    public float price;

    private bool _isAvailable = false;

    public enum ComponentType
    {
        vga,
        hdmi,
    }

    public string ComponentName
    {
        get
        {
            switch (componennt)
            {
                case ComponentType.vga:
                    return "vga";
                case ComponentType.hdmi:
                    return "hdmi";
                default:
                    return "";
            }
        }
    }

    public bool IsAvailabe
    {
        get { return _isAvailable; }
        set { _isAvailable = value; }
    }
}