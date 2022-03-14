using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Form1 : Form
    {

        string[] b_name = {"海賊王驚點語錄", "魔法", "少年 Pi 的奇幻漂流", "教育應該不一樣",
                           "秘密", "Google 英語學習法", "深夜食堂 9", "我就是忍不住笑了"};

        string[] author = {"冒牌生", "朗達.拜恩", "楊.馬泰爾", "嚴長壽","朗達.拜恩",
                           "藤田英時", "安倍夜郎", "侯文詠"};

        string[] publisher = {"平裝本", "方智", "皇冠", "天下文化", "方智",
                              "國際學社", "新經典文化", "皇冠"};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] options = { "大圖示", "詳細資料", "小圖示", "清單", "大圖示加詳細資料" };
            cboView.Items.AddRange(options);
            lstvBooks.LargeImageList = imgL;
            lstvBooks.SmallImageList = imgS;
            cboView.SelectedIndex = 0;
            lstvBooks.Columns.Add("書名", 120);
            lstvBooks.Columns.Add("作者", 80);
            lstvBooks.Columns.Add("出版社", 80);
            lstvBooks.BeginUpdate();
            for (int i = 0; i < b_name.Length; i++)
            {
                ListViewItem lvi = new ListViewItem(b_name[i]);
                lvi.SubItems.Add(author[i].ToString());
                lvi.SubItems.Add(publisher[i].ToString());
                lstvBooks.Items.Add(lvi);
                lstvBooks.Items[i].ImageIndex = i;
            }
            lstvBooks.EndUpdate();
        }

        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboView.SelectedIndex)
            {
                case 0:
                    lstvBooks.View = View.LargeIcon;
                    break;
                case 1:
                    lstvBooks.View = View.Details;
                    break;
                case 2:
                    lstvBooks.View = View.SmallIcon;
                    break;
                case 3:
                    lstvBooks.View = View.List;
                    break;
                case 4:
                    lstvBooks.View = View.Tile;
                    break;
            }
        }

        private void lstvBooks_ItemActivate(object sender, EventArgs e)
        {
            bool exist = lstBorrow.Items.Contains(b_name[lstvBooks.SelectedIndices[0]]);
            if (!exist)
            {
                DialogResult dr = MessageBox.Show("確定要借閱嗎?", b_name[lstvBooks.SelectedIndices[0]], MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    lstBorrow.Items.Add(b_name[lstvBooks.SelectedIndices[0]]);
                }
            }
        }
    }
}
