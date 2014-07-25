namespace GeraçãoMetaStockFiles
{
    partial class frmGerarArquivo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarArquivo));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpExportar = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtExportar = new System.Windows.Forms.TextBox();
            this.grpImportar = new System.Windows.Forms.GroupBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtImportar = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGerarArquivo = new System.Windows.Forms.TabPage();
            this.btnConverter = new System.Windows.Forms.Button();
            this.tabDownload = new System.Windows.Forms.TabPage();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lstFile = new System.Windows.Forms.ListView();
            this.dtBdi = new System.Windows.Forms.DateTimePicker();
            this.grpExportar.SuspendLayout();
            this.grpImportar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabGerarArquivo.SuspendLayout();
            this.tabDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpExportar
            // 
            this.grpExportar.Controls.Add(this.btnExportar);
            this.grpExportar.Controls.Add(this.txtExportar);
            this.grpExportar.ForeColor = System.Drawing.Color.Red;
            this.grpExportar.Location = new System.Drawing.Point(6, 62);
            this.grpExportar.Name = "grpExportar";
            this.grpExportar.Size = new System.Drawing.Size(352, 51);
            this.grpExportar.TabIndex = 8;
            this.grpExportar.TabStop = false;
            this.grpExportar.Text = "Exportar";
            this.toolTip.SetToolTip(this.grpExportar, "Selecione caminho para salvar arquivo .ran gerado para Metastock");
            // 
            // btnExportar
            // 
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(323, 19);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(0);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(25, 20);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtExportar
            // 
            this.txtExportar.BackColor = System.Drawing.SystemColors.Window;
            this.txtExportar.Location = new System.Drawing.Point(12, 20);
            this.txtExportar.Name = "txtExportar";
            this.txtExportar.ReadOnly = true;
            this.txtExportar.Size = new System.Drawing.Size(308, 20);
            this.txtExportar.TabIndex = 4;
            this.txtExportar.TextChanged += new System.EventHandler(this.txtExportar_TextChanged);
            // 
            // grpImportar
            // 
            this.grpImportar.Controls.Add(this.btnImportar);
            this.grpImportar.Controls.Add(this.txtImportar);
            this.grpImportar.Location = new System.Drawing.Point(6, 6);
            this.grpImportar.Name = "grpImportar";
            this.grpImportar.Size = new System.Drawing.Size(352, 50);
            this.grpImportar.TabIndex = 7;
            this.grpImportar.TabStop = false;
            this.grpImportar.Text = "Importar";
            this.toolTip.SetToolTip(this.grpImportar, "Selecione arquivo da Bovespa para importar registros");
            // 
            // btnImportar
            // 
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
            this.btnImportar.Location = new System.Drawing.Point(323, 19);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(0);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(25, 20);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtImportar
            // 
            this.txtImportar.BackColor = System.Drawing.SystemColors.Window;
            this.txtImportar.Location = new System.Drawing.Point(12, 19);
            this.txtImportar.Name = "txtImportar";
            this.txtImportar.ReadOnly = true;
            this.txtImportar.Size = new System.Drawing.Size(308, 20);
            this.txtImportar.TabIndex = 0;
            this.txtImportar.TextChanged += new System.EventHandler(this.txtImportar_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGerarArquivo);
            this.tabControl1.Controls.Add(this.tabDownload);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 281);
            this.tabControl1.TabIndex = 7;
            // 
            // tabGerarArquivo
            // 
            this.tabGerarArquivo.Controls.Add(this.btnConverter);
            this.tabGerarArquivo.Controls.Add(this.grpExportar);
            this.tabGerarArquivo.Controls.Add(this.grpImportar);
            this.tabGerarArquivo.Location = new System.Drawing.Point(4, 22);
            this.tabGerarArquivo.Name = "tabGerarArquivo";
            this.tabGerarArquivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerarArquivo.Size = new System.Drawing.Size(477, 255);
            this.tabGerarArquivo.TabIndex = 0;
            this.tabGerarArquivo.Text = "Gerar Arquivo";
            this.tabGerarArquivo.UseVisualStyleBackColor = true;
            // 
            // btnConverter
            // 
            this.btnConverter.Enabled = false;
            this.btnConverter.Image = ((System.Drawing.Image)(resources.GetObject("btnConverter.Image")));
            this.btnConverter.Location = new System.Drawing.Point(364, 13);
            this.btnConverter.Margin = new System.Windows.Forms.Padding(1);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(100, 100);
            this.btnConverter.TabIndex = 9;
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // tabDownload
            // 
            this.tabDownload.Controls.Add(this.btnDownload);
            this.tabDownload.Controls.Add(this.lstFile);
            this.tabDownload.Controls.Add(this.dtBdi);
            this.tabDownload.Location = new System.Drawing.Point(4, 22);
            this.tabDownload.Name = "tabDownload";
            this.tabDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabDownload.Size = new System.Drawing.Size(477, 255);
            this.tabDownload.TabIndex = 1;
            this.tabDownload.Text = "Download BVSP";
            this.tabDownload.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(263, 52);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(199, 36);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lstFile
            // 
            this.lstFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFile.FullRowSelect = true;
            this.lstFile.Location = new System.Drawing.Point(6, 15);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(250, 234);
            this.lstFile.TabIndex = 1;
            this.lstFile.UseCompatibleStateImageBehavior = false;
            this.lstFile.View = System.Windows.Forms.View.Tile;
            // 
            // dtBdi
            // 
            this.dtBdi.Location = new System.Drawing.Point(262, 15);
            this.dtBdi.Name = "dtBdi";
            this.dtBdi.Size = new System.Drawing.Size(200, 20);
            this.dtBdi.TabIndex = 0;
            // 
            // frmGerarArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 315);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerarArquivo";
            this.Text = "Gerador de Arquivos para o MetaStock";
            this.Load += new System.EventHandler(this.frmGerarArquivo_Load);
            this.grpExportar.ResumeLayout(false);
            this.grpExportar.PerformLayout();
            this.grpImportar.ResumeLayout(false);
            this.grpImportar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabGerarArquivo.ResumeLayout(false);
            this.tabDownload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGerarArquivo;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.GroupBox grpExportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox txtExportar;
        private System.Windows.Forms.GroupBox grpImportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtImportar;
        private System.Windows.Forms.TabPage tabDownload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ListView lstFile;
        private System.Windows.Forms.DateTimePicker dtBdi;
    }
}

