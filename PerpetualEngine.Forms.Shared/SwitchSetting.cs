using System;
using Xamarin.Forms;
using PerpetualEngine.Storage;
using System.Collections.Generic;

namespace PerpetualEngine.Forms
{

    public class SwitchSetting: Setting
    {
        public SwitchSetting(string title, bool defaultValue = false) : base(title, defaultValue ? "on" : "off")
        {
            var layout = (View as StackLayout);
            layout.Orientation = StackOrientation.Horizontal;
            var toggle = new Switch();
            toggle.Toggled += (sender, e) => {
                Value = e.Value ? "on" : "off";
            };
            toggle.IsToggled = Value == "on";
            layout.Children.Add(toggle);

            Tapped += delegate {
                toggle.IsToggled = !toggle.IsToggled;
            };
        }

        protected override bool DescriptionVisible {
            get {
                return false;
            }
        }

    }
}
