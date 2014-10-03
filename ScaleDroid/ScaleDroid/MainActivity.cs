using System;

using Android.App;
using Android.OS;
using Android.Views.Animations;
using Android.Widget;
using Android.Animation;

namespace ScaleDroid
{
	[Activity (Label = "ScaleDroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		bool isImageLarge = false;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			ImageView imageToScale= FindViewById<ImageView> (Resource.Id.imageToScale);
			Button scaleButton = FindViewById<Button> (Resource.Id.scaleButton);
			ValueAnimator growAnimator = ValueAnimator.OfFloat(1.0f, 3.0f);
			growAnimator.SetDuration(1000);
			growAnimator.Update += (object sender, ValueAnimator.AnimatorUpdateEventArgs e) => {
				imageToScale.ScaleX = (float) e.Animation.AnimatedValue;
				imageToScale.ScaleY = (float) e.Animation.AnimatedValue;
			};
			// Get our button from the layout resource,
			// and attach an event to it
			
			scaleButton.Click+= (object sender, EventArgs e) => {
				if(isImageLarge) {
					growAnimator.Reverse();
					isImageLarge = false;
					scaleButton.Text = "Grow Image!";
				}
				else {
					growAnimator.Resume();
					isImageLarge = true;
					scaleButton.Text = "Shrink Image!";
				}
			};
		}
	}
}


