namespace lb1gui;

public partial class Form1
{
    private void HandleToggleOpacity(object sender, EventArgs e)
    {
        actions["toggleOpacity"]();
    }

    private void HandleToggleBackground(object sender, EventArgs e)
    {
        actions["toggleBackgroundColor"]();
    }
    
    private void HandleOpenHelloWorld(object sender, EventArgs e)
    {
        actions["openHelloWorld"]();
    }

    private void HandleSuperButtonClick(object sender, EventArgs e)
    {
        MessageBox.Show("super");
        SuperAction();
    }
}