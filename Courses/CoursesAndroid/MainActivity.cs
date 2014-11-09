using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CoursesAndroid
{
    [Activity(Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;
        ImageView imageCourse;
        TextView textDescription;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            textTitle = FindViewById<TextView>(Resource.Id.textTitle);
            imageCourse = FindViewById<ImageView>(Resource.Id.imageCourse);
            textDescription = FindViewById<TextView>(Resource.Id.textDescription);

            buttonPrev.Click += buttonPrev_Click;
            buttonNext.Click += buttonNext_Click;
        }

        void buttonPrev_Click(object sender, EventArgs e)
        {
            textTitle.Text = "Prev Cicked";
            textDescription.Text = "the description that apppears when Prev is clicked";
            imageCourse.SetImageResource(Resource.Drawable.instructor1);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            textTitle.Text = "Next Clicked";
            textDescription.Text = "the description that apppears when Next is clicked";
            imageCourse.SetImageResource(Resource.Drawable.instructor2);
        }
    }
}

