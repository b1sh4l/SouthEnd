using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShopManagementSystem.UserControls
{
    public partial class ucWelcome : UserControl
    {
        private static ucWelcome instance;
        public static ucWelcome Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucWelcome();
                return instance;
            }
        }
        public ucWelcome()
        {
            InitializeComponent();
        }
    }
}
