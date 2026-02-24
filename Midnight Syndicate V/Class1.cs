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
    private MenuPool pool;
    private UIMenu mainmenu;

    public MidnightSyndicateV()
    {
        Tick += OnTick;
        KeyUp += OnKeyUp;
        Aborted += OnAbort;
        Interval = 20;

        pool = new MenuPool();

        CREATE_WHOLE_EVENT_HANDLER_MENU();
        //INI_FILE_CONTROLLER();
    }

    private void OnTick(object sender, EventArgs e)
    {
    }

    private void OnKeyUp(object sender, KeyEventArgs e)
    {
        if(e.KeyCode == Keys.J && e.Shift)
        {
            mainmenu.Visible = !mainmenu.Visible;
        }
    }

    private void OnAbort(object sender, EventArgs e)
    {
    }


    private void CREATE_WHOLE_EVENT_HANDLER_MENU()
    {
        mainmenu = new UIMenu("Midnight Syndicate V", "MAIN OPTIONS");
        pool.Add(mainmenu);

        var Direction_of_Freeway = new UIMenuItem("Waypoint set to Freeway Race.", "Freeway Race location will be mark on your map");
        var Direction_of_Street = new UIMenuItem("Waypoint set to Street Race.", "Street Race location will be mark on your map");


        mainmenu.AddItem(Direction_of_Freeway);
        mainmenu.AddItem(Direction_of_Street);


        mainmenu.OnItemSelect += (sender, item, index) =>
        {
            Ped player = Game.Player.Character;

            if (item == Direction_of_Freeway) { }
            if (item == Direction_of_Street) { }
        };
    }
}