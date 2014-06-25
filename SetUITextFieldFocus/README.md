Recipe 
------

You can manually change the focus of a view to bring up the keyboard for entry in a <code>UITextField</code> without tapping it. 

<p>If you want the <code>UITextField</code>, in this case named <code>FocusTextField</code>, selected as soon as you open your view, place the following line of code in the <code>ViewDidLoad ()</code> method in your view controller:</p>

<pre><code>FocusTextField.BecomeFirstResponder ();</code></pre>

![Focus Screen](/ScreenShots/focusScreenShot.png)

Additional Information
----------------------

You can call <code>BecomeFirstResponder ()</code> on a <code>UITextField</code> at any point to switch focus - not just inside <code>ViewDidLoad ()</code>.
