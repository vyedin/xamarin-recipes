using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Speech.Tts;
using Android.Locations;

namespace TTSDroid
{
	[Activity (Label = "TTSDroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity, TextToSpeech.IOnInitListener
	{
		private TextToSpeech tts;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			tts = new TextToSpeech (this, this);
			tts.SetLanguage (Java.Util.Locale.Us);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button and text field from the layout resource,
			// and attach an event to it
			Button speakButton = FindViewById<Button> (Resource.Id.SpeakButton);
			EditText textToConvert = FindViewById<EditText> (Resource.Id.ToSpeechText);

			speakButton.Click += (object sender, EventArgs e) =>  {
				tts.Speak(textToConvert.Text, QueueMode.Flush, null);
				Console.WriteLine(textToConvert.Text);
			};
		}

		//Implement TextToSpeech OnInit function
		public void OnInit(OperationResult result)
		{
			if (result == OperationResult.Success) {
				tts.SetLanguage (Java.Util.Locale.Us);
			} 
			else {
				Console.Error.WriteLine("TTS Initialization Failed!");
			}
		}
	}
}


