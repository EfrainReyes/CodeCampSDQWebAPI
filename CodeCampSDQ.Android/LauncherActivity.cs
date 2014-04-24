using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CodeCampSDQ.Android
{
    [Activity(Label = "CodeCampSDQ", MainLauncher = true, Icon = "@drawable/icon")]
    public class LauncherActivity : Activity
    {
        private int countPrev = 0;
        private int countNext = 0;

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button prev;
            Button next;
            TextView text;

            // Get our button from the layout resource,
            // and attach an event to it

            prev = FindViewById<Button>(Resource.Id.buttonPrev);
            next = FindViewById<Button>(Resource.Id.buttonNext);
            text = FindViewById<TextView>(Resource.Id.textViewTest);

            prev.Click += (sender, args) => {
                text.Text = string.Format("Clicks a botón Prev: {0}", ++countPrev);
            };

            next.Click += (sender, args) => {
                text.Text = string.Format("Clicks a botón Next: {0}", ++countNext);
            };

            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

