namespace lb1gui;

public partial class Form1 : Form
{
    private Dictionary<string, Action> actions;
    private Color CustomDefaultBackColor = DefaultBackColor;
    private Color ToggleBackColor = Color.Green;
    private Action SuperAction = () => { };

    public Form1()
    {
        BackColor = CustomDefaultBackColor;
        
        this.actions = new()
        {
            {"toggleOpacity", () => Opacity = Opacity == 1 ? 0.5 : 1 },
            {"toggleBackgroundColor", () => BackColor = BackColor == CustomDefaultBackColor ? ToggleBackColor : CustomDefaultBackColor },
            {"openHelloWorld", () => MessageBox.Show("text") },
        };

        
        InitializeComponent();
    }
}