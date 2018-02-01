namespace WeatherApp_CS
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAnnounce = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelWeather = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTempHigh = new System.Windows.Forms.Label();
            this.labelTempLow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPrecipi01 = new System.Windows.Forms.Label();
            this.labelPrecipi02 = new System.Windows.Forms.Label();
            this.labelPrecipi03 = new System.Windows.Forms.Label();
            this.labelPrecipi04 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.Location = new System.Drawing.Point(10, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(70, 14);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "labelTitle";
            // 
            // labelAnnounce
            // 
            this.labelAnnounce.AutoSize = true;
            this.labelAnnounce.Location = new System.Drawing.Point(10, 40);
            this.labelAnnounce.Name = "labelAnnounce";
            this.labelAnnounce.Size = new System.Drawing.Size(79, 12);
            this.labelAnnounce.TabIndex = 1;
            this.labelAnnounce.Text = "labelAnnounce";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(10, 70);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 12);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "labelDate";
            // 
            // labelWeather
            // 
            this.labelWeather.AutoSize = true;
            this.labelWeather.Location = new System.Drawing.Point(10, 90);
            this.labelWeather.Name = "labelWeather";
            this.labelWeather.Size = new System.Drawing.Size(70, 12);
            this.labelWeather.TabIndex = 3;
            this.labelWeather.Text = "labelWeather";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // labelTempHigh
            // 
            this.labelTempHigh.AutoSize = true;
            this.labelTempHigh.Location = new System.Drawing.Point(10, 170);
            this.labelTempHigh.Name = "labelTempHigh";
            this.labelTempHigh.Size = new System.Drawing.Size(80, 12);
            this.labelTempHigh.TabIndex = 5;
            this.labelTempHigh.Text = "labelTempHigh";
            // 
            // labelTempLow
            // 
            this.labelTempLow.AutoSize = true;
            this.labelTempLow.Location = new System.Drawing.Point(10, 190);
            this.labelTempLow.Name = "labelTempLow";
            this.labelTempLow.Size = new System.Drawing.Size(77, 12);
            this.labelTempLow.TabIndex = 6;
            this.labelTempLow.Text = "labelTempLow";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "時間帯";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "00-06";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "06-12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "12-18";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "18-24";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "降水確率";
            // 
            // labelPrecipi01
            // 
            this.labelPrecipi01.AutoSize = true;
            this.labelPrecipi01.Location = new System.Drawing.Point(70, 240);
            this.labelPrecipi01.Name = "labelPrecipi01";
            this.labelPrecipi01.Size = new System.Drawing.Size(23, 12);
            this.labelPrecipi01.TabIndex = 13;
            this.labelPrecipi01.Text = "---";
            this.labelPrecipi01.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPrecipi02
            // 
            this.labelPrecipi02.AutoSize = true;
            this.labelPrecipi02.Location = new System.Drawing.Point(110, 240);
            this.labelPrecipi02.Name = "labelPrecipi02";
            this.labelPrecipi02.Size = new System.Drawing.Size(23, 12);
            this.labelPrecipi02.TabIndex = 14;
            this.labelPrecipi02.Text = "---";
            this.labelPrecipi02.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPrecipi03
            // 
            this.labelPrecipi03.AutoSize = true;
            this.labelPrecipi03.Location = new System.Drawing.Point(150, 240);
            this.labelPrecipi03.Name = "labelPrecipi03";
            this.labelPrecipi03.Size = new System.Drawing.Size(23, 12);
            this.labelPrecipi03.TabIndex = 15;
            this.labelPrecipi03.Text = "---";
            this.labelPrecipi03.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPrecipi04
            // 
            this.labelPrecipi04.AutoSize = true;
            this.labelPrecipi04.Location = new System.Drawing.Point(190, 240);
            this.labelPrecipi04.Name = "labelPrecipi04";
            this.labelPrecipi04.Size = new System.Drawing.Size(23, 12);
            this.labelPrecipi04.TabIndex = 16;
            this.labelPrecipi04.Text = "---";
            this.labelPrecipi04.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelPrecipi04);
            this.Controls.Add(this.labelPrecipi03);
            this.Controls.Add(this.labelPrecipi02);
            this.Controls.Add(this.labelPrecipi01);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTempLow);
            this.Controls.Add(this.labelTempHigh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelWeather);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelAnnounce);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAnnounce;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelWeather;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTempHigh;
        private System.Windows.Forms.Label labelTempLow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPrecipi01;
        private System.Windows.Forms.Label labelPrecipi02;
        private System.Windows.Forms.Label labelPrecipi03;
        private System.Windows.Forms.Label labelPrecipi04;
    }
}

