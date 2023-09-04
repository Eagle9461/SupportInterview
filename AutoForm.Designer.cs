namespace SupportInterview
{
    partial class AutoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResult = new TextBox();
            txtPrompt = new TextBox();
            splitContainer = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.Black;
            txtResult.Dock = DockStyle.Fill;
            txtResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.ForeColor = Color.White;
            txtResult.Location = new Point(0, 0);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(742, 266);
            txtResult.TabIndex = 0;
            txtResult.KeyUp += AutoForm_KeyUp;
            // 
            // txtPrompt
            // 
            txtPrompt.BackColor = Color.Black;
            txtPrompt.Dock = DockStyle.Fill;
            txtPrompt.ForeColor = Color.White;
            txtPrompt.Location = new Point(0, 0);
            txtPrompt.Multiline = true;
            txtPrompt.Name = "txtPrompt";
            txtPrompt.Size = new Size(742, 137);
            txtPrompt.TabIndex = 2;
            txtPrompt.KeyUp += AutoForm_KeyUp;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(txtPrompt);
            splitContainer.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(txtResult);
            splitContainer.Panel2.RightToLeft = RightToLeft.No;
            splitContainer.RightToLeft = RightToLeft.No;
            splitContainer.Size = new Size(742, 407);
            splitContainer.SplitterDistance = 137;
            splitContainer.TabIndex = 3;
            splitContainer.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // AutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 407);
            Controls.Add(splitContainer);
            KeyPreview = true;
            Name = "AutoForm";
            Text = "AutoForm";
            FormClosed += AutoForm_FormClosed;
            KeyPress += AutoForm_KeyPress;
            KeyUp += AutoForm_KeyUp;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtResult;
        private TextBox txtPrompt;
        private SplitContainer splitContainer;
    }
}