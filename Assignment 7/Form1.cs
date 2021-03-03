using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form {

    public Form1() {
        InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);

        //Create needed graphic variables.
        Graphics graphics = e.Graphics;
        Color penColor;
        Pen pen;

        //Draws red stripe.
        for (int y = 0; y < 255; y++) {
            penColor = Color.FromArgb(y, 0, 0);
            pen = new Pen(penColor);
            graphics.DrawLine(pen, 10, y, 50, y);
        }

        //Draws green stripe.
        for (int y = 0; y < 255; y++) {
            penColor = Color.FromArgb(0, y, 0);
            pen = new Pen(penColor);
            graphics.DrawLine(pen, 60, y, 100, y);
        }

        //Draws blue stripe.
        for (int y = 0; y < 255; y++) {
            penColor = Color.FromArgb(0, 0, y);
            pen = new Pen(penColor);
            graphics.DrawLine(pen, 110, y, 150, y);
        }

        //Draws purple stripe.
        for (int y = 0; y < 255; y++) {
            penColor = Color.FromArgb(y, 0, y);
            pen = new Pen(penColor);
            graphics.DrawLine(pen, 160, y, 200, y);
        }

        //Draws white stripe.
        for (int y = 0; y < 255; y++) {
            penColor = Color.FromArgb(y, y, y);
            pen = new Pen(penColor);
            graphics.DrawLine(pen, 210, y, 250, y);
        }
    }
}