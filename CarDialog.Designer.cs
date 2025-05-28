namespace LashaMurgvaLominadzeShraieri.Quiz3
{
    partial class CarDialog
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox ModelTextBox;
        private TextBox WeightTextBox;
        private TextBox SpeedTextBox;
        private Button DoneButton;
        private Label modellbl;
        private Label weightLabel;
        private Label speedLabel;

        private void InitializeComponent()
        {
            ModelTextBox = new TextBox();
            WeightTextBox = new TextBox();
            SpeedTextBox = new TextBox();
            DoneButton = new Button();
            modellbl = new Label();
            weightLabel = new Label();
            speedLabel = new Label();
            weightlbl = new Label();
            speedlbl = new Label();
            SuspendLayout();
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(12, 30);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(200, 27);
            ModelTextBox.TabIndex = 0;
            // 
            // WeightTextBox
            // 
            WeightTextBox.Location = new Point(12, 101);
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.Size = new Size(200, 27);
            WeightTextBox.TabIndex = 1;
            // 
            // SpeedTextBox
            // 
            SpeedTextBox.Location = new Point(12, 167);
            SpeedTextBox.Name = "SpeedTextBox";
            SpeedTextBox.Size = new Size(200, 27);
            SpeedTextBox.TabIndex = 2;
            // 
            // DoneButton
            // 
            DoneButton.Location = new Point(26, 215);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(200, 30);
            DoneButton.TabIndex = 3;
            DoneButton.Text = "Done";
            DoneButton.Click += DoneButton_Click;
            // 
            // modellbl
            // 
            modellbl.Location = new Point(0, 0);
            modellbl.Name = "modellbl";
            modellbl.Size = new Size(100, 23);
            modellbl.TabIndex = 4;
            modellbl.Text = "Model";
            // 
            // weightLabel
            // 
            weightLabel.Location = new Point(0, 0);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(100, 23);
            weightLabel.TabIndex = 5;
            weightLabel.Text = "Weight";
            // 
            // speedLabel
            // 
            speedLabel.Location = new Point(0, 0);
            speedLabel.Name = "speedLabel";
            speedLabel.Size = new Size(100, 23);
            speedLabel.TabIndex = 6;
            speedLabel.Text = "Speed";
            // 
            // weightlbl
            // 
            weightlbl.AutoSize = true;
            weightlbl.Location = new Point(0, 78);
            weightlbl.Name = "weightlbl";
            weightlbl.Size = new Size(56, 20);
            weightlbl.TabIndex = 7;
            weightlbl.Text = "Weight";
            // 
            // speedlbl
            // 
            speedlbl.AutoSize = true;
            speedlbl.Location = new Point(0, 144);
            speedlbl.Name = "speedlbl";
            speedlbl.Size = new Size(51, 20);
            speedlbl.TabIndex = 8;
            speedlbl.Text = "Speed";
            // 
            // CarDialog
            // 
            ClientSize = new Size(263, 257);
            Controls.Add(speedlbl);
            Controls.Add(weightlbl);
            Controls.Add(ModelTextBox);
            Controls.Add(WeightTextBox);
            Controls.Add(SpeedTextBox);
            Controls.Add(DoneButton);
            Controls.Add(modellbl);
            Controls.Add(weightLabel);
            Controls.Add(speedLabel);
            Name = "CarDialog";
            Text = "Car Dialog";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label weightlbl;
        private Label speedlbl;
    }
}
