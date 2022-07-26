using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevitAddinSeesion04
{
    public partial class FfmWallsFromLines : Form
    {
        public FfmWallsFromLines(List<string> walltypes, List<string> lineStyles)
        {
            InitializeComponent();

            foreach (string wallType in walltypes)
            {
                this.CmbWalltypes.Items.Add(wallType);

            }

            foreach (string lineStyle in lineStyles)
            {
                this.CmbLinestyles.Items.Add(lineStyle);

            }

            this.CmbWalltypes.SelectedIndex = 0;
            this.CmbLinestyles.SelectedIndex = 0;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
