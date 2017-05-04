﻿using OSC.Classes;
using System;
using OSC.Problem_Classes;
using System.Windows.Forms;

namespace OSC
{
    public partial class SimplexMain : Form
    {
        ProblemData _problem;
        public SimplexMain(ProblemData problem)
        {
            InitializeComponent();
            _problem = problem;
        }
    
        public SimplexMain()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (Helpers.BackForm())
            {
                if (Application.OpenForms["Restriction"] != null)
                    Application.OpenForms["Restriction"].Show();
                else
                    Application.OpenForms["Main"].Show();
                Hide();
            }
        }

        private void btnStepByStep_Click(object sender, EventArgs e)
        {
            new SimplexMethod(_problem, true);

        }

        private void btnSimplesExecution_Click(object sender, EventArgs e)
        {
            new SimplexMethod(_problem, false);

        }

        private void SimplexMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
