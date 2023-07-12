namespace ErrorForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgw_Api = new DataGridView();
            dtw_UI = new DataGridView();
            dgw_Managment = new DataGridView();
            btn_GetInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgw_Api).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtw_UI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Managment).BeginInit();
            SuspendLayout();
            // 
            // dgw_Api
            // 
            dgw_Api.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Api.Location = new Point(12, 12);
            dgw_Api.Name = "dgw_Api";
            dgw_Api.RowHeadersWidth = 51;
            dgw_Api.RowTemplate.Height = 29;
            dgw_Api.Size = new Size(300, 188);
            dgw_Api.TabIndex = 0;
            dgw_Api.CellContentClick += dgw_Api_CellContentClick;
            // 
            // dtw_UI
            // 
            dtw_UI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtw_UI.Location = new Point(318, 12);
            dtw_UI.Name = "dtw_UI";
            dtw_UI.RowHeadersWidth = 51;
            dtw_UI.RowTemplate.Height = 29;
            dtw_UI.Size = new Size(300, 188);
            dtw_UI.TabIndex = 1;
            // 
            // dgw_Managment
            // 
            dgw_Managment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Managment.Location = new Point(624, 12);
            dgw_Managment.Name = "dgw_Managment";
            dgw_Managment.RowHeadersWidth = 51;
            dgw_Managment.RowTemplate.Height = 29;
            dgw_Managment.Size = new Size(300, 188);
            dgw_Managment.TabIndex = 2;
            // 
            // btn_GetInfo
            // 
            btn_GetInfo.Location = new Point(403, 302);
            btn_GetInfo.Name = "btn_GetInfo";
            btn_GetInfo.Size = new Size(150, 29);
            btn_GetInfo.TabIndex = 3;
            btn_GetInfo.Text = "Bilgileri Getir";
            btn_GetInfo.UseVisualStyleBackColor = true;
            btn_GetInfo.Click += btn_GetInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 450);
            Controls.Add(btn_GetInfo);
            Controls.Add(dgw_Managment);
            Controls.Add(dtw_UI);
            Controls.Add(dgw_Api);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgw_Api).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtw_UI).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_Managment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgw_Api;
        private DataGridView dtw_UI;
        private DataGridView dgw_Managment;
        private Button btn_GetInfo;
    }
}