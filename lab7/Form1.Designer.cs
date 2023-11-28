namespace lab7
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btAdd = new Button();
            btRemove = new Button();
            btShow = new Button();
            label5 = new Label();
            TBId = new TextBox();
            TBFirstName = new TextBox();
            TBLastName = new TextBox();
            TBAge = new TextBox();
            listBoxQuque = new ListBox();
            SerializeToJsonBtn = new Button();
            DeserializeFromJsonBtn = new Button();
            SerializeToBinaryBtn = new Button();
            DeserializeFromBin = new Button();
            SortAgeAsc = new Button();
            SortIDAsc = new Button();
            SearchByName = new Button();
            SortAgeDesc = new Button();
            SortIdDesc = new Button();
            SearchLastName = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 159);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 233);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 309);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 2;
            label3.Text = "Возраст";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(248, 9);
            label4.Name = "label4";
            label4.Size = new Size(324, 28);
            label4.TabIndex = 3;
            label4.Text = "Управление очередью пациентов";
            // 
            // btAdd
            // 
            btAdd.FlatStyle = FlatStyle.Flat;
            btAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btAdd.Location = new Point(248, 160);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(198, 39);
            btAdd.TabIndex = 4;
            btAdd.Text = "Добавить пациента";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btRemove
            // 
            btRemove.FlatStyle = FlatStyle.Flat;
            btRemove.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btRemove.Location = new Point(248, 108);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(198, 39);
            btRemove.TabIndex = 5;
            btRemove.Text = "Удалить пациента";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // btShow
            // 
            btShow.FlatStyle = FlatStyle.Flat;
            btShow.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btShow.Location = new Point(248, 58);
            btShow.Name = "btShow";
            btShow.Size = new Size(198, 39);
            btShow.TabIndex = 6;
            btShow.Text = "Показать очередь";
            btShow.UseVisualStyleBackColor = true;
            btShow.Click += btShow_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(65, 84);
            label5.Name = "label5";
            label5.Size = new Size(29, 28);
            label5.TabIndex = 7;
            label5.Text = "Id";
            // 
            // TBId
            // 
            TBId.Location = new Point(63, 126);
            TBId.Name = "TBId";
            TBId.Size = new Size(125, 27);
            TBId.TabIndex = 8;
            // 
            // TBFirstName
            // 
            TBFirstName.Location = new Point(63, 203);
            TBFirstName.Name = "TBFirstName";
            TBFirstName.Size = new Size(125, 27);
            TBFirstName.TabIndex = 9;
            // 
            // TBLastName
            // 
            TBLastName.Location = new Point(65, 279);
            TBLastName.Name = "TBLastName";
            TBLastName.Size = new Size(125, 27);
            TBLastName.TabIndex = 10;
            // 
            // TBAge
            // 
            TBAge.Location = new Point(63, 355);
            TBAge.Name = "TBAge";
            TBAge.Size = new Size(125, 27);
            TBAge.TabIndex = 11;
            // 
            // listBoxQuque
            // 
            listBoxQuque.FormattingEnabled = true;
            listBoxQuque.ItemHeight = 20;
            listBoxQuque.Location = new Point(483, 58);
            listBoxQuque.Name = "listBoxQuque";
            listBoxQuque.Size = new Size(361, 544);
            listBoxQuque.TabIndex = 12;
            // 
            // SerializeToJsonBtn
            // 
            SerializeToJsonBtn.FlatStyle = FlatStyle.Flat;
            SerializeToJsonBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SerializeToJsonBtn.Location = new Point(248, 208);
            SerializeToJsonBtn.Name = "SerializeToJsonBtn";
            SerializeToJsonBtn.Size = new Size(198, 39);
            SerializeToJsonBtn.TabIndex = 17;
            SerializeToJsonBtn.Text = "Сохранить в JSON";
            SerializeToJsonBtn.UseVisualStyleBackColor = true;
            SerializeToJsonBtn.Click += SerializeToJsonBtn_Click;
            // 
            // DeserializeFromJsonBtn
            // 
            DeserializeFromJsonBtn.FlatStyle = FlatStyle.Flat;
            DeserializeFromJsonBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            DeserializeFromJsonBtn.Location = new Point(248, 253);
            DeserializeFromJsonBtn.Name = "DeserializeFromJsonBtn";
            DeserializeFromJsonBtn.Size = new Size(198, 39);
            DeserializeFromJsonBtn.TabIndex = 18;
            DeserializeFromJsonBtn.Text = "Прочитать из JSON";
            DeserializeFromJsonBtn.UseVisualStyleBackColor = true;
            DeserializeFromJsonBtn.Click += DeserializeFromJsonBtn_Click;
            // 
            // SerializeToBinaryBtn
            // 
            SerializeToBinaryBtn.FlatStyle = FlatStyle.Flat;
            SerializeToBinaryBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SerializeToBinaryBtn.Location = new Point(248, 302);
            SerializeToBinaryBtn.Name = "SerializeToBinaryBtn";
            SerializeToBinaryBtn.Size = new Size(198, 39);
            SerializeToBinaryBtn.TabIndex = 19;
            SerializeToBinaryBtn.Text = "Сохранить в BIN";
            SerializeToBinaryBtn.UseVisualStyleBackColor = true;
            SerializeToBinaryBtn.Click += SerializeToBinaryBtn_Click;
            // 
            // DeserializeFromBin
            // 
            DeserializeFromBin.FlatStyle = FlatStyle.Flat;
            DeserializeFromBin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            DeserializeFromBin.Location = new Point(248, 350);
            DeserializeFromBin.Name = "DeserializeFromBin";
            DeserializeFromBin.Size = new Size(198, 39);
            DeserializeFromBin.TabIndex = 20;
            DeserializeFromBin.Text = "Прочитать из BIN";
            DeserializeFromBin.UseVisualStyleBackColor = true;
            DeserializeFromBin.Click += DeserializeFromBin_Click;
            // 
            // SortAgeAsc
            // 
            SortAgeAsc.FlatStyle = FlatStyle.Flat;
            SortAgeAsc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SortAgeAsc.Location = new Point(248, 396);
            SortAgeAsc.Name = "SortAgeAsc";
            SortAgeAsc.Size = new Size(198, 102);
            SortAgeAsc.TabIndex = 21;
            SortAgeAsc.Text = "Сортировка по возрасту (возрастание)\r\n\r\n";
            SortAgeAsc.UseVisualStyleBackColor = true;
            SortAgeAsc.Click += SortAgeAsc_Click;
            // 
            // SortIDAsc
            // 
            SortIDAsc.FlatStyle = FlatStyle.Flat;
            SortIDAsc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SortIDAsc.Location = new Point(248, 504);
            SortIDAsc.Name = "SortIDAsc";
            SortIDAsc.Size = new Size(198, 61);
            SortIDAsc.TabIndex = 22;
            SortIDAsc.Text = "Сортировка по ID (возрастание)";
            SortIDAsc.UseVisualStyleBackColor = true;
            SortIDAsc.Click += SortIDAsc_Click;
            // 
            // SearchByName
            // 
            SearchByName.FlatStyle = FlatStyle.Flat;
            SearchByName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SearchByName.Location = new Point(562, 662);
            SearchByName.Name = "SearchByName";
            SearchByName.Size = new Size(198, 40);
            SearchByName.TabIndex = 24;
            SearchByName.Text = "Поиск по имени";
            SearchByName.UseVisualStyleBackColor = true;
            SearchByName.Click += SearchByName_Click;
            // 
            // SortAgeDesc
            // 
            SortAgeDesc.FlatStyle = FlatStyle.Flat;
            SortAgeDesc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SortAgeDesc.Location = new Point(248, 573);
            SortAgeDesc.Name = "SortAgeDesc";
            SortAgeDesc.Size = new Size(198, 61);
            SortAgeDesc.TabIndex = 25;
            SortAgeDesc.Text = "Сортировка по возрасту (убывание)";
            SortAgeDesc.UseVisualStyleBackColor = true;
            SortAgeDesc.Click += SortAgeDesc_Click;
            // 
            // SortIdDesc
            // 
            SortIdDesc.FlatStyle = FlatStyle.Flat;
            SortIdDesc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SortIdDesc.Location = new Point(248, 640);
            SortIdDesc.Name = "SortIdDesc";
            SortIdDesc.Size = new Size(198, 62);
            SortIdDesc.TabIndex = 26;
            SortIdDesc.Text = "Сортировка по ID (убывание)";
            SortIdDesc.UseVisualStyleBackColor = true;
            SortIdDesc.Click += SortIdDesc_Click;
            // 
            // SearchLastName
            // 
            SearchLastName.FlatStyle = FlatStyle.Flat;
            SearchLastName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SearchLastName.Location = new Point(561, 616);
            SearchLastName.Name = "SearchLastName";
            SearchLastName.Size = new Size(199, 40);
            SearchLastName.TabIndex = 27;
            SearchLastName.Text = "Поиск по фамилии";
            SearchLastName.UseVisualStyleBackColor = true;
            SearchLastName.Click += SearchLastName_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 724);
            Controls.Add(SearchLastName);
            Controls.Add(SortIdDesc);
            Controls.Add(SortAgeDesc);
            Controls.Add(SearchByName);
            Controls.Add(SortIDAsc);
            Controls.Add(SortAgeAsc);
            Controls.Add(DeserializeFromBin);
            Controls.Add(SerializeToBinaryBtn);
            Controls.Add(DeserializeFromJsonBtn);
            Controls.Add(SerializeToJsonBtn);
            Controls.Add(listBoxQuque);
            Controls.Add(TBAge);
            Controls.Add(TBLastName);
            Controls.Add(TBFirstName);
            Controls.Add(TBId);
            Controls.Add(label5);
            Controls.Add(btShow);
            Controls.Add(btRemove);
            Controls.Add(btAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btAdd;
        private Button btRemove;
        private Button btShow;
        private Label label5;
        private TextBox TBId;
        private TextBox TBFirstName;
        private TextBox TBLastName;
        private TextBox TBAge;
        private ListBox listBoxQuque;
        private Button SerializeToJsonBtn;
        private Button DeserializeFromJsonBtn;
        private Button SerializeToBinaryBtn;
        private Button DeserializeFromBin;
        private Button SortAgeAsc;
        private Button SortIDAsc;
        private Button SearchByLastName;
        private Button SearchByName;
        private Button SortAgeDesc;
        private Button SortIdDesc;
        private Button SearchLastName;
    }
}