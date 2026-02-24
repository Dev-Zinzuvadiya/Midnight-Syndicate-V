using GTA;
using GTA.UI;
using GTA.Math;
using NativeUI;
using GTA.Native;
using System.Drawing;
using System.Windows.Forms;
using System;

public class MidnightSyndicateV : Script
{
    public MidnightSyndicateV()
    {
        Tick += OnTick;
        KeyUp += OnKeyUp;
        Aborted += OnAbort;
        Interval = 20;
    }

    private void OnTick(object sender, EventArgs e)
    {
    }

    private void OnKeyUp(object sender, KeyEventArgs e)
    {
    }

    private void OnAbort(object sender, EventArgs e)
    {
    }
}