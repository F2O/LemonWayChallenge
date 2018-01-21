namespace LemonWayForm
{
    partial class Fibonacci10Form
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
            this.buttonCompute = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBoxXml = new System.Windows.Forms.TextBox();
            this.btnSendXml = new System.Windows.Forms.Button();
            this.txtBoxResultXmltoJson = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCompute
            // 
            this.buttonCompute.Location = new System.Drawing.Point(43, 54);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(195, 59);
            this.buttonCompute.TabIndex = 0;
            this.buttonCompute.Text = "Compute Fibonancci(10)";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(111, 167);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 1;
            // 
            // txtBoxXml
            // 
            this.txtBoxXml.Location = new System.Drawing.Point(51, 256);
            this.txtBoxXml.Multiline = true;
            this.txtBoxXml.Name = "txtBoxXml";
            this.txtBoxXml.Size = new System.Drawing.Size(202, 78);
            this.txtBoxXml.TabIndex = 2;
            // 
            // btnSendXml
            // 
            this.btnSendXml.Location = new System.Drawing.Point(270, 266);
            this.btnSendXml.Name = "btnSendXml";
            this.btnSendXml.Size = new System.Drawing.Size(122, 51);
            this.btnSendXml.TabIndex = 3;
            this.btnSendXml.Text = "Send";
            this.btnSendXml.UseVisualStyleBackColor = true;
            this.btnSendXml.Click += new System.EventHandler(this.btnSendXml_Click);
            // 
            // txtBoxResultXmltoJson
            // 
            this.txtBoxResultXmltoJson.Location = new System.Drawing.Point(51, 368);
            this.txtBoxResultXmltoJson.Multiline = true;
            this.txtBoxResultXmltoJson.Name = "txtBoxResultXmltoJson";
            this.txtBoxResultXmltoJson.ReadOnly = true;
            this.txtBoxResultXmltoJson.Size = new System.Drawing.Size(340, 121);
            this.txtBoxResultXmltoJson.TabIndex = 4;
            // 
            // Fibonacci10Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 511);
            this.Controls.Add(this.txtBoxResultXmltoJson);
            this.Controls.Add(this.btnSendXml);
            this.Controls.Add(this.txtBoxXml);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.buttonCompute);
            this.Name = "Fibonacci10Form";
            this.Text = "FormFibonacci10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtBoxXml;
        private System.Windows.Forms.Button btnSendXml;
        private System.Windows.Forms.TextBox txtBoxResultXmltoJson;
    }
}