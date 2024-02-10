namespace lb1gui;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.opacityButton = new System.Windows.Forms.Button();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.helloWorldButton = new System.Windows.Forms.Button();
            this.superButton = new System.Windows.Forms.Button();
            this.superOpacityCheckBox = new System.Windows.Forms.CheckBox();
            this.superBackgroundColorCheckbox = new System.Windows.Forms.CheckBox();
            this.superHelloWorldCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // opacityButton
            // 
            this.opacityButton.Location = new System.Drawing.Point(12, 12);
            this.opacityButton.Name = "opacityButton";
            this.opacityButton.Size = new System.Drawing.Size(134, 34);
            this.opacityButton.TabIndex = 0;
            this.opacityButton.Text = "Opacity";
            this.opacityButton.UseVisualStyleBackColor = true;
            this.opacityButton.Click += new System.EventHandler(this.HandleToggleOpacity);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(152, 12);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(134, 34);
            this.backgroundColorButton.TabIndex = 1;
            this.backgroundColorButton.Text = "Bg color";
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.HandleToggleBackground);
            // 
            // helloWorldButton
            // 
            this.helloWorldButton.Location = new System.Drawing.Point(292, 12);
            this.helloWorldButton.Name = "helloWorldButton";
            this.helloWorldButton.Size = new System.Drawing.Size(134, 34);
            this.helloWorldButton.TabIndex = 2;
            this.helloWorldButton.Text = "Hello wrld";
            this.helloWorldButton.UseVisualStyleBackColor = true;
            this.helloWorldButton.Click += new System.EventHandler(this.HandleOpenHelloWorld);
            // 
            // superButton
            // 
            this.superButton.Location = new System.Drawing.Point(12, 65);
            this.superButton.Name = "superButton";
            this.superButton.Size = new System.Drawing.Size(414, 34);
            this.superButton.TabIndex = 3;
            this.superButton.Text = "super";
            this.superButton.UseVisualStyleBackColor = true;
            this.superButton.Click += new System.EventHandler(this.HandleSuperButtonClick);
            // 
            // superOpacityCheckBox
            // 
            this.superOpacityCheckBox.AutoSize = true;
            this.superOpacityCheckBox.Location = new System.Drawing.Point(12, 117);
            this.superOpacityCheckBox.Name = "superOpacityCheckBox";
            this.superOpacityCheckBox.Size = new System.Drawing.Size(149, 19);
            this.superOpacityCheckBox.TabIndex = 4;
            this.superOpacityCheckBox.Text = "\"super\" toggles opacity";
            this.superOpacityCheckBox.UseVisualStyleBackColor = true;
            this.superOpacityCheckBox.CheckedChanged += new System.EventHandler(this.HandleSuperOpacityChange);
            // 
            // superBackgroundColorCheckbox
            // 
            this.superBackgroundColorCheckbox.AutoSize = true;
            this.superBackgroundColorCheckbox.Location = new System.Drawing.Point(12, 142);
            this.superBackgroundColorCheckbox.Name = "superBackgroundColorCheckbox";
            this.superBackgroundColorCheckbox.Size = new System.Drawing.Size(154, 19);
            this.superBackgroundColorCheckbox.TabIndex = 5;
            this.superBackgroundColorCheckbox.Text = "\"super\" toggles bg color";
            this.superBackgroundColorCheckbox.UseVisualStyleBackColor = true;
            this.superBackgroundColorCheckbox.CheckedChanged += new System.EventHandler(this.HandleSuperBackgroundChange);
            // 
            // superHelloWorldCheckbox
            // 
            this.superHelloWorldCheckbox.AutoSize = true;
            this.superHelloWorldCheckbox.Location = new System.Drawing.Point(12, 167);
            this.superHelloWorldCheckbox.Name = "superHelloWorldCheckbox";
            this.superHelloWorldCheckbox.Size = new System.Drawing.Size(207, 19);
            this.superHelloWorldCheckbox.TabIndex = 6;
            this.superHelloWorldCheckbox.Text = "\"super\" toggles hello wrld window";
            this.superHelloWorldCheckbox.UseVisualStyleBackColor = true;
            this.superHelloWorldCheckbox.CheckedChanged += new System.EventHandler(this.HandleSuperHelloWorldOpen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.superHelloWorldCheckbox);
            this.Controls.Add(this.superBackgroundColorCheckbox);
            this.Controls.Add(this.superOpacityCheckBox);
            this.Controls.Add(this.superButton);
            this.Controls.Add(this.helloWorldButton);
            this.Controls.Add(this.backgroundColorButton);
            this.Controls.Add(this.opacityButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button opacityButton;
    private Button backgroundColorButton;
    private Button helloWorldButton;
    private Button superButton;
    private CheckBox superOpacityCheckBox;
    private CheckBox superBackgroundColorCheckbox;
    private CheckBox superHelloWorldCheckbox;
}