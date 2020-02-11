namespace WordAddIn2
{
    partial class MyPane
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_course = new System.Windows.Forms.Label();
            this.lbllbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_current_question = new System.Windows.Forms.Label();
            this.lbl_taskid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_studentname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_merkaz_kvuza = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_tziun_desc = new System.Windows.Forms.Label();
            this.lbl_tziunim = new System.Windows.Forms.Label();
            this.panel_tziunim = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_tziunim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_course
            // 
            this.lbl_course.AutoSize = true;
            this.lbl_course.Location = new System.Drawing.Point(99, 20);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(35, 13);
            this.lbl_course.TabIndex = 1;
            this.lbl_course.Text = "label1";
            // 
            // lbllbl
            // 
            this.lbllbl.AutoSize = true;
            this.lbllbl.Location = new System.Drawing.Point(235, 40);
            this.lbllbl.Name = "lbllbl";
            this.lbllbl.Size = new System.Drawing.Size(35, 13);
            this.lbllbl.TabIndex = 2;
            this.lbllbl.Text = "מטלה";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_current_question, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbllbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_taskid, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_studentname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_course, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_merkaz_kvuza, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tziun_desc, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 140);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbl_current_question
            // 
            this.lbl_current_question.AutoSize = true;
            this.lbl_current_question.Location = new System.Drawing.Point(99, 80);
            this.lbl_current_question.Name = "lbl_current_question";
            this.lbl_current_question.Size = new System.Drawing.Size(35, 13);
            this.lbl_current_question.TabIndex = 4;
            this.lbl_current_question.Text = "label5";
            // 
            // lbl_taskid
            // 
            this.lbl_taskid.AutoSize = true;
            this.lbl_taskid.Location = new System.Drawing.Point(99, 40);
            this.lbl_taskid.Name = "lbl_taskid";
            this.lbl_taskid.Size = new System.Drawing.Size(35, 13);
            this.lbl_taskid.TabIndex = 4;
            this.lbl_taskid.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "סטודנט";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "קורס-סמסטר";
            // 
            // lbl_studentname
            // 
            this.lbl_studentname.AutoSize = true;
            this.lbl_studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_studentname.Location = new System.Drawing.Point(93, 0);
            this.lbl_studentname.Name = "lbl_studentname";
            this.lbl_studentname.Size = new System.Drawing.Size(41, 13);
            this.lbl_studentname.TabIndex = 3;
            this.lbl_studentname.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "מרכז/קבוצה";
            // 
            // lbl_merkaz_kvuza
            // 
            this.lbl_merkaz_kvuza.AutoSize = true;
            this.lbl_merkaz_kvuza.Location = new System.Drawing.Point(99, 60);
            this.lbl_merkaz_kvuza.Name = "lbl_merkaz_kvuza";
            this.lbl_merkaz_kvuza.Size = new System.Drawing.Size(35, 13);
            this.lbl_merkaz_kvuza.TabIndex = 8;
            this.lbl_merkaz_kvuza.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ציון";
            // 
            // lbl_tziun_desc
            // 
            this.lbl_tziun_desc.AutoSize = true;
            this.lbl_tziun_desc.Location = new System.Drawing.Point(99, 100);
            this.lbl_tziun_desc.Name = "lbl_tziun_desc";
            this.lbl_tziun_desc.Size = new System.Drawing.Size(35, 13);
            this.lbl_tziun_desc.TabIndex = 10;
            this.lbl_tziun_desc.Text = "label6";
            // 
            // lbl_tziunim
            // 
            this.lbl_tziunim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tziunim.AutoSize = true;
            this.lbl_tziunim.Location = new System.Drawing.Point(186, 0);
            this.lbl_tziunim.Name = "lbl_tziunim";
            this.lbl_tziunim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_tziunim.Size = new System.Drawing.Size(87, 13);
            this.lbl_tziunim.TabIndex = 4;
            this.lbl_tziunim.Text = "ציונים לשאלות";
            this.lbl_tziunim.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel_tziunim
            // 
            this.panel_tziunim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_tziunim.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel_tziunim.Controls.Add(this.lbl_tziunim);
            this.panel_tziunim.Location = new System.Drawing.Point(3, 222);
            this.panel_tziunim.Name = "panel_tziunim";
            this.panel_tziunim.Size = new System.Drawing.Size(273, 100);
            this.panel_tziunim.TabIndex = 5;
            // 
            // MyPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_tziunim);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MyPane";
            this.Size = new System.Drawing.Size(279, 695);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_tziunim.ResumeLayout(false);
            this.panel_tziunim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_course;
        private System.Windows.Forms.Label lbllbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_studentname;
        private System.Windows.Forms.Label lbl_taskid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_merkaz_kvuza;
        private System.Windows.Forms.Label lbl_current_question;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_tziun_desc;
        private System.Windows.Forms.Label lbl_tziunim;
        private System.Windows.Forms.Panel panel_tziunim;
    }
}
