namespace windowform_day2_example2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_group = new System.Windows.Forms.TextBox();
            this.tb_borrowdate = new System.Windows.Forms.TextBox();
            this.tb_rerturndate = new System.Windows.Forms.TextBox();
            this.cb_age = new System.Windows.Forms.ComboBox();
            this.cb_books = new System.Windows.Forms.ComboBox();
            this.lb_kinds = new System.Windows.Forms.ListBox();
            this.lb_book = new System.Windows.Forms.ListBox();
            this.b_enter = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.borrow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.b_enter);
            this.groupBox1.Controls.Add(this.lb_book);
            this.groupBox1.Controls.Add(this.lb_kinds);
            this.groupBox1.Controls.Add(this.cb_books);
            this.groupBox1.Controls.Add(this.cb_age);
            this.groupBox1.Controls.Add(this.tb_rerturndate);
            this.groupBox1.Controls.Add(this.tb_borrowdate);
            this.groupBox1.Controls.Add(this.tb_group);
            this.groupBox1.Controls.Add(this.tb_phone);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(48, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(58, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(33, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "연령대 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(58, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "성별 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(8, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "대여도서 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(481, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "반납일자 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(481, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "대여일자 : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(510, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "소   속 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(506, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 31);
            this.label9.TabIndex = 5;
            this.label9.Text = "연락처 : ";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(152, 42);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(199, 39);
            this.tb_id.TabIndex = 9;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(152, 87);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(199, 39);
            this.tb_name.TabIndex = 10;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(625, 36);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(240, 39);
            this.tb_phone.TabIndex = 11;
            // 
            // tb_group
            // 
            this.tb_group.Location = new System.Drawing.Point(625, 85);
            this.tb_group.Name = "tb_group";
            this.tb_group.Size = new System.Drawing.Size(240, 39);
            this.tb_group.TabIndex = 12;
            // 
            // tb_borrowdate
            // 
            this.tb_borrowdate.Location = new System.Drawing.Point(625, 134);
            this.tb_borrowdate.Name = "tb_borrowdate";
            this.tb_borrowdate.ReadOnly = true;
            this.tb_borrowdate.Size = new System.Drawing.Size(240, 39);
            this.tb_borrowdate.TabIndex = 13;
            this.tb_borrowdate.TextChanged += new System.EventHandler(this.tb_borrowdate_TextChanged);
            // 
            // tb_rerturndate
            // 
            this.tb_rerturndate.Location = new System.Drawing.Point(625, 184);
            this.tb_rerturndate.Name = "tb_rerturndate";
            this.tb_rerturndate.ReadOnly = true;
            this.tb_rerturndate.Size = new System.Drawing.Size(240, 39);
            this.tb_rerturndate.TabIndex = 14;
            // 
            // cb_age
            // 
            this.cb_age.FormattingEnabled = true;
            this.cb_age.Location = new System.Drawing.Point(152, 141);
            this.cb_age.Name = "cb_age";
            this.cb_age.Size = new System.Drawing.Size(199, 39);
            this.cb_age.TabIndex = 16;
            this.cb_age.SelectedIndexChanged += new System.EventHandler(this.cb_age_SelectedIndexChanged);
            // 
            // cb_books
            // 
            this.cb_books.FormattingEnabled = true;
            this.cb_books.Location = new System.Drawing.Point(152, 258);
            this.cb_books.Name = "cb_books";
            this.cb_books.Size = new System.Drawing.Size(150, 39);
            this.cb_books.TabIndex = 17;
            this.cb_books.SelectedIndexChanged += new System.EventHandler(this.cb_books_SelectedIndexChanged);
            // 
            // lb_kinds
            // 
            this.lb_kinds.FormattingEnabled = true;
            this.lb_kinds.ItemHeight = 31;
            this.lb_kinds.Location = new System.Drawing.Point(308, 258);
            this.lb_kinds.Name = "lb_kinds";
            this.lb_kinds.Size = new System.Drawing.Size(278, 159);
            this.lb_kinds.TabIndex = 18;
            this.lb_kinds.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lb_book
            // 
            this.lb_book.FormattingEnabled = true;
            this.lb_book.ItemHeight = 31;
            this.lb_book.Location = new System.Drawing.Point(615, 258);
            this.lb_book.Name = "lb_book";
            this.lb_book.Size = new System.Drawing.Size(292, 159);
            this.lb_book.TabIndex = 19;
            this.lb_book.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // b_enter
            // 
            this.b_enter.ForeColor = System.Drawing.Color.Black;
            this.b_enter.Location = new System.Drawing.Point(913, 268);
            this.b_enter.Name = "b_enter";
            this.b_enter.Size = new System.Drawing.Size(174, 53);
            this.b_enter.TabIndex = 20;
            this.b_enter.Text = "등록";
            this.b_enter.UseVisualStyleBackColor = true;
            this.b_enter.Click += new System.EventHandler(this.b_enter_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(152, 196);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 35);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "남성";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(247, 198);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 35);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "여성";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(50, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 31);
            this.label10.TabIndex = 23;
            this.label10.Text = "대여 현황";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.age,
            this.sex,
            this.phone,
            this.group,
            this.borrow,
            this._return,
            this.book});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(57, 536);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1101, 184);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "아이디";
            this.id.Width = 70;
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 75;
            // 
            // age
            // 
            this.age.Text = "나이";
            this.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.age.Width = 70;
            // 
            // sex
            // 
            this.sex.Text = "성별";
            this.sex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sex.Width = 50;
            // 
            // phone
            // 
            this.phone.Text = "연락처";
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phone.Width = 100;
            // 
            // group
            // 
            this.group.Text = "소속";
            this.group.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.group.Width = 75;
            // 
            // borrow
            // 
            this.borrow.Text = "대여일자";
            this.borrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.borrow.Width = 100;
            // 
            // _return
            // 
            this._return.Text = "반납일자";
            this._return.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._return.Width = 100;
            // 
            // book
            // 
            this.book.Text = "대여한 책";
            this.book.Width = 200;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(913, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 53);
            this.button2.TabIndex = 24;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 743);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_enter;
        private System.Windows.Forms.ListBox lb_book;
        private System.Windows.Forms.ListBox lb_kinds;
        private System.Windows.Forms.ComboBox cb_books;
        private System.Windows.Forms.ComboBox cb_age;
        private System.Windows.Forms.TextBox tb_rerturndate;
        private System.Windows.Forms.TextBox tb_borrowdate;
        private System.Windows.Forms.TextBox tb_group;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.ColumnHeader group;
        private System.Windows.Forms.ColumnHeader borrow;
        private System.Windows.Forms.ColumnHeader _return;
        private System.Windows.Forms.ColumnHeader book;
        private System.Windows.Forms.Button button2;
    }
}

