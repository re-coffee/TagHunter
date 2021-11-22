
namespace TagHunter
{
    partial class frmTagHunter
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
            this.btAtualizar = new System.Windows.Forms.Button();
            this.dgInformacoes = new System.Windows.Forms.DataGridView();
            this.gpWebConfig = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSalvar = new System.Windows.Forms.Button();
            this.Aviso = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgInformacoes)).BeginInit();
            this.gpWebConfig.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAtualizar
            // 
            this.btAtualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAtualizar.Location = new System.Drawing.Point(0, 0);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(189, 51);
            this.btAtualizar.TabIndex = 0;
            this.btAtualizar.Text = "Atualizar lista";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // dgInformacoes
            // 
            this.dgInformacoes.AllowUserToResizeRows = false;
            this.dgInformacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInformacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgInformacoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInformacoes.Location = new System.Drawing.Point(6, 22);
            this.dgInformacoes.MultiSelect = false;
            this.dgInformacoes.Name = "dgInformacoes";
            this.dgInformacoes.RowTemplate.Height = 25;
            this.dgInformacoes.Size = new System.Drawing.Size(748, 402);
            this.dgInformacoes.TabIndex = 1;
            // 
            // gpWebConfig
            // 
            this.gpWebConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpWebConfig.Controls.Add(this.dgInformacoes);
            this.gpWebConfig.Location = new System.Drawing.Point(12, 12);
            this.gpWebConfig.Name = "gpWebConfig";
            this.gpWebConfig.Size = new System.Drawing.Size(760, 430);
            this.gpWebConfig.TabIndex = 2;
            this.gpWebConfig.TabStop = false;
            this.gpWebConfig.Text = "Web.config";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btAtualizar);
            this.panel1.Location = new System.Drawing.Point(12, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 51);
            this.panel1.TabIndex = 3;
            // 
            // btSalvar
            // 
            this.btSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSalvar.Location = new System.Drawing.Point(189, 0);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(189, 51);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar selecionado";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // Aviso
            // 
            this.Aviso.FileName = "fdAviso";
            // 
            // frmTagHunter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gpWebConfig);
            this.Name = "frmTagHunter";
            this.Text = "TagHunter";
            this.Load += new System.EventHandler(this.frmTagHunter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInformacoes)).EndInit();
            this.gpWebConfig.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.DataGridView dgInformacoes;
        private System.Windows.Forms.GroupBox gpWebConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.OpenFileDialog Aviso;
    }
}

