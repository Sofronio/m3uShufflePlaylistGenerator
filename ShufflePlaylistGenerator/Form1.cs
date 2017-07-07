using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShufflePlayerlistGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox_Input.AllowDrop = true;
            listBox_Input.DragEnter += new DragEventHandler(Form1_DragEnter);
            listBox_Input.DragDrop += new DragEventHandler(listBox_Input_DragDrop);
            listBox_Ad.AllowDrop = true;
            listBox_Ad.DragEnter += new DragEventHandler(Form1_DragEnter);
            listBox_Ad.DragDrop += new DragEventHandler(listBox_Ad_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        void listBox_Input_DragDrop(object sender, DragEventArgs e)
        {
            listBox_Input.Items.Clear();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            AddFilesToListBox(files, listBox_Input);
        }

        void listBox_Ad_DragDrop(object sender, DragEventArgs e)
        {
            listBox_Ad.Items.Clear();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            AddFilesToListBox(files, listBox_Ad);
        }

        private void button_ClearInput_Click(object sender, EventArgs e)
        {
            listBox_Input.Items.Clear();
        }

        private void button_ClearAd_Click(object sender, EventArgs e)
        {
            listBox_Ad.Items.Clear();
        }

        private void button_ClearList_Click(object sender, EventArgs e)
        {
            listBox_List.Items.Clear();
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            int flag = 1;
            for (int i = 0; i < numericUpDown_Repeat.Value; i++)
            {                
                if (radioButton_orderShuffle.Checked) //shuffle video each time before adding to playlist
                    ShuffleListBox(listBox_Input);
                foreach (var itemInput in listBox_Input.Items)
                {
                    listBox_List.Items.Add(itemInput.ToString()); //Add input video to playlist
                    if (radioButton_WithAd.Checked == true) //Ad video switch
                    {
                        if (flag % numericUpDown_Ad.Value == 0) //every numericUpDown_Ad.Value add Ad video
                            foreach (var itemAD in listBox_Ad.Items)
                                listBox_List.Items.Add(itemAD.ToString());
                        flag++;
                    }
                }
            }
            this.Text = listBox_Input.Items.Count.ToString() + " Lines processed, " + listBox_List.Items.Count.ToString() + " Lines generated";
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "m3u playlist (*.m3u)|*.m3u";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in listBox_List.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Save playlist to file", "Success");
            }
        }

        void ShuffleListBox(ListBox listBox)
        {
            var ShuffleList = new List<string>();
            foreach (var item in listBox.Items)
            {
                ShuffleList.Add(item.ToString());
            }
            ShuffleList.Shuffle();
            listBox.Items.Clear();
            foreach (var ShuffleListItem in ShuffleList)
            {                
                listBox.Items.Add(ShuffleListItem.ToString());
            }
        }

        void AddFilesToListBox(string[] files, ListBox listBox)
        {
            foreach (string file in files)
            {
                //split the filters
                string[] str_including_ext = textBox_ext_including.Text.Split(',');
                string[] str_excluding_ext = textBox_ext_excluding.Text.Split(',');

                //find out whether 'string file' is a file or a path
                FileAttributes attr = File.GetAttributes(file);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    //it's a path
                    foreach (string subfile in Directory.GetFiles(file))
                    {
                        //file extention filter

                        if (radioButton_ext_including.Checked)
                        {
                            if (str_including_ext.Any(x => subfile.EndsWith(x.Trim())))
                            {
                                listBox.Items.Add(subfile);
                            }
                        }
                        else
                        {
                            if (!str_excluding_ext.Any(x => subfile.EndsWith(x.Trim())))
                            {
                                listBox.Items.Add(subfile);
                            }
                        }
                    }
                    foreach (string subfile in Directory.GetDirectories(file))
                        AddFilesToListBox(Directory.GetFiles(subfile), listBox);
                }
                else
                {
                    //it's a file

                    //file extention filter

                    if (radioButton_ext_including.Checked)
                    {
                        if (str_including_ext.Any(x => file.EndsWith(x.Trim())))
                        {
                            listBox.Items.Add(file);
                        }
                    }
                    else
                    {
                        if (!str_excluding_ext.Any(x => file.EndsWith(x.Trim())))
                        {
                            listBox.Items.Add(file);
                        }
                    }
                }
            }
        }
    }

    //Random
    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
