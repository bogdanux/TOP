using System;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmTOP : Form
    {
        public frmTOP()
        {
            InitializeComponent();
        }

        private void tsmiIesire_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vizualizareFunctiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmVizualizareFunctii = new frmVizualizareFunctii();

            frmVizualizareFunctii.MdiParent = this;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmVizualizareFunctii))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }

            frmVizualizareFunctii.Show();
        }

        private void btnAdaugareFunctii_Click(object sender, EventArgs e)
        {
            Form frmAdaugareFunctii = new frmAdaugareFunctii();

            frmAdaugareFunctii.MdiParent = this;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmAdaugareFunctii))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }

            frmAdaugareFunctii.Show();
        }

        private void btnModificareFunctii_Click(object sender, EventArgs e)
        {
            Form frmModificareFunctii = new frmModificareFunctii();

            frmModificareFunctii.MdiParent = this;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmModificareFunctii))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }

            frmModificareFunctii.Show();
        }

        private void vizualizareUtilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmVizualizareUtilizatori = new frmVizualizareUtilizatori();

            frmVizualizareUtilizatori.MdiParent = this;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmVizualizareUtilizatori))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }

            frmVizualizareUtilizatori.Show();
        }

        private void btnAdaugareUtilizatori_Click(object sender, EventArgs e)
        {
            Form frmAdaugareUtilizatori = new frmAdaugareUtilizatori();

            frmAdaugareUtilizatori.MdiParent = this;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmAdaugareUtilizatori))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }

            frmAdaugareUtilizatori.Show();
        }

        private void btnModificareUtilizatori_Click(object sender, EventArgs e)
        {
            Form frmModificareUtilizatori = new frmModificareUtilizatori();

            frmModificareUtilizatori.MdiParent = this;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmModificareUtilizatori))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }

            frmModificareUtilizatori.Show();
        }

        private void btnAdaugareProduse_Click(object sender, EventArgs e)
        {
            Form frmAdaugareProduse = new frmAdaugareProduse();

            frmAdaugareProduse.MdiParent = this;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmAdaugareProduse))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }

            frmAdaugareProduse.Show();
        }

        private void btnModificareProduse_Click(object sender, EventArgs e)
        {
            Form frmModificareProduse = new frmModificareProduse();

            frmModificareProduse.MdiParent = this;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(frmModificareProduse))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }

            frmModificareProduse.Show();
        }

        private void btnVizualizareProduse_Click(object sender, EventArgs e)
        {
            Form form = new frmVizualizareProduse();

            form.MdiParent = this;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmVizualizareProduse))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();
        }

        private void btnAdaugareStructuri_Click(object sender, EventArgs e)
        {
            Form form = new frmAdaugareStructuri();

            form.MdiParent = this;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmAdaugareStructuri))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();
        }

        private void btnModificareStructuri_Click(object sender, EventArgs e)
        {
            Form form = new frmModificareStructuri();

            form.MdiParent = this;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmModificareStructuri))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();
        }

        private void vizualizareStructuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmVizualizareStructuri();

            form.MdiParent = this;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmVizualizareStructuri))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();
        }

        private void btnAdaugareNiveluri_Click(object sender, EventArgs e)
        {

        }

        private void btnModificareNiveluri_Click(object sender, EventArgs e)
        {

        }

        private void vizualizareNiveluriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmVizualizareNiveluri();

            form.MdiParent = this;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmVizualizareNiveluri))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();
        }
    }
}
