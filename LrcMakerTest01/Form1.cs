using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;

namespace LrcMakerTest01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string currentAddress = string.Empty;
        private void button2_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            currentTimeBox.Text = lrcList.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lrcList.Items.Clear();
            timer1.Interval = 1;
            timer1.Start();
        }

        // 删除项
        private void button7_Click(object sender, EventArgs e)
        {
            if (lrcList.SelectedIndex == -1)
            {
                //MessageBox.Show("没有选中项", "提示");
                return;
            }
            else
            {
                AddHistory();

                int index = lrcList.SelectedIndex;
                lrcList.Items.RemoveAt(index);
                if (lrcList.Items.Count < index + 1)
                {
                    lrcList.SelectedIndex = lrcList.Items.Count - 1;
                }
                else
                {
                    lrcList.SelectedIndex = index;
                }
            }
        }

        private void lrcList_DoubleClick(object sender, EventArgs e)
        {
            if (lrcList.SelectedIndex == -1) return;
            player.Ctlcontrols.currentPosition = Time.Parse(timeBox.Text).ActualSeconds;
            player.Ctlcontrols.play();
        }
        private void lrcList_Click(object sender, EventArgs e)
        {
            if (lrcList.SelectedIndex == -1) return;
            Regex t = new Regex(@"(?<=\[).*?(?=\])");
            Regex l = new Regex(@"(?<=\]).*$", RegexOptions.Multiline);
            string temp = lrcList.SelectedItem.ToString();
            string time = t.Match(temp).ToString();
            string lyric = l.Match(temp).ToString();

            // 如果这一行标签中的内容无法解析为时间，则强制认为是信息标签，且无视方括号外的其他内容
            if (!Time.TryParse(time))
            {
                timeBox.Text = "";
                lrcBox.Text = time;
            }
            else
            {
                timeBox.Text = time;
                lrcBox.Text = lyric; ;
            }
        }

        // 插入项
        private void button6_Click(object sender, EventArgs e)
        {
            AddHistory();

            player.Ctlcontrols.pause();

            Time currentTime = Time.Parse(player.Ctlcontrols.currentPosition);

            string temp = string.Empty;
            if (currentTime.ActualSeconds == 0.0)
            { }
            else if (!checkBox1.Checked)
            {
                temp = currentTime.Info;
            }
            else
            {
                temp = currentTime.ApproxInfo;
            }

            int index = lrcList.SelectedIndex + 1;
            lrcList.Items.Insert(index, "[" + temp + "]");
            lrcList.SelectedIndex = index;

            lrcList_Click(this, null);
            lrcBox.Focus();
        }

        // 修改
        private void button1_Click(object sender, EventArgs e)
        {
            AddHistory();

            if (lrcList.SelectedIndex != -1)
            {
                if (timeBox.Text != "")
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append('[');
                    sb.Append(timeBox.Text);
                    sb.Append(']');
                    sb.Append(lrcBox.Text);
                    lrcList.Items[lrcList.SelectedIndex] = sb.ToString();
                }
                else if (lrcBox.Text == "")
                {
                    lrcList.Items[lrcList.SelectedIndex] = "";
                }
                else
                {
                    lrcList.Items[lrcList.SelectedIndex] = "[" + lrcBox.Text + "]";
                }
            }
        }

        // 清空
        private void button10_Click(object sender, EventArgs e)
        {
            AddHistory();

            lrcList.Items.Clear();
        }

        // 插入信息
        private void button5_Click(object sender, EventArgs e)
        {
            AddHistory();

            lrcList.Items.Insert(0, "[ar:艺人名]");
            lrcList.Items.Insert(1, "[ti:曲名]");
            lrcList.Items.Insert(2, "[al:专辑名]");
            lrcList.Items.Insert(3, "[by:编者]");
        }

        // 播放
        private void button2_Click_1(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }
        // 暂停
        private void button3_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }
        // 停止
        private void button4_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        // 计时器Tick，仅用来更新当前时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.URL == string.Empty) return;
            currentTimeBox.Text = Time.Parse(player.Ctlcontrols.currentPosition).Info;
            totalTimeBox.Text = Time.Parse(player.currentMedia.duration).Info;
        }

        // 快进
        private void button12_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.currentPosition += 5.0;
        }
        // 快退
        private void button13_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.currentPosition -= 5.0;
        }

        // 回车键 = 修改 + 播放
        private void lrcBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(this, null);
                button6.Focus();
                player.Ctlcontrols.play();
            }
        }

        // 上移
        private void button8_Click(object sender, EventArgs e)
        {
            AddHistory();

            if (lrcList.SelectedIndex == -1 || lrcList.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                int index = lrcList.SelectedIndex;
                var temp = lrcList.Items[index];
                lrcList.Items[index] = lrcList.Items[index - 1];
                lrcList.Items[index - 1] = temp;
                lrcList.SelectedIndex = index - 1;
            }
        }
        // 下移
        private void button9_Click(object sender, EventArgs e)
        {
            AddHistory();

            if (lrcList.SelectedIndex == -1)
            {
                return;
            }
            else if (lrcList.SelectedIndex == lrcList.Items.Count - 1)
            {
                return;
            }
            else
            {
                int index = lrcList.SelectedIndex;
                var temp = lrcList.SelectedItem;
                lrcList.Items[index] = lrcList.Items[index + 1];
                lrcList.Items[index + 1] = temp;
                lrcList.SelectedIndex = index + 1;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO 检测LrcList是否已经保存
            Close();
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("readme.txt")) return;
            StreamReader r = new StreamReader("readme.txt", Encoding.Default);
            MessageBox.Show(r.ReadToEnd(), "帮助");
        }

        // 添加新的历史记录
        private void AddHistory()
        {
            history.Add(new History(lrcList));
            if (history.Count > 20)
                history.RemoveAt(0);

            button11.Enabled = true;
        }

        // 撤销
        private void button11_Click(object sender, EventArgs e)
        {
            int count = history.Count;
            if (count == 0) return;

            //MessageBox.Show(history[count - 1].Info);
            lrcList.Items.Clear();
            for (int i = 0; i < history[count - 1].List.Count; i++)
            {
                lrcList.Items.Add(history[count - 1].List[i]);
            }
            lrcList.SelectedIndex = history.Last().Index;
            history.RemoveAt(count - 1);

            if (history.Count == 0)
                button11.Enabled = false;
        }
        private List<History> history = new List<History>();

        // 更新
        private void button14_Click(object sender, EventArgs e)
        {
            Time origin = Time.Parse(currentTimeBox.Text);
            origin += GetOffset();
            timeBox.Text = origin.Info;
            button1_Click(this, null);
            if (lrcList.SelectedIndex < lrcList.Items.Count - 1)
            {
                lrcList.SelectedIndex++;
                lrcList_Click(this, null);
            }
        }

        private void 有时间轴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "lrc文件|*.lrc|其他格式|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(open.FileName, System.Text.Encoding.Default))
                {
                    lrcList.Items.Clear();
                    while (!reader.EndOfStream)
                    {
                        lrcList.Items.Add(reader.ReadLine());
                    }
                }

                lrcList.SelectedIndex = 0;
                lrcList_Click(this, null);
            }
            open.Dispose();
        }
        private void 无时间轴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "lrc文件|*.lrc|其他格式|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(open.FileName, System.Text.Encoding.Default))
                {
                    lrcList.Items.Clear();
                    while (!reader.EndOfStream)
                    {
                        lrcList.Items.Add("[00:00.000]" + reader.ReadLine());
                    }
                }

                lrcList.SelectedIndex = 0;
                lrcList_Click(this, null);
            }
            open.Dispose();
        }
        private void 有时间轴ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText()) return;
            string temp = Clipboard.GetText();
            Regex r = new Regex(Environment.NewLine);
            lrcList.Items.Clear();
            string[] list = r.Split(temp);
            for (int i = 0; i < list.Count(); i++)
            {
                lrcList.Items.Add(list[i]);
            }

            lrcList.SelectedIndex = 0;
            lrcList_Click(this, null);
        }
        private void 无时间轴ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText()) return;
            string temp = Clipboard.GetText();
            Regex r = new Regex(Environment.NewLine);
            lrcList.Items.Clear();
            string[] list = r.Split(temp);
            for (int i = 0; i < list.Count(); i++)
            {
                lrcList.Items.Add("[00:00.000]" + list[i]);
            }

            lrcList.SelectedIndex = 0;
            lrcList_Click(this, null);
        }
        private void 打开音频文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                currentAddress = player.URL = addressBox.Text = open.FileName;
                player.Ctlcontrols.stop();
            }
            open.Dispose();
        }
        private void 保存歌词文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.DefaultExt = ".lrc";
            s.Filter = "lrc文件|*.lrc|其他格式|*.*";
            string nnn = Path.GetFileNameWithoutExtension(currentAddress) + ".lrc";
            if (nnn == "") nnn = "歌词文件";
            s.FileName = nnn;
            if (s.ShowDialog() == DialogResult.OK)
            {
                string address = s.FileName;
                using (StreamWriter w = new StreamWriter(address, false, Encoding.Default))
                {
                    w.Write(GetLrcText());
                    w.Close();
                }
            }
            s.Dispose();
        }

        // 从LrcList中获取当前的文本
        private string GetLrcText()
        {
            if (lrcList.Items.Count == 0) return string.Empty;
            StringBuilder sb = new StringBuilder();
            string newline = Environment.NewLine;
            sb.Append(lrcList.Items[0].ToString());
            for (int i = 1; i < lrcList.Items.Count; i++)
            {
                sb.Append(newline);
                sb.Append(lrcList.Items[i].ToString());
            }
            return sb.ToString();
        }
        private Time GetOffset()
        {
            double offset = Convert.ToDouble(offset_box.Text) / 1000;
            return new Time(offset);
        }
        private void 版本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
