namespace LrcMakerTest01
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.lrcList = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开音频文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开歌词文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有时间轴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无时间轴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.来自剪贴板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.有时间轴ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.无时间轴ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.保存歌词文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.lrcBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTimeBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentTimeBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button14 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.offset_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(12, 523);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(10, 10);
            this.player.TabIndex = 4;
            this.player.Visible = false;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(12, 35);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.ReadOnly = true;
            this.addressBox.Size = new System.Drawing.Size(132, 95);
            this.addressBox.TabIndex = 5;
            // 
            // lrcList
            // 
            this.lrcList.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lrcList.FormattingEnabled = true;
            this.lrcList.ItemHeight = 20;
            this.lrcList.Location = new System.Drawing.Point(151, 67);
            this.lrcList.Name = "lrcList";
            this.lrcList.Size = new System.Drawing.Size(621, 444);
            this.lrcList.TabIndex = 7;
            this.lrcList.Click += new System.EventHandler(this.lrcList_Click);
            this.lrcList.DoubleClick += new System.EventHandler(this.lrcList_DoubleClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(150, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "插入信息";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(241, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 9;
            this.button6.Text = "插入项";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(332, 31);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 30);
            this.button7.TabIndex = 10;
            this.button7.Text = "删除项";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(423, 31);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 30);
            this.button8.TabIndex = 11;
            this.button8.Text = "上移";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(514, 31);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 30);
            this.button9.TabIndex = 12;
            this.button9.Text = "下移";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(696, 31);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 30);
            this.button10.TabIndex = 13;
            this.button10.Text = "清空";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(605, 31);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 30);
            this.button11.TabIndex = 14;
            this.button11.Text = "撤销";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开音频文件ToolStripMenuItem,
            this.打开歌词文件ToolStripMenuItem,
            this.来自剪贴板ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.保存歌词文件ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开音频文件ToolStripMenuItem
            // 
            this.打开音频文件ToolStripMenuItem.Name = "打开音频文件ToolStripMenuItem";
            this.打开音频文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开音频文件ToolStripMenuItem.Text = "打开音频文件";
            this.打开音频文件ToolStripMenuItem.Click += new System.EventHandler(this.打开音频文件ToolStripMenuItem_Click);
            // 
            // 打开歌词文件ToolStripMenuItem
            // 
            this.打开歌词文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.有时间轴ToolStripMenuItem,
            this.无时间轴ToolStripMenuItem});
            this.打开歌词文件ToolStripMenuItem.Name = "打开歌词文件ToolStripMenuItem";
            this.打开歌词文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开歌词文件ToolStripMenuItem.Text = "打开歌词文件";
            // 
            // 有时间轴ToolStripMenuItem
            // 
            this.有时间轴ToolStripMenuItem.Name = "有时间轴ToolStripMenuItem";
            this.有时间轴ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.有时间轴ToolStripMenuItem.Text = "有时间轴";
            this.有时间轴ToolStripMenuItem.Click += new System.EventHandler(this.有时间轴ToolStripMenuItem_Click);
            // 
            // 无时间轴ToolStripMenuItem
            // 
            this.无时间轴ToolStripMenuItem.Name = "无时间轴ToolStripMenuItem";
            this.无时间轴ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.无时间轴ToolStripMenuItem.Text = "无时间轴";
            this.无时间轴ToolStripMenuItem.Click += new System.EventHandler(this.无时间轴ToolStripMenuItem_Click);
            // 
            // 来自剪贴板ToolStripMenuItem
            // 
            this.来自剪贴板ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.有时间轴ToolStripMenuItem1,
            this.无时间轴ToolStripMenuItem1});
            this.来自剪贴板ToolStripMenuItem.Name = "来自剪贴板ToolStripMenuItem";
            this.来自剪贴板ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.来自剪贴板ToolStripMenuItem.Text = "来自剪贴板";
            // 
            // 有时间轴ToolStripMenuItem1
            // 
            this.有时间轴ToolStripMenuItem1.Name = "有时间轴ToolStripMenuItem1";
            this.有时间轴ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.有时间轴ToolStripMenuItem1.Text = "有时间轴";
            this.有时间轴ToolStripMenuItem1.Click += new System.EventHandler(this.有时间轴ToolStripMenuItem1_Click);
            // 
            // 无时间轴ToolStripMenuItem1
            // 
            this.无时间轴ToolStripMenuItem1.Name = "无时间轴ToolStripMenuItem1";
            this.无时间轴ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.无时间轴ToolStripMenuItem1.Text = "无时间轴";
            this.无时间轴ToolStripMenuItem1.Click += new System.EventHandler(this.无时间轴ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // 保存歌词文件ToolStripMenuItem
            // 
            this.保存歌词文件ToolStripMenuItem.Name = "保存歌词文件ToolStripMenuItem";
            this.保存歌词文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.保存歌词文件ToolStripMenuItem.Text = "保存歌词文件";
            this.保存歌词文件ToolStripMenuItem.Click += new System.EventHandler(this.保存歌词文件ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.版本信息ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.帮助ToolStripMenuItem1});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 版本信息ToolStripMenuItem
            // 
            this.版本信息ToolStripMenuItem.Name = "版本信息ToolStripMenuItem";
            this.版本信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.版本信息ToolStripMenuItem.Text = "版本信息";
            this.版本信息ToolStripMenuItem.Click += new System.EventHandler(this.版本信息ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            this.帮助ToolStripMenuItem1.Click += new System.EventHandler(this.帮助ToolStripMenuItem1_Click);
            // 
            // timeBox
            // 
            this.timeBox.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeBox.Location = new System.Drawing.Point(150, 523);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(128, 27);
            this.timeBox.TabIndex = 16;
            // 
            // lrcBox
            // 
            this.lrcBox.Font = new System.Drawing.Font("微软雅黑", 11.25F);
            this.lrcBox.Location = new System.Drawing.Point(284, 523);
            this.lrcBox.Name = "lrcBox";
            this.lrcBox.Size = new System.Drawing.Size(487, 27);
            this.lrcBox.TabIndex = 17;
            this.lrcBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lrcBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "歌曲时长";
            // 
            // totalTimeBox
            // 
            this.totalTimeBox.Location = new System.Drawing.Point(15, 157);
            this.totalTimeBox.Name = "totalTimeBox";
            this.totalTimeBox.ReadOnly = true;
            this.totalTimeBox.Size = new System.Drawing.Size(100, 21);
            this.totalTimeBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "当前位置";
            // 
            // currentTimeBox
            // 
            this.currentTimeBox.Location = new System.Drawing.Point(15, 204);
            this.currentTimeBox.Name = "currentTimeBox";
            this.currentTimeBox.ReadOnly = true;
            this.currentTimeBox.Size = new System.Drawing.Size(100, 21);
            this.currentTimeBox.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "播放";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "暂停";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "停止";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(17, 332);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 26;
            this.button12.Text = "快进";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(17, 361);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 27;
            this.button13.Text = "快退";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 405);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "毫秒取近似";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(24, 523);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(52, 27);
            this.button14.TabIndex = 29;
            this.button14.Text = "更新";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "时间偏差（毫秒）";
            // 
            // offset_box
            // 
            this.offset_box.Location = new System.Drawing.Point(19, 486);
            this.offset_box.Name = "offset_box";
            this.offset_box.Size = new System.Drawing.Size(100, 21);
            this.offset_box.TabIndex = 31;
            this.offset_box.Text = "-100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.offset_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.currentTimeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalTimeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lrcBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lrcList);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.player);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌词制作器 v1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.ListBox lrcList;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开音频文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开歌词文件ToolStripMenuItem;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox lrcBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalTimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentTimeBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.ToolStripMenuItem 保存歌词文件ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem 来自剪贴板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ToolStripMenuItem 有时间轴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 无时间轴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 有时间轴ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 无时间轴ToolStripMenuItem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox offset_box;
    }
}

