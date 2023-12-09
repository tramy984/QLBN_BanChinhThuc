namespace QLBN
{
    partial class fBenhnhancu
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
            SuspendLayout();
            // 
            // btnHD
            // 
            btnHD.Click += btnHD_Click;
            // 
            // btnTK
            // 
            btnTK.Click += btnTK_Click_1;
            // 
            // txbTK
            // 
            txbTK.TextChanged += txbTK_TextChanged;
            // 
            // fBNCU
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1989, 1133);
            Name = "fBNCU";
            Text = "Danh sách bệnh nhân cũ";
            ResumeLayout(false);
        }

        #endregion
    }
}