﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cluster_5
{
    public partial class Quiz : Form
    {
        List<Player> scores = new List<Player>();

        public Quiz(List<Player> tempScore)
        {
            InitializeComponent();

            scores = tempScore;
        }
    }
}
