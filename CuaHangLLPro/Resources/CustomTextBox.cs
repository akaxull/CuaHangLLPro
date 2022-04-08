using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangLLPro.Resources
{

    public partial class CustomTextBox : TextBox
    {
        private Color boderFocusColor = Color.Black;
        private Color boderColor = Color.Red;
        private Color placeholderColor = Color.DarkGray;
        private Color nomalColor = Color.Black;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isFocused = false;
        private AutoCompleteMode autoCompleteMode = AutoCompleteMode.SuggestAppend;
        private AutoCompleteSource autoCompleteSource = AutoCompleteSource.CustomSource;


        public CustomTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Controls.Add(new Label
            {
                Height = 2,
                Dock = DockStyle.Bottom,
                BackColor = boderColor
            }); 
            InitializeComponent();
        }

        public new BorderStyle borderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }
      

   
        [Category("CustomTextBoxAdvance")]
        public Color BoderColor
        {
            get => boderColor;
            set
            {
                boderColor = value;
                Controls[0].BackColor = boderColor;
                this.Invalidate();
            }
        }

        public Color BoderFocusColor
        {
            get => boderFocusColor;
            set
            {
                boderFocusColor = value;
                Controls[0].BackColor = boderFocusColor;
                this.Invalidate();
            }
        }
        [Category("CustomTextBoxAdvance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("CustomTextBoxAdvance")]
        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else
                    return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                isPlaceholder = false;
                setPlaceHoder();
            }

        }

        [Category("CustomTextBoxAdvance")]
        public Color PlaceholderColor 
        { 
            get => placeholderColor;
            set
            {
                placeholderColor = value;
            }
        }

        [Category("CustomTextBoxAdvance")]
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                setPlaceHoder();
            }
        
        }

        [Category("CustomTextBoxAdvance")]
        public AutoCompleteMode AutoCompleteMode { get => autoCompleteMode; set { autoCompleteMode = value; this.Invalidate(); } }

        [Category("CustomTextBoxAdvance")]
        public AutoCompleteSource AutoCompleteSource { get => autoCompleteSource; set { autoCompleteSource = value; this.Invalidate(); } }


        [Category("CustomTextBoxAdvance")]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return textBox1.AutoCompleteCustomSource;
            }
            set
            {
                textBox1.AutoCompleteCustomSource = value;
              
            }
        }

        

        private void setPlaceHoder()
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {              
                    isPlaceholder = true;
                    textBox1.Text = placeholderText;
                    textBox1.ForeColor = placeholderColor;
            }
        }

       private void removePlaceHolder()
        {
            if (isPlaceholder)
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Controls[0].BackColor = boderFocusColor;
            isFocused = true;
            this.Invalidate();
            removePlaceHolder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Controls[0].BackColor = boderColor;
            isFocused = false;
            this.Invalidate();
            setPlaceHoder();
        }

    }
}   
