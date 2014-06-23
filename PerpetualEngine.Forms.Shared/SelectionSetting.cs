using System.Collections.Generic;
using System.Linq;

namespace PerpetualEngine.Forms
{

    public class SelectionSetting: Setting
    {
        public Dictionary<string, string> Options;

        public SelectionSetting(string title) : base(title)
        {
        }

        public override string Value {
            get {
                return base.Value;
            }
            set {
                if (Options.Count == 0)
                    value = "";
                else if (!Options.ContainsKey(value))
                    value = Options.Keys.First();
                base.Value = value;
                Description.Text = Options[value];
            }
        }

    }
    
}