namespace lb1gui;

public partial class Form1
{
    private void UseAction(string actionName, bool isChecked)
    {
        if (isChecked)
        {
            SuperAction += actions[actionName];
        }
        else
        {
            SuperAction -= actions[actionName];
        }
    }

    private void HandleSuperOpacityChange(object sender, EventArgs e)
    {
        UseAction("toggleOpacity", superOpacityCheckBox.Checked);
    }
    
    private void HandleSuperBackgroundChange(object sender, EventArgs e)
    {
        UseAction("toggleBackgroundColor", superBackgroundColorCheckbox.Checked);
    }

    private void HandleSuperHelloWorldOpen(object sender, EventArgs e)
    {
        UseAction("openHelloWorld", superHelloWorldCheckbox.Checked);
    }
}