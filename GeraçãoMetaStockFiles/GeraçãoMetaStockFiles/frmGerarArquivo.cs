using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Security.AccessControl;
using System.Management;
using System.Management.Instrumentation;
using System.Security.Principal;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;

namespace GeraçãoMetaStockFiles
{
    public partial class frmGerarArquivo : Form
    {
        public frmGerarArquivo()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            DialogResult objDialogResult;

            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Arquivos BDIN|*BDIN*.*|Arquivo de Texto|*.txt";//"Text Files (.txt)|*.txt|All Files (*.*)|*.*"
            if (txtImportar.Text != null)
            {
                ofile.InitialDirectory = txtImportar.Text;
            }

            objDialogResult = ofile.ShowDialog();

            if (objDialogResult == DialogResult.OK)
            {
                txtImportar.Text = ofile.FileName;
            }
            ofile.Dispose();

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            List<clsStock> lstStock = new List<clsStock>();
            clsImportacao objImpotacao = new clsImportacao();
            clsExportacao objExportacao = new clsExportacao();
            try
            {
                //Seta permissão para as pastas
                //Permission(WindowsIdentity.GetCurrent().Name, txtImportar.Text);
                //Permission(WindowsIdentity.GetCurrent().Name, txtExportar.Text);

                //Importa arquivo
                lstStock = objImpotacao.ImportarArquivo(txtImportar.Text);

                //Grava arquivo no diretório especificado
                if (objExportacao.ExportarArquivo(txtExportar.Text, (lstStock[0].date).ToString(), lstStock) == true)
                {
                    MessageBox.Show("Conversão concluída com sucesso!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            

            
        }
        /// <summary>
        /// Habilita o Botão de conversão apenas se os caminhos de importação do arquivo e de exportação estiverem definidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtImportar_TextChanged(object sender, EventArgs e)
        {
            if (txtImportar.Text != "" && txtExportar.Text!= "") btnConverter.Enabled = true; else btnConverter.Enabled = false;
        }
        /// <summary>
        /// Habilita o Botão de conversão apenas se os caminhos de importação do arquivo e de exportação estiverem definidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtExportar_TextChanged(object sender, EventArgs e)
        {
            if (txtImportar.Text != "" && txtExportar.Text != "") btnConverter.Enabled = true; else btnConverter.Enabled = false;
        }

        private void frmGerarArquivo_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["FlagDefaultPath"].ToUpper() == "Y" 
                && ConfigurationManager.AppSettings["DefaultPathImport"] != null
                | ConfigurationManager.AppSettings["DefaultPathExport"] != null)
            {
            txtImportar.Text = ConfigurationManager.AppSettings["DefaultPathImport"];
            txtExportar.Text = ConfigurationManager.AppSettings["DefaultPathExport"];

            // Busca automaticamente todos os arquivos em todos os subdiretórios
            DirectoryInfo Dir = new DirectoryInfo(ConfigurationManager.AppSettings["DefaultPathImport"]);
            FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories );
            foreach (FileInfo File in Files)
            {
                lstFile.Items.Add(File.Name);
            }
            
            }



        }

        private void Permission(string user,string pathfile)
        {
            //string directory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string filePath = Path.Combine(pathfile,"\\" );
            FileSecurity fSecurity = File.GetAccessControl(filePath);
            FileSystemAccessRule rule = new FileSystemAccessRule(user, FileSystemRights.FullControl, AccessControlType.Allow);
            fSecurity.SetAccessRule(rule);
            File.SetAccessControl(filePath, fSecurity);
        }


        // exemplo: -http://www.bmfbovespa.com.br/fechamento-pregao/bdi/bdi0722.zip

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string strMesDiaBdi ;
            string strAnoBdi;
            string strCaminhoArquivoBdi, strCaminhoArquivoBdiDestino;
            //clsUtilidades objUtil = new clsUtilidades();
            try
            {
                strMesDiaBdi = dtBdi.Value.Month.ToString("00") + dtBdi.Value.Day.ToString("00");
                strAnoBdi = dtBdi.Value.Year.ToString();
                strCaminhoArquivoBdi = ConfigurationManager.AppSettings["DefaultPathExport"] + "\\" + strAnoBdi + strMesDiaBdi + "_BDIN.zip";
                strCaminhoArquivoBdiDestino = ConfigurationManager.AppSettings["DefaultPathImport"];

                //Realiza o Download do Arquivo Bdi da Bovespa
                using (var client = new System.Net.WebClient())
                {
                    client.DownloadFile("http://www.bmfbovespa.com.br/fechamento-pregao/bdi/bdi" + strMesDiaBdi + ".zip", strCaminhoArquivoBdi);
                }

                //Descomprime o arquivo para a pasta de Importação do MetaStock
                FileInfo fi = new FileInfo(strCaminhoArquivoBdi);

                // clsUtilidades.Decompress(fi); gzip

                FastZip unzipFile = new ICSharpCode.SharpZipLib.Zip.FastZip();

                unzipFile.ExtractZip(fi.FullName.ToString(), fi.Directory.ToString(), null);

                System.IO.File.Move(fi.Directory.ToString() + "\\BDIN", strCaminhoArquivoBdiDestino   + "\\" + strAnoBdi + strMesDiaBdi + "_BDIN");

                MessageBox.Show("Arquivo do dia " + dtBdi.Value.ToString() + " baixado com sucesso!");

            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }

        }

 

        //private void lstFile_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DirectoryInfo Dir = new DirectoryInfo(@"D:\GoogleDrive\Financeiro\Investimento\Bovespa\ArquivosBDI");
        //    // Busca automaticamente todos os arquivos em todos os subdiretórios
        //    FileInfo[] Files = Dir.GetFiles("*", SearchOption.AllDirectories);
        //    foreach (FileInfo File in Files)
        //    {
        //        lstFile.Items.Add(File.FullName);
        //    }
        //}



    }
}
