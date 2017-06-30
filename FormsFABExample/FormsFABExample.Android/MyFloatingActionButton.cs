using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;

namespace FormsFABExample.Droid
{
    public class MyFloatingActionButton : FloatingActionButton
    {
        private bool isClicked = true;
        public bool ToggleSwitch
        {
            get
            {
                return isClicked;
            }
            set
            {
                isClicked = value;
            }
        }

        public MyFloatingActionButton(Context context) : base(context)
        {
            this.Click += OnButtonClicked;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            //Some sort of event to trigger a change
            ToggleSwitch = !isClicked;
        }
    }
}