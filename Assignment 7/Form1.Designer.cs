using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

partial class Form1 {

    private IContainer components = null;

    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent() {
        this.SuspendLayout();
        this.AutoScaleDimensions = new SizeF(6F, 13F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(284, 261);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = "Form1";
        this.Text = "Form1";
        this.ResumeLayout(false);
    }
}
