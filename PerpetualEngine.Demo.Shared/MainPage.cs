using System;
using Xamarin.Forms;
using PerpetualEngine.Forms;
using System.Collections.Generic;

namespace PerpetualEngine.Demo
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Perpetual Engine";

            var toggle = new SwitchSetting("demo_switch", "Demo Switch");
            toggle.OnValueChanged += delegate {
                Msg.Log(this, "toggle changed");
            };
            var username = new TextSetting("username", "Username Input Example");
            username.OnValueChanged += delegate {
                Msg.Log(this, "username changed");
            };
            var fruit = new SelectionSetting("fruit", "Which Fruit?") { Options = new { id1 = "banana", id2 = "apple", id3 = "cookies" }.ToOptions() };
            fruit.OnValueChanged += delegate {
                Msg.Log(this, "fruit changed");
            };
            var car = new SelectionSetting("cars", "Which Car?");

            Content = new TableView {
                HasUnevenRows = true,
                Root = new TableRoot() {
                    new TableSection { toggle, username, fruit, car }
                }
            };
        }
    }

}

