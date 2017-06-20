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
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }
        void AddFilesToListBox(string[] files)
        {
            foreach (string file in files)
            {
                //split the filters
                string[] str_including_ext = textBox_ext_including.Text.Split(',');
                string[] str_excluding_ext = textBox_ext_excluding.Text.Split(',');

                //find out if file is a file or a path
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
                                listBox1.Items.Add(subfile);
                            }
                        }
                        else
                        {
                            if (!str_excluding_ext.Any(x => subfile.EndsWith(x.Trim())))
                            {
                                listBox1.Items.Add(subfile);
                            }
                        }
                    }
                    foreach (string subfile in Directory.GetDirectories(file))
                        AddFilesToListBox(Directory.GetFiles(subfile));
                }
                else
                {
                    //it's a file

                    //file extention filter

                    if (radioButton_ext_including.Checked)
                    {
                        if (str_including_ext.Any(x => file.EndsWith(x.Trim())))
                        {
                            listBox1.Items.Add(file);
                        }
                    }
                    else
                    {
                        if (!str_excluding_ext.Any(x => file.EndsWith(x.Trim())))
                        {
                            listBox1.Items.Add(file);
                        }
                    }
                }
            }
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.Items.Clear();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            AddFilesToListBox(files);
        }

        void ShuffleListBox(ListBox input_listBox)
        {
            var ShuffleList = new List<string>();
            foreach (var item in input_listBox.Items)
            {
                ShuffleList.Add(item.ToString());
            }
            ShuffleList.Shuffle();
            foreach (var ShuffleListItem in ShuffleList)
            {
                listBox2.Items.Add(ShuffleListItem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                if (radioButton2.Checked)

                {
                    ShuffleListBox(listBox1);
                }
                else
                {
                    foreach (var item in listBox1.Items)
                    {
                        listBox2.Items.Add(item.ToString());
                    }
                }
            }
            this.Text = listBox1.Items.Count.ToString() + " Lines processed, " + listBox2.Items.Count.ToString() + " Lines generated";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "m3u playlist (*.m3u)|*.m3u";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in listBox2.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Save playlist to file", "Success");
            }
        }
    }

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
