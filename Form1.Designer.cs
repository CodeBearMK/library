namespace library
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstvBooks = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.lstBorrow = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imgL = new System.Windows.Forms.ImageList(this.components);
            this.imgS = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lstvBooks
            // 
            this.lstvBooks.HideSelection = false;
            this.lstvBooks.Location = new System.Drawing.Point(12, 22);
            this.lstvBooks.Name = "lstvBooks";
            this.lstvBooks.Size = new System.Drawing.Size(427, 333);
            this.lstvBooks.TabIndex = 0;
            this.lstvBooks.UseCompatibleStateImageBehavior = false;
            this.lstvBooks.ItemActivate += new System.EventHandler(this.lstvBooks_ItemActivate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(493, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "檢視方式：";
            // 
            // cboView
            // 
            this.cboView.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboView.FormattingEnabled = true;
            this.cboView.Location = new System.Drawing.Point(497, 122);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(207, 28);
            this.cboView.TabIndex = 2;
            this.cboView.SelectedIndexChanged += new System.EventHandler(this.cboView_SelectedIndexChanged);
            // 
            // lstBorrow
            // 
            this.lstBorrow.FormattingEnabled = true;
            this.lstBorrow.ItemHeight = 15;
            this.lstBorrow.Location = new System.Drawing.Point(497, 225);
            this.lstBorrow.Name = "lstBorrow";
            this.lstBorrow.Size = new System.Drawing.Size(207, 124);
            this.lstBorrow.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(493, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "借書清單：";
            // 
            // imgL
            // 
            this.imgL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgL.ImageStream")));
            this.imgL.TransparentColor = System.Drawing.Color.Transparent;
            this.imgL.Images.SetKeyName(0, "book1.jpg");
            this.imgL.Images.SetKeyName(1, "book2.jpg");
            this.imgL.Images.SetKeyName(2, "book3.jpg");
            this.imgL.Images.SetKeyName(3, "book4.jpg");
            this.imgL.Images.SetKeyName(4, "book5.jpg");
            this.imgL.Images.SetKeyName(5, "book6.jpg");
            this.imgL.Images.SetKeyName(6, "book7.jpg");
            this.imgL.Images.SetKeyName(7, "book8.jpg");
            // 
            // imgS
            // 
            this.imgS.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgS.ImageStream")));
            this.imgS.TransparentColor = System.Drawing.Color.Transparent;
            this.imgS.Images.SetKeyName(0, "book1.jpg");
            this.imgS.Images.SetKeyName(1, "book2.jpg");
            this.imgS.Images.SetKeyName(2, "book3.jpg");
            this.imgS.Images.SetKeyName(3, "book4.jpg");
            this.imgS.Images.SetKeyName(4, "book5.jpg");
            this.imgS.Images.SetKeyName(5, "book6.jpg");
            this.imgS.Images.SetKeyName(6, "book7.jpg");
            this.imgS.Images.SetKeyName(7, "book8.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBorrow);
            this.Controls.Add(this.cboView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstvBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.ListBox lstBorrow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imgL;
        private System.Windows.Forms.ImageList imgS;
    }
}

