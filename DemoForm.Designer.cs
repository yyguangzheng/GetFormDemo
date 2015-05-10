namespace GetFormDemo
{
    partial class DemoForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureDemo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.tbBottom = new System.Windows.Forms.TextBox();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.tbTop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDemo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDemo
            // 
            this.pictureDemo.Image = global::GetFormDemo.Properties.Resources.image;
            this.pictureDemo.Location = new System.Drawing.Point(13, 13);
            this.pictureDemo.Name = "pictureDemo";
            this.pictureDemo.Size = new System.Drawing.Size(321, 232);
            this.pictureDemo.TabIndex = 0;
            this.pictureDemo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTop);
            this.groupBox1.Controls.Add(this.tbRight);
            this.groupBox1.Controls.Add(this.tbBottom);
            this.groupBox1.Controls.Add(this.tbLeft);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(351, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "截取位置";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left";
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(44, 58);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(45, 21);
            this.tbLeft.TabIndex = 1;
            this.tbLeft.Text = "81";
            this.tbLeft.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // tbBottom
            // 
            this.tbBottom.Location = new System.Drawing.Point(94, 92);
            this.tbBottom.Name = "tbBottom";
            this.tbBottom.Size = new System.Drawing.Size(45, 21);
            this.tbBottom.TabIndex = 2;
            this.tbBottom.Text = "201";
            this.tbBottom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // tbRight
            // 
            this.tbRight.Location = new System.Drawing.Point(144, 58);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(45, 21);
            this.tbRight.TabIndex = 3;
            this.tbRight.Text = "210";
            this.tbRight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // tbTop
            // 
            this.tbTop.Location = new System.Drawing.Point(94, 21);
            this.tbTop.Name = "tbTop";
            this.tbTop.Size = new System.Drawing.Size(45, 21);
            this.tbTop.TabIndex = 4;
            this.tbTop.Text = "150";
            this.tbTop.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bottom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Right";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Top";
            // 
            // pictureCapture
            // 
            this.pictureCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureCapture.Location = new System.Drawing.Point(351, 149);
            this.pictureCapture.Name = "pictureCapture";
            this.pictureCapture.Size = new System.Drawing.Size(215, 96);
            this.pictureCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureCapture.TabIndex = 2;
            this.pictureCapture.TabStop = false;
            // 
            // DemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 264);
            this.Controls.Add(this.pictureCapture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureDemo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "区域截图测试";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.DemoForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDemo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureDemo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTop;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.TextBox tbBottom;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureCapture;
    }
}

