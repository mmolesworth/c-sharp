using System;
using System.Windows;
using System.Windows.Forms;

public class WindowTestApp
{
	[STAThread]
	public static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new MyWindow());

	}
}


public class MyWindow : Form
{

	int state = 0;

	public MyWindow()
	{
		Button b = new Button();
		b.Text = "Click Me";
		
		this.Controls.Add(b);
		b.Click += new EventHandler(this.MyButton_Click);

	}

	void MyButton_Click(Object sender, EventArgs e)
    	{
	        // When the button is clicked,
        	// change the button text, and disable it.

	        Button clickedButton = (Button)sender;
        	
		if(this.state == 0)
		{
			clickedButton.Text = "Hello";
			state = 1;

		}
		else
		{
			clickedButton.Text = "Goodbye";
			state = 0;
		}
        	
    	}

}