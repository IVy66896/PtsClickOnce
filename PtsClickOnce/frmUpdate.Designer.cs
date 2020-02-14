namespace PtsClickOnce
{
    partial class frmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PtsClickOnce.frmUpdate));
            pbStatus = new System.Windows.Forms.ProgressBar();
            SuspendLayout();
            pbStatus.Location = new System.Drawing.Point(12, 12);
            pbStatus.Name = "pbStatus";
            pbStatus.Size = new System.Drawing.Size(295, 23);
            pbStatus.TabIndex = 0;
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new System.Drawing.Size(319, 46);
            base.ControlBox = false;
            base.Controls.Add(pbStatus);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "frmUpdate";
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "程式版本更新中，請稍候";
            base.Load += new System.EventHandler(frmUpdate_Load);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ProgressBar pbStatus;
    }
}
