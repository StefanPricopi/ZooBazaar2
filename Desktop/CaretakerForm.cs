using Animals;
using Logic.DTO;
using Logic.Interfaces;
using Logic.Managers;
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

namespace Desktop
{
    public partial class CaretakerForm : Form
    {
        private IAnimal animalRepository;
        private Form activeForm;

        public CaretakerForm(IAnimal animalRepository)
        {
            InitializeComponent();
            this.animalRepository = animalRepository;

            SetGradientForPanel();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlFormContainer.Controls.Add(childForm);
            this.pnlFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void SetGradientForPanel()
        {
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(panel1.Width, panel1.Height),
                Color.FromArgb(207, 162, 253),  // Start color
                Color.FromArgb(173, 216, 230)); // End color

            // Adjust color stop positions to provide more emphasis on the end color
            ColorBlend colorBlend = new ColorBlend();
            colorBlend.Colors = new Color[] { gradientBrush.LinearColors[0], gradientBrush.LinearColors[1] };
            colorBlend.Positions = new float[] { 0.0f, 1f }; // Adjust the position values as needed

            gradientBrush.InterpolationColors = colorBlend;

            panel1.BackgroundImage = new Bitmap(1, 1);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = GetGradientImage(panel1.ClientRectangle, gradientBrush);
        }



        private Image GetGradientImage(Rectangle bounds, LinearGradientBrush brush)
        {
            Bitmap gradientImage = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics g = Graphics.FromImage(gradientImage))
            {
                g.FillRectangle(brush, bounds);
            }

            return gradientImage;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddAnimal(animalRepository), sender);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewAnimalDetails(animalRepository), sender);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            List<AnimalDTO> animals = animalRepository.GetAllAnimals();
            OpenChildForm(new UpdateAnimal(animalRepository, animals), sender);
        }
    }
}
