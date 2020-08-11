namespace Calculator
{
    partial class CalcForm
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
            this.variable1 = new System.Windows.Forms.TextBox();
            this.variable2 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // variable1
            // 
            this.variable1.Location = new System.Drawing.Point(29, 43);
            this.variable1.Name = "variable1";
            this.variable1.Size = new System.Drawing.Size(325, 21);
            this.variable1.TabIndex = 0;
            // 
            // variable2
            // 
            this.variable2.Location = new System.Drawing.Point(29, 100);
            this.variable2.Name = "variable2";
            this.variable2.Size = new System.Drawing.Size(325, 21);
            this.variable2.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(29, 153);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(50, 50);
            this.add.TabIndex = 2;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(117, 153);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(50, 50);
            this.subtract.TabIndex = 3;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // times
            // 
            this.multiple.Location = new System.Drawing.Point(210, 153);
            this.multiple.Name = "times";
            this.multiple.Size = new System.Drawing.Size(50, 50);
            this.multiple.TabIndex = 4;
            this.multiple.Text = "*";
            this.multiple.UseVisualStyleBackColor = true;
            this.multiple.Click += new System.EventHandler(this.multiple_Click);
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(304, 153);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(50, 50);
            this.square.TabIndex = 5;
            this.square.Text = "/";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.divide_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(27, 245);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(200, 12);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "결과";
            // 
            // resultListView
            // 
            this.resultListView.HideSelection = false;
            this.resultListView.Location = new System.Drawing.Point(29, 270);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(325, 165);
            this.resultListView.TabIndex = 8;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.square);
            this.Controls.Add(this.multiple);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.variable2);
            this.Controls.Add(this.variable1);
            this.Name = "CalcForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Calculator Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox variable1;
        private System.Windows.Forms.TextBox variable2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ListView resultListView;
    }
}

