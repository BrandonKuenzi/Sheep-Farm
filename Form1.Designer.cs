namespace Sheep_Farm
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.graphicsLabel2 = new System.Windows.Forms.Label();
            this.sheepLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.woolLabel = new System.Windows.Forms.Label();
            this.graphicsLabel1 = new System.Windows.Forms.Label();
            this.graphicsLabel3 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buySheepButton = new System.Windows.Forms.Button();
            this.sellSheepButton = new System.Windows.Forms.Button();
            this.sellWoolButton = new System.Windows.Forms.Button();
            this.shaveSheepButton = new System.Windows.Forms.Button();
            this.buyFoodButton = new System.Windows.Forms.Button();
            this.sheepMarketLabel = new System.Windows.Forms.Label();
            this.woolMarketLabel = new System.Windows.Forms.Label();
            this.foodMarketLabel = new System.Windows.Forms.Label();
            this.oneForcastLabel = new System.Windows.Forms.Label();
            this.twoForcastLabel = new System.Windows.Forms.Label();
            this.threeForcastLabel = new System.Windows.Forms.Label();
            this.todaysWeatherLabel = new System.Windows.Forms.Label();
            this.woolQualityLabel = new System.Windows.Forms.Label();
            this.foodLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bannana Sheep Farm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // graphicsLabel2
            // 
            this.graphicsLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.graphicsLabel2.AutoSize = true;
            this.graphicsLabel2.Location = new System.Drawing.Point(422, 148);
            this.graphicsLabel2.Name = "graphicsLabel2";
            this.graphicsLabel2.Size = new System.Drawing.Size(119, 13);
            this.graphicsLabel2.TabIndex = 1;
            this.graphicsLabel2.Text = "////////   /////// /////";
            // 
            // sheepLabel
            // 
            this.sheepLabel.AutoSize = true;
            this.sheepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheepLabel.Location = new System.Drawing.Point(6, 25);
            this.sheepLabel.Name = "sheepLabel";
            this.sheepLabel.Size = new System.Drawing.Size(56, 13);
            this.sheepLabel.TabIndex = 2;
            this.sheepLabel.Text = "Sheep: 15";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(503, 55);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(117, 20);
            this.moneyLabel.TabIndex = 3;
            this.moneyLabel.Text = "Monies: $1,000";
            // 
            // woolLabel
            // 
            this.woolLabel.AutoSize = true;
            this.woolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woolLabel.Location = new System.Drawing.Point(6, 59);
            this.woolLabel.Name = "woolLabel";
            this.woolLabel.Size = new System.Drawing.Size(74, 13);
            this.woolLabel.TabIndex = 4;
            this.woolLabel.Text = "Wool: 0 woolz";
            // 
            // graphicsLabel1
            // 
            this.graphicsLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.graphicsLabel1.AutoSize = true;
            this.graphicsLabel1.Location = new System.Drawing.Point(422, 135);
            this.graphicsLabel1.Name = "graphicsLabel1";
            this.graphicsLabel1.Size = new System.Drawing.Size(142, 13);
            this.graphicsLabel1.TabIndex = 5;
            this.graphicsLabel1.Text = "00000000    0000     000000";
            // 
            // graphicsLabel3
            // 
            this.graphicsLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.graphicsLabel3.AutoSize = true;
            this.graphicsLabel3.Location = new System.Drawing.Point(422, 161);
            this.graphicsLabel3.Name = "graphicsLabel3";
            this.graphicsLabel3.Size = new System.Drawing.Size(124, 13);
            this.graphicsLabel3.TabIndex = 6;
            this.graphicsLabel3.Text = "..................... ....... .........";
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.goButton.Location = new System.Drawing.Point(495, 10);
            this.goButton.Name = "goButton";
            this.goButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.goButton.Size = new System.Drawing.Size(137, 40);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "Next Day";
            this.goButton.UseVisualStyleBackColor = false;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 309);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(616, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Welcome to Bannana Sheep Farm! My name is Alfredo and I will be your assistant as" +
    " you build our farm to glory!";
            // 
            // buySheepButton
            // 
            this.buySheepButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buySheepButton.Location = new System.Drawing.Point(16, 237);
            this.buySheepButton.Name = "buySheepButton";
            this.buySheepButton.Size = new System.Drawing.Size(85, 23);
            this.buySheepButton.TabIndex = 10;
            this.buySheepButton.Text = "Buy Sheep";
            this.buySheepButton.UseVisualStyleBackColor = true;
            this.buySheepButton.Click += new System.EventHandler(this.buySheepButton_Click);
            // 
            // sellSheepButton
            // 
            this.sellSheepButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sellSheepButton.Location = new System.Drawing.Point(16, 266);
            this.sellSheepButton.Name = "sellSheepButton";
            this.sellSheepButton.Size = new System.Drawing.Size(85, 23);
            this.sellSheepButton.TabIndex = 11;
            this.sellSheepButton.Text = "Sell Sheep";
            this.sellSheepButton.UseVisualStyleBackColor = true;
            this.sellSheepButton.Click += new System.EventHandler(this.sellSheepButton_Click_1);
            // 
            // sellWoolButton
            // 
            this.sellWoolButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellWoolButton.Location = new System.Drawing.Point(236, 266);
            this.sellWoolButton.Name = "sellWoolButton";
            this.sellWoolButton.Size = new System.Drawing.Size(186, 23);
            this.sellWoolButton.TabIndex = 13;
            this.sellWoolButton.Text = "Sell Wool";
            this.sellWoolButton.UseVisualStyleBackColor = true;
            this.sellWoolButton.Click += new System.EventHandler(this.sellWoolButton_Click);
            // 
            // shaveSheepButton
            // 
            this.shaveSheepButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shaveSheepButton.Location = new System.Drawing.Point(236, 237);
            this.shaveSheepButton.Name = "shaveSheepButton";
            this.shaveSheepButton.Size = new System.Drawing.Size(186, 23);
            this.shaveSheepButton.TabIndex = 12;
            this.shaveSheepButton.Text = "Shave Them Sheep*";
            this.shaveSheepButton.UseVisualStyleBackColor = true;
            this.shaveSheepButton.Click += new System.EventHandler(this.shaveSheepButton_Click);
            // 
            // buyFoodButton
            // 
            this.buyFoodButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buyFoodButton.Location = new System.Drawing.Point(523, 237);
            this.buyFoodButton.Name = "buyFoodButton";
            this.buyFoodButton.Size = new System.Drawing.Size(97, 23);
            this.buyFoodButton.TabIndex = 14;
            this.buyFoodButton.Text = "Buy Sheep Food";
            this.buyFoodButton.UseVisualStyleBackColor = true;
            this.buyFoodButton.Click += new System.EventHandler(this.buyFoodButton_Click);
            // 
            // sheepMarketLabel
            // 
            this.sheepMarketLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sheepMarketLabel.AutoSize = true;
            this.sheepMarketLabel.Location = new System.Drawing.Point(6, 16);
            this.sheepMarketLabel.Name = "sheepMarketLabel";
            this.sheepMarketLabel.Size = new System.Drawing.Size(79, 13);
            this.sheepMarketLabel.TabIndex = 16;
            this.sheepMarketLabel.Text = "Sheep: $400";
            // 
            // woolMarketLabel
            // 
            this.woolMarketLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.woolMarketLabel.AutoSize = true;
            this.woolMarketLabel.Location = new System.Drawing.Point(278, 16);
            this.woolMarketLabel.Name = "woolMarketLabel";
            this.woolMarketLabel.Size = new System.Drawing.Size(65, 13);
            this.woolMarketLabel.TabIndex = 17;
            this.woolMarketLabel.Text = "Wool: $50";
            // 
            // foodMarketLabel
            // 
            this.foodMarketLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.foodMarketLabel.AutoSize = true;
            this.foodMarketLabel.Location = new System.Drawing.Point(516, 16);
            this.foodMarketLabel.Name = "foodMarketLabel";
            this.foodMarketLabel.Size = new System.Drawing.Size(64, 13);
            this.foodMarketLabel.TabIndex = 18;
            this.foodMarketLabel.Text = "Food: $25";
            // 
            // oneForcastLabel
            // 
            this.oneForcastLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oneForcastLabel.AutoSize = true;
            this.oneForcastLabel.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneForcastLabel.Location = new System.Drawing.Point(256, 41);
            this.oneForcastLabel.Name = "oneForcastLabel";
            this.oneForcastLabel.Size = new System.Drawing.Size(64, 13);
            this.oneForcastLabel.TabIndex = 20;
            this.oneForcastLabel.Text = "38 Rainy";
            // 
            // twoForcastLabel
            // 
            this.twoForcastLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.twoForcastLabel.AutoSize = true;
            this.twoForcastLabel.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoForcastLabel.Location = new System.Drawing.Point(256, 54);
            this.twoForcastLabel.Name = "twoForcastLabel";
            this.twoForcastLabel.Size = new System.Drawing.Size(60, 13);
            this.twoForcastLabel.TabIndex = 21;
            this.twoForcastLabel.Text = "45 Clear";
            // 
            // threeForcastLabel
            // 
            this.threeForcastLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.threeForcastLabel.AutoSize = true;
            this.threeForcastLabel.Font = new System.Drawing.Font("Castellar", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeForcastLabel.Location = new System.Drawing.Point(256, 67);
            this.threeForcastLabel.Name = "threeForcastLabel";
            this.threeForcastLabel.Size = new System.Drawing.Size(131, 13);
            this.threeForcastLabel.TabIndex = 22;
            this.threeForcastLabel.Text = "55 Thunderstorms";
            // 
            // todaysWeatherLabel
            // 
            this.todaysWeatherLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.todaysWeatherLabel.AutoSize = true;
            this.todaysWeatherLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todaysWeatherLabel.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaysWeatherLabel.Location = new System.Drawing.Point(215, 18);
            this.todaysWeatherLabel.Name = "todaysWeatherLabel";
            this.todaysWeatherLabel.Size = new System.Drawing.Size(172, 21);
            this.todaysWeatherLabel.TabIndex = 23;
            this.todaysWeatherLabel.Text = "Today: 75 SUnny";
            this.todaysWeatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // woolQualityLabel
            // 
            this.woolQualityLabel.AutoSize = true;
            this.woolQualityLabel.Location = new System.Drawing.Point(535, 408);
            this.woolQualityLabel.Name = "woolQualityLabel";
            this.woolQualityLabel.Size = new System.Drawing.Size(97, 13);
            this.woolQualityLabel.TabIndex = 24;
            this.woolQualityLabel.Text = "*Wool Quality: 33%";
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.Location = new System.Drawing.Point(6, 43);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(49, 13);
            this.foodLabel.TabIndex = 25;
            this.foodLabel.Text = "Food: 50";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sheepMarketLabel);
            this.groupBox1.Controls.Add(this.woolMarketLabel);
            this.groupBox1.Controls.Add(this.foodMarketLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 41);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today\'s Prices";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sheepLabel);
            this.groupBox2.Controls.Add(this.woolLabel);
            this.groupBox2.Controls.Add(this.foodLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 90);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.woolQualityLabel);
            this.Controls.Add(this.todaysWeatherLabel);
            this.Controls.Add(this.threeForcastLabel);
            this.Controls.Add(this.twoForcastLabel);
            this.Controls.Add(this.oneForcastLabel);
            this.Controls.Add(this.buyFoodButton);
            this.Controls.Add(this.sellWoolButton);
            this.Controls.Add(this.shaveSheepButton);
            this.Controls.Add(this.sellSheepButton);
            this.Controls.Add(this.buySheepButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.graphicsLabel3);
            this.Controls.Add(this.graphicsLabel1);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.graphicsLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 466);
            this.MinimumSize = new System.Drawing.Size(660, 466);
            this.Name = "Form1";
            this.Text = "Bannana Sheep Farm v 0.000323";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label graphicsLabel2;
        private System.Windows.Forms.Label sheepLabel;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label woolLabel;
        private System.Windows.Forms.Label graphicsLabel1;
        private System.Windows.Forms.Label graphicsLabel3;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buySheepButton;
        private System.Windows.Forms.Button sellSheepButton;
        private System.Windows.Forms.Button sellWoolButton;
        private System.Windows.Forms.Button shaveSheepButton;
        private System.Windows.Forms.Button buyFoodButton;
        private System.Windows.Forms.Label sheepMarketLabel;
        private System.Windows.Forms.Label woolMarketLabel;
        private System.Windows.Forms.Label foodMarketLabel;
        private System.Windows.Forms.Label oneForcastLabel;
        private System.Windows.Forms.Label twoForcastLabel;
        private System.Windows.Forms.Label threeForcastLabel;
        private System.Windows.Forms.Label todaysWeatherLabel;
        private System.Windows.Forms.Label woolQualityLabel;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

