namespace Snake
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.TimaName = new System.Windows.Forms.Label();
            this.ScoreName = new System.Windows.Forms.Label();
            this.TimeCounter = new System.Windows.Forms.Label();
            this.ScoreCounter = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Place1 = new System.Windows.Forms.Label();
            this.Place6 = new System.Windows.Forms.Label();
            this.Place2 = new System.Windows.Forms.Label();
            this.Place3 = new System.Windows.Forms.Label();
            this.Place4 = new System.Windows.Forms.Label();
            this.Place5 = new System.Windows.Forms.Label();
            this.Place7 = new System.Windows.Forms.Label();
            this.Place8 = new System.Windows.Forms.Label();
            this.Place9 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.score3 = new System.Windows.Forms.Label();
            this.score4 = new System.Windows.Forms.Label();
            this.score5 = new System.Windows.Forms.Label();
            this.score6 = new System.Windows.Forms.Label();
            this.score7 = new System.Windows.Forms.Label();
            this.score8 = new System.Windows.Forms.Label();
            this.score9 = new System.Windows.Forms.Label();
            this.score10 = new System.Windows.Forms.Label();
            this.Palce10 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimaName
            // 
            this.TimaName.AutoSize = true;
            this.TimaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimaName.Location = new System.Drawing.Point(873, 19);
            this.TimaName.Name = "TimaName";
            this.TimaName.Size = new System.Drawing.Size(85, 26);
            this.TimaName.TabIndex = 0;
            this.TimaName.Text = "Время:";
            // 
            // ScoreName
            // 
            this.ScoreName.AutoSize = true;
            this.ScoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreName.Location = new System.Drawing.Point(873, 66);
            this.ScoreName.Name = "ScoreName";
            this.ScoreName.Size = new System.Drawing.Size(68, 26);
            this.ScoreName.TabIndex = 1;
            this.ScoreName.Text = "Счет:";
            // 
            // TimeCounter
            // 
            this.TimeCounter.AutoSize = true;
            this.TimeCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeCounter.Location = new System.Drawing.Point(964, 19);
            this.TimeCounter.Name = "TimeCounter";
            this.TimeCounter.Size = new System.Drawing.Size(24, 26);
            this.TimeCounter.TabIndex = 2;
            this.TimeCounter.Text = "0";
            // 
            // ScoreCounter
            // 
            this.ScoreCounter.AutoSize = true;
            this.ScoreCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreCounter.Location = new System.Drawing.Point(964, 66);
            this.ScoreCounter.Name = "ScoreCounter";
            this.ScoreCounter.Size = new System.Drawing.Size(24, 26);
            this.ScoreCounter.TabIndex = 3;
            this.ScoreCounter.Text = "0";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(845, 228);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(144, 26);
            this.Result.TabIndex = 4;
            this.Result.Text = "Лучший счет";
            // 
            // Place1
            // 
            this.Place1.AutoSize = true;
            this.Place1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place1.Location = new System.Drawing.Point(811, 281);
            this.Place1.Name = "Place1";
            this.Place1.Size = new System.Drawing.Size(161, 26);
            this.Place1.TabIndex = 6;
            this.Place1.Text = "Первое место:";
            // 
            // Place6
            // 
            this.Place6.AutoSize = true;
            this.Place6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place6.Location = new System.Drawing.Point(811, 487);
            this.Place6.Name = "Place6";
            this.Place6.Size = new System.Drawing.Size(161, 26);
            this.Place6.TabIndex = 7;
            this.Place6.Text = "Шестое место:";
            // 
            // Place2
            // 
            this.Place2.AutoSize = true;
            this.Place2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place2.Location = new System.Drawing.Point(811, 318);
            this.Place2.Name = "Place2";
            this.Place2.Size = new System.Drawing.Size(158, 26);
            this.Place2.TabIndex = 7;
            this.Place2.Text = "Второе место:";
            // 
            // Place3
            // 
            this.Place3.AutoSize = true;
            this.Place3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place3.Location = new System.Drawing.Point(811, 360);
            this.Place3.Name = "Place3";
            this.Place3.Size = new System.Drawing.Size(155, 26);
            this.Place3.TabIndex = 8;
            this.Place3.Text = "Третье место:";
            // 
            // Place4
            // 
            this.Place4.AutoSize = true;
            this.Place4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place4.Location = new System.Drawing.Point(811, 400);
            this.Place4.Name = "Place4";
            this.Place4.Size = new System.Drawing.Size(192, 26);
            this.Place4.TabIndex = 7;
            this.Place4.Text = "Четвертое место:";
            // 
            // Place5
            // 
            this.Place5.AutoSize = true;
            this.Place5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place5.Location = new System.Drawing.Point(811, 443);
            this.Place5.Name = "Place5";
            this.Place5.Size = new System.Drawing.Size(147, 26);
            this.Place5.TabIndex = 9;
            this.Place5.Text = "Пятое место:";
            // 
            // Place7
            // 
            this.Place7.AutoSize = true;
            this.Place7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place7.Location = new System.Drawing.Point(811, 528);
            this.Place7.Name = "Place7";
            this.Place7.Size = new System.Drawing.Size(178, 26);
            this.Place7.TabIndex = 10;
            this.Place7.Text = "Седьмое место:";
            // 
            // Place8
            // 
            this.Place8.AutoSize = true;
            this.Place8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place8.Location = new System.Drawing.Point(811, 568);
            this.Place8.Name = "Place8";
            this.Place8.Size = new System.Drawing.Size(175, 26);
            this.Place8.TabIndex = 11;
            this.Place8.Text = "Восьмое место:";
            // 
            // Place9
            // 
            this.Place9.AutoSize = true;
            this.Place9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Place9.Location = new System.Drawing.Point(811, 606);
            this.Place9.Name = "Place9";
            this.Place9.Size = new System.Drawing.Size(172, 26);
            this.Place9.TabIndex = 12;
            this.Place9.Text = "Девятое место:";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score1.Location = new System.Drawing.Point(1005, 281);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(19, 26);
            this.score1.TabIndex = 13;
            this.score1.Text = "-";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score2.Location = new System.Drawing.Point(1005, 318);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(19, 26);
            this.score2.TabIndex = 14;
            this.score2.Text = "-";
            // 
            // score3
            // 
            this.score3.AutoSize = true;
            this.score3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score3.Location = new System.Drawing.Point(1005, 360);
            this.score3.Name = "score3";
            this.score3.Size = new System.Drawing.Size(19, 26);
            this.score3.TabIndex = 15;
            this.score3.Text = "-";
            // 
            // score4
            // 
            this.score4.AutoSize = true;
            this.score4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score4.Location = new System.Drawing.Point(1004, 400);
            this.score4.Name = "score4";
            this.score4.Size = new System.Drawing.Size(19, 26);
            this.score4.TabIndex = 16;
            this.score4.Text = "-";
            // 
            // score5
            // 
            this.score5.AutoSize = true;
            this.score5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score5.Location = new System.Drawing.Point(1005, 443);
            this.score5.Name = "score5";
            this.score5.Size = new System.Drawing.Size(19, 26);
            this.score5.TabIndex = 17;
            this.score5.Text = "-";
            // 
            // score6
            // 
            this.score6.AutoSize = true;
            this.score6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score6.Location = new System.Drawing.Point(1005, 487);
            this.score6.Name = "score6";
            this.score6.Size = new System.Drawing.Size(19, 26);
            this.score6.TabIndex = 18;
            this.score6.Text = "-";
            // 
            // score7
            // 
            this.score7.AutoSize = true;
            this.score7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score7.Location = new System.Drawing.Point(1005, 528);
            this.score7.Name = "score7";
            this.score7.Size = new System.Drawing.Size(19, 26);
            this.score7.TabIndex = 19;
            this.score7.Text = "-";
            // 
            // score8
            // 
            this.score8.AutoSize = true;
            this.score8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score8.Location = new System.Drawing.Point(1005, 568);
            this.score8.Name = "score8";
            this.score8.Size = new System.Drawing.Size(19, 26);
            this.score8.TabIndex = 20;
            this.score8.Text = "-";
            // 
            // score9
            // 
            this.score9.AutoSize = true;
            this.score9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score9.Location = new System.Drawing.Point(1005, 606);
            this.score9.Name = "score9";
            this.score9.Size = new System.Drawing.Size(19, 26);
            this.score9.TabIndex = 21;
            this.score9.Text = "-";
            // 
            // score10
            // 
            this.score10.AutoSize = true;
            this.score10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score10.Location = new System.Drawing.Point(1005, 649);
            this.score10.Name = "score10";
            this.score10.Size = new System.Drawing.Size(19, 26);
            this.score10.TabIndex = 24;
            this.score10.Text = "-";
            // 
            // Palce10
            // 
            this.Palce10.AutoSize = true;
            this.Palce10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Palce10.Location = new System.Drawing.Point(811, 649);
            this.Palce10.Name = "Palce10";
            this.Palce10.Size = new System.Drawing.Size(171, 26);
            this.Palce10.TabIndex = 23;
            this.Palce10.Text = "Десятое место:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(858, 118);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(151, 34);
            this.Start.TabIndex = 25;
            this.Start.TabStop = false;
            this.Start.Text = "Начать Игру";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // NewGame
            // 
            this.NewGame.Enabled = false;
            this.NewGame.Location = new System.Drawing.Point(858, 167);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(151, 34);
            this.NewGame.TabIndex = 26;
            this.NewGame.TabStop = false;
            this.NewGame.Text = "Новая Игра";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 761);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.score10);
            this.Controls.Add(this.Palce10);
            this.Controls.Add(this.score9);
            this.Controls.Add(this.score8);
            this.Controls.Add(this.score7);
            this.Controls.Add(this.score6);
            this.Controls.Add(this.score5);
            this.Controls.Add(this.score4);
            this.Controls.Add(this.score3);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.Place9);
            this.Controls.Add(this.Place8);
            this.Controls.Add(this.Place7);
            this.Controls.Add(this.Place5);
            this.Controls.Add(this.Place3);
            this.Controls.Add(this.Place2);
            this.Controls.Add(this.Place4);
            this.Controls.Add(this.Place6);
            this.Controls.Add(this.Place1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ScoreCounter);
            this.Controls.Add(this.TimeCounter);
            this.Controls.Add(this.ScoreName);
            this.Controls.Add(this.TimaName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.Text = "Змейка";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label TimaName;
        private System.Windows.Forms.Label ScoreName;
        private System.Windows.Forms.Label TimeCounter;
        private System.Windows.Forms.Label ScoreCounter;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Place1;
        private System.Windows.Forms.Label Place6;
        private System.Windows.Forms.Label Place2;
        private System.Windows.Forms.Label Place3;
        private System.Windows.Forms.Label Place4;
        private System.Windows.Forms.Label Place5;
        private System.Windows.Forms.Label Place7;
        private System.Windows.Forms.Label Place8;
        private System.Windows.Forms.Label Place9;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label score3;
        private System.Windows.Forms.Label score4;
        private System.Windows.Forms.Label score5;
        private System.Windows.Forms.Label score6;
        private System.Windows.Forms.Label score7;
        private System.Windows.Forms.Label score8;
        private System.Windows.Forms.Label score9;
        private System.Windows.Forms.Label score10;
        private System.Windows.Forms.Label Palce10;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button NewGame;
    }
}

