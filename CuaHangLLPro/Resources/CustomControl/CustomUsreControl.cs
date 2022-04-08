using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;


namespace CuaHangLLPro.Resources.CustomControl
{
    class CustomUsreControl : UserControl
    {
        private int boderSize = 0;
        private int boderRadius = 40;
        private Color boderColor = Color.HotPink;

        [Category("CustomTextBoxAdvance")]
        public int BoderSize { get => boderSize; set { boderSize = value; this.Invalidate(); } }

        [Category("CustomTextBoxAdvance")]
        public int BoderRadius
        {
            get => boderRadius;
            set
            {
                if (value <= this.Height)
                    boderRadius = value;
                else
                    boderRadius = this.Height;
                this.Invalidate();
            }
        }

        [Category("CustomTextBoxAdvance")]
        public Color BoderColor
        {
            get
            {
                return boderColor;
            }
            set
            {
                boderColor = value;
                this.Invalidate();
            }
        }

        [Category("CustomTextBoxAdvance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("CustomTextBoxAdvance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Contructor
        public CustomUsreControl()
        {
           
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }



        //Methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;

        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF recSurFace = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBoder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (boderRadius > 2)
            {
                using (GraphicsPath pathSurFace = GetFigurePath(recSurFace, boderRadius))
                using (GraphicsPath pathBoder = GetFigurePath(rectBoder, boderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBoder = new Pen(boderColor, boderSize))
                {
                    penBoder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurFace);

                    pevent.Graphics.DrawPath(penSurface, pathSurFace);

                    if (boderSize >= 1)
                        pevent.Graphics.DrawPath(penBoder, pathBoder);

                }
            }
            else
            {
                this.Region = new Region(recSurFace);
                if (boderSize >= 1)
                {
                    using (Pen penBoder = new Pen(boderColor, boderSize))
                    {
                        penBoder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBoder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();

        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (boderRadius > this.Height)
                BoderRadius = this.Height;
        }
    }
}
