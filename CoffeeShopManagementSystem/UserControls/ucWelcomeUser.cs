using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShopManagementSystem.UserControls
{
    public partial class ucWelcomeUser : UserControl
    {
        private static ucWelcomeUser instance;
        public static ucWelcomeUser Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucWelcomeUser();
                return instance;
            }
        }
        public ucWelcomeUser()
        {
            InitializeComponent();
        }
    }
}
