namespace CRUD_aluno
{
    partial class Cadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            menuStrip1 = new MenuStrip();
            CadastrosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarmAlunoToolStripMenuItem = new ToolStripMenuItem();
            cursosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { CadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1435, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // CadastrosToolStripMenuItem
            // 
            CadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarmAlunoToolStripMenuItem, cursosToolStripMenuItem });
            CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem";
            CadastrosToolStripMenuItem.Size = new Size(88, 24);
            CadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarmAlunoToolStripMenuItem
            // 
            cadastrarmAlunoToolStripMenuItem.Name = "cadastrarmAlunoToolStripMenuItem";
            cadastrarmAlunoToolStripMenuItem.Size = new Size(224, 26);
            cadastrarmAlunoToolStripMenuItem.Text = "Alunos";
            cadastrarmAlunoToolStripMenuItem.Click += cadastrarmAlunoToolStripMenuItem_Click;
            // 
            // cursosToolStripMenuItem
            // 
            cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            cursosToolStripMenuItem.Size = new Size(224, 26);
            cursosToolStripMenuItem.Text = "Cursos";
            cursosToolStripMenuItem.Click += cursosToolStripMenuItem_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1441, 643);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Cadastro";
            Text = "Sistema de Gerenciamento Acadêmico";
            WindowState = FormWindowState.Maximized;
            FormClosing += Cadastro_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem CadastrosToolStripMenuItem;
        private ToolStripMenuItem cadastrarmAlunoToolStripMenuItem;
        private ToolStripMenuItem cursosToolStripMenuItem;
    }
}
