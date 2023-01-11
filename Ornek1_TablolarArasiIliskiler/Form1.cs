using Ornek1_TablolarArasiIliskiler.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1_TablolarArasiIliskiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Context context = new Context())
            {
                Category category = new Category() { Name = "Bebek" };

                context.Categories.Add(category);
                context.SaveChanges();
            }
        }
    }
}
