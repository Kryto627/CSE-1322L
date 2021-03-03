using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

partial class MegaCalc {

    private IContainer components = null;
    private TextBox textInput1;
    private TextBox textInput2;
    private Button button1;
    private Button button2;
    private Label outputLabel;

    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent() {

        this.textInput1 = new TextBox();
        this.textInput2 = new TextBox();
        this.button1 = new Button();
        this.button2 = new Button();
        this.outputLabel = new Label();
        this.SuspendLayout();

        this.textInput1.Location = new Point(12, 55);
        this.textInput1.Name = "textInput1";
        this.textInput1.Size = new Size(100, 20);
        this.textInput1.TabIndex = 0;

        this.textInput2.Location = new Point(272, 55);
        this.textInput2.Name = "textInput2";
        this.textInput2.Size = new Size(100, 20);
        this.textInput2.TabIndex = 1;

        this.button1.Location = new Point(153, 52);
        this.button1.Name = "button1";
        this.button1.Size = new Size(75, 23);
        this.button1.TabIndex = 2;
        this.button1.Text = "+";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new EventHandler(this.OnAddButtonClick);

        this.button2.Location = new Point(153, 198);
        this.button2.Name = "button2";
        this.button2.Size = new Size(75, 23);
        this.button2.TabIndex = 3;
        this.button2.Text = "Clear";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new EventHandler(this.OnClearButtonClick);

        this.outputLabel.AutoSize = true;
        this.outputLabel.Location = new Point(173, 141);
        this.outputLabel.Name = "outputLabel";
        this.outputLabel.Size = new Size(0, 13);
        this.outputLabel.TabIndex = 4;

        this.AutoScaleDimensions = new SizeF(6F, 13F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(384, 261);
        this.Controls.Add(this.outputLabel);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.textInput2);
        this.Controls.Add(this.textInput1);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = "MegaCalc";
        this.Text = "MegaCalc";
        this.Load += new EventHandler(this.OnFormLoad);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}