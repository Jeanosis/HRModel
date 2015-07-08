namespace GraphicClient
{
    partial class ClientForm
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
            this.textBoxRequestedName = new System.Windows.Forms.TextBox();
            this.labelRequestedName = new System.Windows.Forms.Label();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRequestedName
            // 
            this.textBoxRequestedName.Location = new System.Drawing.Point(12, 28);
            this.textBoxRequestedName.Name = "textBoxRequestedName";
            this.textBoxRequestedName.Size = new System.Drawing.Size(163, 20);
            this.textBoxRequestedName.TabIndex = 0;
            // 
            // labelRequestedName
            // 
            this.labelRequestedName.AutoSize = true;
            this.labelRequestedName.Location = new System.Drawing.Point(12, 9);
            this.labelRequestedName.Name = "labelRequestedName";
            this.labelRequestedName.Size = new System.Drawing.Size(91, 13);
            this.labelRequestedName.TabIndex = 1;
            this.labelRequestedName.Text = "Requested name:";
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(181, 26);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonRequest.TabIndex = 2;
            this.buttonRequest.Text = "Request";
            this.buttonRequest.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 67);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(244, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(9, 51);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(66, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Query result:";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 102);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.labelRequestedName);
            this.Controls.Add(this.textBoxRequestedName);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRequestedName;
        private System.Windows.Forms.Label labelRequestedName;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
    }
}

