using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note
{
    
    struct  note
    {
        public string title;
        public string message;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
         List<note> notes=new List<note>();

        private void button1_Click(object sender, EventArgs e)
        {
            titles.Clear();
            messages.Clear();
           

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int g = 0;
            for (int i = 0; i < notes.Count; i++)
            {
                if (titles.Text == notes[i].title)
                {
                    MessageBox.Show("this title is taken", "wrong title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    g=1;
                }
            }

            if (g == 0)
            {
                notes.Add(new note { title = titles.Text, message = messages.Text });
                titles.Clear();
                messages.Clear();

                string txt = "";
                int k;
                for (int j = 0; j < notes.Count; j++)
                {
                    k = j + 1;
                    txt = txt + k + ") " + notes[j].title + "\r\n";
                }
                thetitles.Text = txt;
            }
               

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int y =0;
            for(int i = 0; i < notes.Count; i++)
            {
                if( notes[i].title ==txtRead.Text )
                {
                    titles.Text = notes[i].title;
                    messages.Text = notes[i].message;
                     y = 1;
                    break;
                }
               

            }
            txtRead.Clear();
            if (y != 1)
                MessageBox.Show("this title not found", "wrong title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int z=0;
            for(int i = 0; i < notes.Count; i++)
            {
                if (txtRead.Text == notes[i].title)
                {
                   notes.RemoveAt(i);
                    z = 1;
                    break;

                }
                
            }
            string txt = "";
            int k;
            for (int j = 0; j < notes.Count; j++)
            {
                k = j + 1;
                txt = txt + k + ") " + notes[j].title + "\r\n";
            }
            thetitles.Text = txt;
            
            titles.Clear();
            messages.Clear();
            txtRead.Clear();
            if(z != 1)
                MessageBox.Show("this title not found", "wrong title", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
        
        private void thetitles_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                messages.Font = fontDlg.Font;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            int z =0;
            for (int i = 0; i < notes.Count; i++)
            {
                if (titles.Text == notes[i].title)
                {
                    notes[i]=(new note { title = titles.Text, message = messages.Text });
                    titles.Clear();
                    messages.Clear();

                    string txt = "";
                    int k;
                    for (int j = 0; j < notes.Count; j++)
                    {
                        k = j + 1;
                        txt = txt + k + ") " + notes[j].title + "\r\n";
                    }
                    thetitles.Text = txt;
                    z = 1;

                }
            }
            if(z == 0)
                MessageBox.Show("this title not found", "wrong title", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
