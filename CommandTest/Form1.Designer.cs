
namespace CommandTest
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.select = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.IncAllAge = new System.Windows.Forms.Button();
            this.IncSomeAge = new System.Windows.Forms.Button();
            this.Rollback = new System.Windows.Forms.Button();
            this.Commit = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.insert1 = new System.Windows.Forms.Button();
            this.insert2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(334, 160);
            this.listBox1.TabIndex = 0;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(366, 12);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(85, 23);
            this.select.TabIndex = 1;
            this.select.Text = "SELECT";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(366, 56);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(85, 23);
            this.update.TabIndex = 2;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(366, 104);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(85, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(366, 149);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(85, 23);
            this.sum.TabIndex = 4;
            this.sum.Text = "SUM";
            this.sum.UseVisualStyleBackColor = true;
            // 
            // IncAllAge
            // 
            this.IncAllAge.Location = new System.Drawing.Point(477, 12);
            this.IncAllAge.Name = "IncAllAge";
            this.IncAllAge.Size = new System.Drawing.Size(85, 23);
            this.IncAllAge.TabIndex = 5;
            this.IncAllAge.Text = "IncAllAge";
            this.IncAllAge.UseVisualStyleBackColor = true;
            // 
            // IncSomeAge
            // 
            this.IncSomeAge.Location = new System.Drawing.Point(477, 56);
            this.IncSomeAge.Name = "IncSomeAge";
            this.IncSomeAge.Size = new System.Drawing.Size(85, 23);
            this.IncSomeAge.TabIndex = 6;
            this.IncSomeAge.Text = "IncSomeAge";
            this.IncSomeAge.UseVisualStyleBackColor = true;
            // 
            // Rollback
            // 
            this.Rollback.Location = new System.Drawing.Point(477, 104);
            this.Rollback.Name = "Rollback";
            this.Rollback.Size = new System.Drawing.Size(85, 23);
            this.Rollback.TabIndex = 7;
            this.Rollback.Text = "Rollback";
            this.Rollback.UseVisualStyleBackColor = true;
            // 
            // Commit
            // 
            this.Commit.Location = new System.Drawing.Point(477, 149);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(85, 23);
            this.Commit.TabIndex = 8;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(51, 191);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(75, 21);
            this.textName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "나이";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(173, 191);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(75, 21);
            this.textAge.TabIndex = 11;
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Location = new System.Drawing.Point(288, 196);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(48, 16);
            this.checkMale.TabIndex = 13;
            this.checkMale.Text = "남자";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // insert1
            // 
            this.insert1.Location = new System.Drawing.Point(18, 236);
            this.insert1.Name = "insert1";
            this.insert1.Size = new System.Drawing.Size(97, 23);
            this.insert1.TabIndex = 14;
            this.insert1.Text = "INSERT1";
            this.insert1.UseVisualStyleBackColor = true;
            // 
            // insert2
            // 
            this.insert2.Location = new System.Drawing.Point(119, 236);
            this.insert2.Name = "insert2";
            this.insert2.Size = new System.Drawing.Size(97, 23);
            this.insert2.TabIndex = 15;
            this.insert2.Text = "INSERT2";
            this.insert2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 278);
            this.Controls.Add(this.insert2);
            this.Controls.Add(this.insert1);
            this.Controls.Add(this.checkMale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.Rollback);
            this.Controls.Add(this.IncSomeAge);
            this.Controls.Add(this.IncAllAge);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.select);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button IncAllAge;
        private System.Windows.Forms.Button IncSomeAge;
        private System.Windows.Forms.Button Rollback;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.Button insert1;
        private System.Windows.Forms.Button insert2;
    }
}

