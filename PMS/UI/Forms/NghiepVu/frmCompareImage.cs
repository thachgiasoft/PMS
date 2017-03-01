using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using System.IO;
using System.Drawing.Imaging;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Common;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmCompareImage : DevExpress.XtraEditors.XtraForm
    {
        public frmCompareImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PMS.Common.ComparingImages.CompareResult cx = ComparingImages.Compare(pictureBox1.Image, pictureBox2.Image);
            MessageBox.Show(cx.ToString());
        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                // Convert byte[] to Base64 String
                return Convert.ToBase64String(imageBytes);
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            return Image.FromStream(ms, true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ImageToBase64(pictureBox1.Image, ImageFormat.Jpeg);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = ImageToBase64(pictureBox2.Image, ImageFormat.Jpeg);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
                MessageBox.Show("OK");
            else
                MessageBox.Show("NotOK");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.TextLength.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.TextLength.ToString());
        }

        private void frmCompareImage_Load(object sender, EventArgs e)
        {
            AppGridLookupEdit.InitGridLookUp(cboTemp, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboTemp, new string[] { "ReportId" }, new string[] { "ReportId" });
            cboTemp.Properties.ValueMember = "Data";
            cboTemp.Properties.DisplayMember = "ReportId";
            cboTemp.Properties.NullText = string.Empty;

            bindingSource1.DataSource = DataServices.ReportTemplate.GetAll();
        }

        public string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            //byte[] bs = System.Text.Encoding.ASCII.GetBytes(input);
            //byte[] bs = System.Text.Encoding.UTF7.GetBytes(input);
            //byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            byte[] bs = System.Text.Encoding.Unicode.GetBytes(input);
            //byte[] bs = System.Text.Encoding.UTF32.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
                s.Append(b.ToString("x2").ToLower());
            return s.ToString();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ReportTemplate obj = bindingSource1.Current as ReportTemplate;
            if (obj != null)
            {
                //ReportTemplate x=DataServices.ReportTemplate.get
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = GetMD5Hash(textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = GetMD5Hash(textBox2.Text);
        }
    }
}