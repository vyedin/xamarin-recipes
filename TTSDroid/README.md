Convert Text to Speech in Android
===============================

This recipe illustrates a way of converting text to speech in Android, using the built in TTS library.

![layout](/TTSDroid/Screenshots/01.png)

Recipe
======
![layout in designer](/TTSDroid/Screenshots/02.png)
<ol>
<li>
<p>First, we'll open our layout file in the Android designer and drag three controls onto the design surface--a Text (Large), a Plain Text field, and a Button. We'll edit the properties to give each control an appropriate name, as illustrated in the screenshot above.</p>
</li>

<li>
<p>Next, in our backing Activity, we'll start by including the Android text to speech library:</p>
<pre><code>
using Android.Speech.Tts;
</code></pre>

<p>Now, we can delcare a <code>TextToSpeech</code> object as a member of our <code>MainActivity</code> class.</p>
<pre><code>
private TextToSpeech tts;
</code></pre>

<p>In order for our <code>TextToSpeech</code> instance to work, it needs to have an <code>IOnInitListener</code>. Let's have our <code>MainActivity</code> class implement <code>TextToSpeech.IOnInitListener</code>.
<pre><code>
public class MainActivity : Activity, TextToSpeech.IOnInitListener
</code></pre>

<p>Then, in our <code>OnCreate</code> method, we can instantiate <code>tts</code>, passing the <code>MainActivity</code> class as the <code>context</code> and the <code>IOnInitListener</code>.</p>
<pre><code>
tts = new TextToSpeech(this, this);
tts.SetLanguage(Java.Util.Locale.Us);
</code></pre>
</li>

<li>
<p>Now that our <code>MainActivity</code> class implements <code>IOnInitListener</code>, we need to create the <code>OnInit</code> method required by that interface.</p>
<pre><code>
public void OnInit(OperationResult result)
{
	if (result == OperationResult.Success) {
		tts.SetLanguage (Java.Util.Locale.Us);
	} 
	else {
		Console.Error.WriteLine("TTS Initialization Failed!");
	}
}
</code></pre>
</li>

<li>
<p>Finally, in our <code>OnCreate</code> method, we will get references to our <code>Button</code> and <code>EditText</code> objects we created in the designer.</p>
<pre><code>
Button speakButton = FindViewById<Button> (Resource.Id.SpeakButton);
EditText textToConvert = FindViewById<EditText> (Resource.Id.ToSpeechText);
</code></pre>

<p>We will also wire up our <code>speakButton</code> to convert the entered text to audio.</p>
<pre><code>
speakButton.Click += (object sender, EventArgs e) =>  {
	tts.Speak(textToConvert.Text, QueueMode.Flush, null);
};
</code></pre>
</li>

<li>
</li>
</ol>
