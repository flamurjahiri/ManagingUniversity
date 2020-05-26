namespace ProjektiOrari.Views
{
    partial class ShikoNderrimet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShikoNderrimet));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tabela = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.EmriLendes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ditaere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oraere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approve = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ok = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabela.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabela.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabela.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabela.ColumnHeadersHeight = 40;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmriLendes,
            this.dita,
            this.ora,
            this.ditaere,
            this.oraere,
            this.approve});
            this.tabela.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            this.tabela.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabela.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabela.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.tabela.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tabela.CurrentTheme.BackColor = System.Drawing.Color.DarkViolet;
            this.tabela.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.tabela.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.tabela.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.tabela.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabela.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(0)))), ((int)(((byte)(168)))));
            this.tabela.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.tabela.CurrentTheme.Name = null;
            this.tabela.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            this.tabela.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabela.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.tabela.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            this.tabela.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(102)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabela.EnableHeadersVisualStyles = false;
            this.tabela.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(178)))), ((int)(((byte)(241)))));
            this.tabela.HeaderBackColor = System.Drawing.Color.DarkViolet;
            this.tabela.HeaderBgColor = System.Drawing.Color.Empty;
            this.tabela.HeaderForeColor = System.Drawing.Color.White;
            this.tabela.Location = new System.Drawing.Point(67, 58);
            this.tabela.Name = "tabela";
            this.tabela.RowHeadersVisible = false;
            this.tabela.RowTemplate.Height = 40;
            this.tabela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabela.Size = new System.Drawing.Size(726, 445);
            this.tabela.TabIndex = 0;
            this.tabela.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkViolet;
            // 
            // EmriLendes
            // 
            this.EmriLendes.HeaderText = "Lenda";
            this.EmriLendes.Name = "EmriLendes";
            // 
            // dita
            // 
            this.dita.HeaderText = "Dita ";
            this.dita.Name = "dita";
            // 
            // ora
            // 
            this.ora.HeaderText = "Ora";
            this.ora.Name = "ora";
            // 
            // ditaere
            // 
            this.ditaere.HeaderText = "Dita e Re";
            this.ditaere.Name = "ditaere";
            // 
            // oraere
            // 
            this.oraere.HeaderText = "Ora e Re";
            this.oraere.Name = "oraere";
            // 
            // approve
            // 
            this.approve.HeaderText = "Aprovo";
            this.approve.Name = "approve";
            // 
            // ok
            // 
            this.ok.AllowToggling = false;
            this.ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok.AnimationSpeed = 200;
            this.ok.AutoGenerateColors = false;
            this.ok.BackColor = System.Drawing.Color.Transparent;
            this.ok.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ok.BackgroundImage")));
            this.ok.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ok.ButtonText = "Konfirmo Ndryshimet";
            this.ok.ButtonTextMarginLeft = 0;
            this.ok.ColorContrastOnClick = 45;
            this.ok.ColorContrastOnHover = 45;
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ok.CustomizableEdges = borderEdges1;
            this.ok.DialogResult = System.Windows.Forms.DialogResult.No;
            this.ok.DisabledBorderColor = System.Drawing.Color.Empty;
            this.ok.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ok.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ok.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ok.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.ok.ForeColor = System.Drawing.Color.White;
            this.ok.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.ok.IconMarginLeft = 11;
            this.ok.IconPadding = 10;
            this.ok.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.ok.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.ok.IdleBorderRadius = 3;
            this.ok.IdleBorderThickness = 1;
            this.ok.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.ok.IdleIconLeftImage = null;
            this.ok.IdleIconRightImage = null;
            this.ok.IndicateFocus = false;
            this.ok.Location = new System.Drawing.Point(583, 526);
            this.ok.Name = "ok";
            this.ok.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ok.onHoverState.BorderRadius = 3;
            this.ok.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ok.onHoverState.BorderThickness = 1;
            this.ok.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ok.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ok.onHoverState.IconLeftImage = null;
            this.ok.onHoverState.IconRightImage = null;
            this.ok.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.ok.OnIdleState.BorderRadius = 3;
            this.ok.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ok.OnIdleState.BorderThickness = 1;
            this.ok.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(39)))), ((int)(((byte)(172)))));
            this.ok.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ok.OnIdleState.IconLeftImage = null;
            this.ok.OnIdleState.IconRightImage = null;
            this.ok.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ok.OnPressedState.BorderRadius = 3;
            this.ok.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ok.OnPressedState.BorderThickness = 1;
            this.ok.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ok.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ok.OnPressedState.IconLeftImage = null;
            this.ok.OnPressedState.IconRightImage = null;
            this.ok.Size = new System.Drawing.Size(210, 45);
            this.ok.TabIndex = 46;
            this.ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ok.TextMarginLeft = 0;
            this.ok.UseDefaultRadiusAndThickness = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // ShikoNderrimet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 646);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.tabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShikoNderrimet";
            this.Text = "ShikoNderrimet";
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView tabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmriLendes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dita;
        private System.Windows.Forms.DataGridViewTextBoxColumn ora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ditaere;
        private System.Windows.Forms.DataGridViewTextBoxColumn oraere;
        private System.Windows.Forms.DataGridViewCheckBoxColumn approve;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ok;
    }
}