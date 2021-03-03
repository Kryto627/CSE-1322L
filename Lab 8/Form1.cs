using System;
using System.Windows.Forms;

public partial class MegaCalc : Form {

    public MegaCalc() {
        InitializeComponent();
    }

    //Invoked when the form is loaded.
    private void OnFormLoad(object sender, EventArgs e) { }

    //Invoked when the "add" button is pressed. 
    private void OnAddButtonClick(object sender, EventArgs e) {

        //Colect input from text boxes.
        string input1 = textInput1.Text;
        string input2 = textInput2.Text;

        //Convert inputs to integers. 
        if (!int.TryParse(input1, out int number1)) {
            outputLabel.Text = "Input Error";
            return;
        }

        if (!int.TryParse(input2, out int number2)) {
            outputLabel.Text = "Input Error";
            return;
        }

        //Calculate result and display it to the output label.
        int result = number1 + number2;
        outputLabel.Text = result.ToString();
    }

    //Invoked when the "clear" button is pressed.
    private void OnClearButtonClick(object sender, EventArgs e) {

        //Clears all text boxes and labels.
        textInput1.Text = string.Empty;
        textInput2.Text = string.Empty;
        outputLabel.Text = string.Empty;
    }
}
