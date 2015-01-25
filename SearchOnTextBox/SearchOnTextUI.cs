using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchOnTextBox
{
    public partial class SearchOnTextUI : Form
    {
        public SearchOnTextUI()
        {
            InitializeComponent();
        }

        private string text;
        private string findText;
        private string find;
        
        private string previousWord;

        

        public void TakeInput()
        {
            text = inputTextTextBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TakeInput();
            MessageBox.Show(text);
        }

        public void PreviousWork()
        {
            string word = "";
            for (int i = 0; i < text.Length; i++)
            {
                
                if (text[i] != ' ')
                {
                    word = word + text[i];

                    if (word == previousWord)
                    {

                        inputTextTextBox.Select(i - (word.Length - 1), word.Length);
                        inputTextTextBox.SelectionColor = Color.Black;
                        inputTextTextBox.DeselectAll();

                        word = "";
                    }

                }

                else if (text[i] == ' ')
                {
                    word = "";
                }

            }
        }
        private void findButton_Click(object sender, EventArgs e)
        {
            string word = "";
            int count = 0;
            if (previousWord != null)
            {
                PreviousWork();
            }
          
            findText = searchTextBox.Text;
            previousWord = findText;
            for (int i = 0; i<text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    word = word + text[i];
                  
                    if (word == findText)
                    {
                        
                        inputTextTextBox.Select(i -( word.Length-1), word.Length);
                        inputTextTextBox.SelectionColor = Color.Red;
                        inputTextTextBox.DeselectAll();
                        
                        word = "";
                        count++;
                    }
                    
                }
               
                else if(text[i]==' ')

                {
                    word = "";
                }
                
            }
            totalFindNumberTextBox.Text = count.ToString();
            
        }
    }
}
