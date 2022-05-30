
namespace FinalTest
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
            this.select = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.btnInsert2 = new System.Windows.Forms.Button();
            this.textDoor = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(448, 461);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(85, 23);
            this.select.TabIndex = 1;
            this.select.Text = "검색";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(448, 403);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(85, 23);
            this.update.TabIndex = 2;
            this.update.Text = "수정";
            this.update.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(448, 432);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "조건검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(51, 414);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(158, 21);
            this.textName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "이름";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(271, 414);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(131, 21);
            this.textAge.TabIndex = 11;
            // 
            // btnInsert2
            // 
            this.btnInsert2.Location = new System.Drawing.Point(448, 374);
            this.btnInsert2.Name = "btnInsert2";
            this.btnInsert2.Size = new System.Drawing.Size(85, 23);
            this.btnInsert2.TabIndex = 15;
            this.btnInsert2.Text = "저장";
            this.btnInsert2.UseVisualStyleBackColor = true;
            this.btnInsert2.Click += new System.EventHandler(this.insert2_Click);
            // 
            // textDoor
            // 
            this.textDoor.Location = new System.Drawing.Point(271, 454);
            this.textDoor.Name = "textDoor";
            this.textDoor.Size = new System.Drawing.Size(131, 21);
            this.textDoor.TabIndex = 16;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(51, 454);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(158, 21);
            this.textPrice.TabIndex = 17;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowDrop = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(41, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 294);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 510);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textDoor);
            this.Controls.Add(this.btnInsert2);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.update);
            this.Controls.Add(this.select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Button btnInsert2;
        private System.Windows.Forms.TextBox textDoor;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.ListView listView1;
    }
}