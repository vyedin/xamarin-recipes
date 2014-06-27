Customizing a UISwitch
======================

The <code>UISwitch</code> class contains properties that allow for customization of the color and state of a <code>UISwitch</code> instance. 


Recipe
======

The properties in <code>UISwitch</code> that give control over appearance are <code>On</code>, <code>OnTintColor</code>, and <code>ThumbTintColor</code>.



* <p>Setting the <code>On</code> property to <code>true</code> or <code>false</code> allows you to set the state of the <code>UISwitch</code>. To have the UISwitch start in the on state when a view loads place the following code in your  <code>ViewDidLoad()</code> method:</p>

<pre><code> CustomSwitch.On = false; </code></pre>

* <p>Use the <code>OnTintColor</code> property to set the fill color of the <code>UISwitch</code> while it is in the on state. This lets you set the fill to any <code>UIColor</code>, whether it is built-in or custom. This can be done after any event, but to initialize your <code>UISwitch</code> with this setting, place the following code in your <code>ViewDidLoad()</code> method: </p>

<pre><code>CustomSwitch.OnTintColor = UIColor.Purple;</code></pre>

* <p>Use the <code>TintColor</code> property to set the outline color of the <code>UISwitch</code> while it is in the off state. The following code demonstrates both how to initialize a custom <code>UIColor</code> and set it to be the <code>TintColor</code>: </p> 

<pre><code>UIColor lightP = UIColor.FromRGB (184, 152, 205);
	   CustomSwitch.TintColor = lightP;</code></pre>
		 
* <p>Use the <code>ThumbTintColor</code> property to set the fill color of Thumb slider in your <code>UISwitch</code>. The following code should be placed in your <code>ViewDidLoad()</code> method to initialize the <code>UISwitch</code> with this property:</p>

<pre><code>CustomSwitch.ThumbTintColor = lightP;</code></pre>

* <p>To handle value changes in your <code>UISwith</code> place the following code in your <code>ViewDidLoad()</code> method.</p>


		     <pre><code>CustomSwitch.ValueChanged += delegate {
				//Check to see new value, change Switch Label Accordingly 
				if (CustomSwitch.On) {
				// Handle "On" events here
					SwitchLabel.Text = "Switch is on";
				} else {
				// Handle "Off" events here
					SwitchLabel.Text = "Switch is off";
				}
			   };</code></pre> 
