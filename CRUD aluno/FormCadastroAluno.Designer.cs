namespace CRUD_aluno
{
    partial class FormCadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroAluno));
            TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            ButtonSalvar = new ReaLTaiizor.Controls.MaterialButton();
            ButtonCancelar = new ReaLTaiizor.Controls.MaterialButton();
            TextSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TextNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            ComboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            TextMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            mlvAlunos = new ReaLTaiizor.Controls.MaterialListView();
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Controls.Add(tabPageCadastro);
            TabControlCadastro.Controls.Add(tabPageConsulta);
            TabControlCadastro.Depth = 0;
            TabControlCadastro.Dock = DockStyle.Fill;
            TabControlCadastro.ImageList = imageList1;
            TabControlCadastro.Location = new Point(3, 64);
            TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastro.Multiline = true;
            TabControlCadastro.Name = "TabControlCadastro";
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Size = new Size(716, 440);
            TabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(ButtonSalvar);
            tabPageCadastro.Controls.Add(ButtonCancelar);
            tabPageCadastro.Controls.Add(TextSenha);
            tabPageCadastro.Controls.Add(TextCidade);
            tabPageCadastro.Controls.Add(TextBairro);
            tabPageCadastro.Controls.Add(TextEndereco);
            tabPageCadastro.Controls.Add(TextNome);
            tabPageCadastro.Controls.Add(TextNascimento);
            tabPageCadastro.Controls.Add(ComboEstado);
            tabPageCadastro.Controls.Add(TextMatricula);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(708, 405);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.AutoSize = false;
            ButtonSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonSalvar.Depth = 0;
            ButtonSalvar.HighEmphasis = true;
            ButtonSalvar.Icon = null;
            ButtonSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonSalvar.Location = new Point(587, 345);
            ButtonSalvar.Margin = new Padding(4, 6, 4, 6);
            ButtonSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.NoAccentTextColor = Color.Empty;
            ButtonSalvar.Size = new Size(106, 48);
            ButtonSalvar.TabIndex = 0;
            ButtonSalvar.Text = "Salvar";
            ButtonSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonSalvar.UseAccentColor = false;
            ButtonSalvar.UseVisualStyleBackColor = true;
            ButtonSalvar.Click += ButtonSalvar_Click;
            // 
            // ButtonCancelar
            // 
            ButtonCancelar.AutoSize = false;
            ButtonCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ButtonCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            ButtonCancelar.Depth = 0;
            ButtonCancelar.HighEmphasis = true;
            ButtonCancelar.Icon = null;
            ButtonCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            ButtonCancelar.Location = new Point(468, 345);
            ButtonCancelar.Margin = new Padding(4, 6, 4, 6);
            ButtonCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ButtonCancelar.Name = "ButtonCancelar";
            ButtonCancelar.NoAccentTextColor = Color.Empty;
            ButtonCancelar.Size = new Size(111, 48);
            ButtonCancelar.TabIndex = 9;
            ButtonCancelar.Text = "Cancelar";
            ButtonCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            ButtonCancelar.UseAccentColor = false;
            ButtonCancelar.UseVisualStyleBackColor = true;
            ButtonCancelar.Click += ButtonCancelar_Click;
            // 
            // TextSenha
            // 
            TextSenha.AnimateReadOnly = false;
            TextSenha.AutoCompleteMode = AutoCompleteMode.None;
            TextSenha.AutoCompleteSource = AutoCompleteSource.None;
            TextSenha.BackgroundImageLayout = ImageLayout.None;
            TextSenha.CharacterCasing = CharacterCasing.Normal;
            TextSenha.Depth = 0;
            TextSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextSenha.HideSelection = true;
            TextSenha.Hint = "Senha";
            TextSenha.LeadingIcon = (Image)resources.GetObject("TextSenha.LeadingIcon");
            TextSenha.Location = new Point(21, 288);
            TextSenha.MaxLength = 32767;
            TextSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextSenha.Name = "TextSenha";
            TextSenha.PasswordChar = '*';
            TextSenha.PrefixSuffixText = null;
            TextSenha.ReadOnly = false;
            TextSenha.RightToLeft = RightToLeft.No;
            TextSenha.SelectedText = "";
            TextSenha.SelectionLength = 0;
            TextSenha.SelectionStart = 0;
            TextSenha.ShortcutsEnabled = true;
            TextSenha.Size = new Size(672, 48);
            TextSenha.TabIndex = 8;
            TextSenha.TabStop = false;
            TextSenha.TextAlign = HorizontalAlignment.Left;
            TextSenha.TrailingIcon = null;
            TextSenha.UseSystemPasswordChar = false;
            // 
            // TextCidade
            // 
            TextCidade.AnimateReadOnly = false;
            TextCidade.AutoCompleteMode = AutoCompleteMode.None;
            TextCidade.AutoCompleteSource = AutoCompleteSource.None;
            TextCidade.BackgroundImageLayout = ImageLayout.None;
            TextCidade.CharacterCasing = CharacterCasing.Normal;
            TextCidade.Depth = 0;
            TextCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextCidade.HideSelection = true;
            TextCidade.Hint = "Cidade";
            TextCidade.LeadingIcon = null;
            TextCidade.Location = new Point(21, 234);
            TextCidade.MaxLength = 32767;
            TextCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextCidade.Name = "TextCidade";
            TextCidade.PasswordChar = '\0';
            TextCidade.PrefixSuffixText = null;
            TextCidade.ReadOnly = false;
            TextCidade.RightToLeft = RightToLeft.No;
            TextCidade.SelectedText = "";
            TextCidade.SelectionLength = 0;
            TextCidade.SelectionStart = 0;
            TextCidade.ShortcutsEnabled = true;
            TextCidade.Size = new Size(488, 48);
            TextCidade.TabIndex = 6;
            TextCidade.TabStop = false;
            TextCidade.TextAlign = HorizontalAlignment.Left;
            TextCidade.TrailingIcon = null;
            TextCidade.UseSystemPasswordChar = false;
            // 
            // TextBairro
            // 
            TextBairro.AnimateReadOnly = false;
            TextBairro.AutoCompleteMode = AutoCompleteMode.None;
            TextBairro.AutoCompleteSource = AutoCompleteSource.None;
            TextBairro.BackgroundImageLayout = ImageLayout.None;
            TextBairro.CharacterCasing = CharacterCasing.Normal;
            TextBairro.Depth = 0;
            TextBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextBairro.HideSelection = true;
            TextBairro.Hint = "Bairro";
            TextBairro.LeadingIcon = null;
            TextBairro.Location = new Point(21, 180);
            TextBairro.MaxLength = 32767;
            TextBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextBairro.Name = "TextBairro";
            TextBairro.PasswordChar = '\0';
            TextBairro.PrefixSuffixText = null;
            TextBairro.ReadOnly = false;
            TextBairro.RightToLeft = RightToLeft.No;
            TextBairro.SelectedText = "";
            TextBairro.SelectionLength = 0;
            TextBairro.SelectionStart = 0;
            TextBairro.ShortcutsEnabled = true;
            TextBairro.Size = new Size(672, 48);
            TextBairro.TabIndex = 5;
            TextBairro.TabStop = false;
            TextBairro.TextAlign = HorizontalAlignment.Left;
            TextBairro.TrailingIcon = null;
            TextBairro.UseSystemPasswordChar = false;
            // 
            // TextEndereco
            // 
            TextEndereco.AnimateReadOnly = false;
            TextEndereco.AutoCompleteMode = AutoCompleteMode.None;
            TextEndereco.AutoCompleteSource = AutoCompleteSource.None;
            TextEndereco.BackgroundImageLayout = ImageLayout.None;
            TextEndereco.CharacterCasing = CharacterCasing.Normal;
            TextEndereco.Depth = 0;
            TextEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextEndereco.HideSelection = true;
            TextEndereco.Hint = "Endereço";
            TextEndereco.LeadingIcon = null;
            TextEndereco.Location = new Point(21, 126);
            TextEndereco.MaxLength = 32767;
            TextEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextEndereco.Name = "TextEndereco";
            TextEndereco.PasswordChar = '\0';
            TextEndereco.PrefixSuffixText = null;
            TextEndereco.ReadOnly = false;
            TextEndereco.RightToLeft = RightToLeft.No;
            TextEndereco.SelectedText = "";
            TextEndereco.SelectionLength = 0;
            TextEndereco.SelectionStart = 0;
            TextEndereco.ShortcutsEnabled = true;
            TextEndereco.Size = new Size(672, 48);
            TextEndereco.TabIndex = 4;
            TextEndereco.TabStop = false;
            TextEndereco.TextAlign = HorizontalAlignment.Left;
            TextEndereco.TrailingIcon = null;
            TextEndereco.UseSystemPasswordChar = false;
            // 
            // TextNome
            // 
            TextNome.AnimateReadOnly = false;
            TextNome.AutoCompleteMode = AutoCompleteMode.None;
            TextNome.AutoCompleteSource = AutoCompleteSource.None;
            TextNome.BackgroundImageLayout = ImageLayout.None;
            TextNome.CharacterCasing = CharacterCasing.Normal;
            TextNome.Depth = 0;
            TextNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextNome.HideSelection = true;
            TextNome.Hint = "Nome";
            TextNome.LeadingIcon = null;
            TextNome.Location = new Point(21, 72);
            TextNome.MaxLength = 32767;
            TextNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextNome.Name = "TextNome";
            TextNome.PasswordChar = '\0';
            TextNome.PrefixSuffixText = null;
            TextNome.ReadOnly = false;
            TextNome.RightToLeft = RightToLeft.No;
            TextNome.SelectedText = "";
            TextNome.SelectionLength = 0;
            TextNome.SelectionStart = 0;
            TextNome.ShortcutsEnabled = true;
            TextNome.Size = new Size(672, 48);
            TextNome.TabIndex = 3;
            TextNome.TabStop = false;
            TextNome.TextAlign = HorizontalAlignment.Left;
            TextNome.TrailingIcon = null;
            TextNome.UseSystemPasswordChar = false;
            // 
            // TextNascimento
            // 
            TextNascimento.AllowPromptAsInput = true;
            TextNascimento.AnimateReadOnly = false;
            TextNascimento.AsciiOnly = false;
            TextNascimento.BackgroundImageLayout = ImageLayout.None;
            TextNascimento.BeepOnError = false;
            TextNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            TextNascimento.Depth = 0;
            TextNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextNascimento.HidePromptOnLeave = false;
            TextNascimento.HideSelection = true;
            TextNascimento.Hint = "Data de Nascimento";
            TextNascimento.InsertKeyMode = InsertKeyMode.Default;
            TextNascimento.LeadingIcon = null;
            TextNascimento.Location = new Point(381, 18);
            TextNascimento.Mask = "99/99/9999";
            TextNascimento.MaxLength = 32767;
            TextNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextNascimento.Name = "TextNascimento";
            TextNascimento.PasswordChar = '\0';
            TextNascimento.PrefixSuffixText = null;
            TextNascimento.PromptChar = '_';
            TextNascimento.ReadOnly = false;
            TextNascimento.RejectInputOnFirstFailure = false;
            TextNascimento.ResetOnPrompt = true;
            TextNascimento.ResetOnSpace = true;
            TextNascimento.RightToLeft = RightToLeft.No;
            TextNascimento.SelectedText = "";
            TextNascimento.SelectionLength = 0;
            TextNascimento.SelectionStart = 0;
            TextNascimento.ShortcutsEnabled = true;
            TextNascimento.Size = new Size(312, 48);
            TextNascimento.SkipLiterals = true;
            TextNascimento.TabIndex = 2;
            TextNascimento.TabStop = false;
            TextNascimento.Text = "  /  /";
            TextNascimento.TextAlign = HorizontalAlignment.Left;
            TextNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            TextNascimento.TrailingIcon = null;
            TextNascimento.UseSystemPasswordChar = false;
            TextNascimento.ValidatingType = null;
            // 
            // ComboEstado
            // 
            ComboEstado.AutoResize = false;
            ComboEstado.BackColor = Color.FromArgb(255, 255, 255);
            ComboEstado.Depth = 0;
            ComboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            ComboEstado.DropDownHeight = 174;
            ComboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboEstado.DropDownWidth = 121;
            ComboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            ComboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ComboEstado.FormattingEnabled = true;
            ComboEstado.Hint = "Estado";
            ComboEstado.IntegralHeight = false;
            ComboEstado.ItemHeight = 43;
            ComboEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "", "BA", "CE", "DF", "", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            ComboEstado.Location = new Point(515, 234);
            ComboEstado.MaxDropDownItems = 4;
            ComboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            ComboEstado.Name = "ComboEstado";
            ComboEstado.Size = new Size(178, 49);
            ComboEstado.StartIndex = 0;
            ComboEstado.TabIndex = 7;
            // 
            // TextMatricula
            // 
            TextMatricula.AnimateReadOnly = false;
            TextMatricula.AutoCompleteMode = AutoCompleteMode.None;
            TextMatricula.AutoCompleteSource = AutoCompleteSource.None;
            TextMatricula.BackgroundImageLayout = ImageLayout.None;
            TextMatricula.CharacterCasing = CharacterCasing.Normal;
            TextMatricula.Depth = 0;
            TextMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            TextMatricula.HideSelection = true;
            TextMatricula.Hint = "Matrícula";
            TextMatricula.LeadingIcon = null;
            TextMatricula.Location = new Point(21, 18);
            TextMatricula.MaxLength = 32767;
            TextMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            TextMatricula.Name = "TextMatricula";
            TextMatricula.PasswordChar = '\0';
            TextMatricula.PrefixSuffixText = null;
            TextMatricula.ReadOnly = false;
            TextMatricula.RightToLeft = RightToLeft.No;
            TextMatricula.SelectedText = "";
            TextMatricula.SelectionLength = 0;
            TextMatricula.SelectionStart = 0;
            TextMatricula.ShortcutsEnabled = true;
            TextMatricula.Size = new Size(354, 48);
            TextMatricula.TabIndex = 1;
            TextMatricula.TabStop = false;
            TextMatricula.TextAlign = HorizontalAlignment.Left;
            TextMatricula.TrailingIcon = null;
            TextMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(mlvAlunos);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(708, 405);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(470, 346);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(542, 346);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(621, 346);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // mlvAlunos
            // 
            mlvAlunos.AutoSizeTable = false;
            mlvAlunos.BackColor = Color.FromArgb(255, 255, 255);
            mlvAlunos.BorderStyle = BorderStyle.None;
            mlvAlunos.Depth = 0;
            mlvAlunos.Dock = DockStyle.Top;
            mlvAlunos.FullRowSelect = true;
            mlvAlunos.Location = new Point(3, 3);
            mlvAlunos.MinimumSize = new Size(200, 100);
            mlvAlunos.MouseLocation = new Point(-1, -1);
            mlvAlunos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mlvAlunos.Name = "mlvAlunos";
            mlvAlunos.OwnerDraw = true;
            mlvAlunos.Size = new Size(702, 334);
            mlvAlunos.TabIndex = 4;
            mlvAlunos.UseCompatibleStateImageBehavior = false;
            mlvAlunos.View = View.Details;
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 507);
            Controls.Add(TabControlCadastro);
            DrawerTabControl = TabControlCadastro;
            Name = "FormCadastroAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alunos";
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextSenha;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextBairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextNome;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox TextNascimento;
        private ReaLTaiizor.Controls.MaterialComboBox ComboEstado;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit TextMatricula;
        private ReaLTaiizor.Controls.MaterialButton ButtonSalvar;
        private ReaLTaiizor.Controls.MaterialButton ButtonCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialListView mlvAlunos;
    }
}