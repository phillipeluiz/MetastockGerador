using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace GeraçãoMetaStockFiles
{
    class clsExportacao
    {

        private bool MoverArquivoErro(string pathfile, string fullfilename)
        {
            try
            {
                
                FileInfo fi = new FileInfo(fullfilename);
                
                Directory.CreateDirectory(pathfile + "\\erro" );
                                
                fi.MoveTo(pathfile  + "\\erro");

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        /// <summary>
        /// Grava arquivo de texto com a extensão .phi a fim de ser utilizado na importação do Downloader do Metastock
        /// </summary>
        /// <param name="pathfile">parametro com o caminho do arquivo onde ele será armazenado</param>
        /// <param name="lstStock">Lista de objetos com os valores a serem gravados no arquivo</param>
        /// <returns>Retorna True em caso de geração do arquivo bem sucedida</returns>
        public bool ExportarArquivo(string pathfile, string strfixo, List<clsStock> lstStock)
        {
            DateTime  strDataFixo;
            strDataFixo = new DateTime(int.Parse(strfixo.Substring(0, 2)), int.Parse(strfixo.Substring(2, 2)), int.Parse(strfixo.Substring(4, 2)));//.ToString("ddMMyyyy");
            
            string fullfilename = pathfile + "\\" + DateTime.Today.ToString("ddMMyyyy") + "_DTNEG_" + strDataFixo.ToString("ddMM20yy")  + "_BDIN_GMSF.phi";

            try
            {
                //Criar arquivo
                StreamWriter sw = new StreamWriter(fullfilename );
                StringBuilder sb = new StringBuilder();

                //Ler Lista

                foreach (clsStock item in lstStock)
                {
                    //Formatar resultado 
                    sb.Append(item.stock); sb.Append(",");
                    sb.Append(item.date); sb.Append(",");
                    sb.Append(item.open.ToString().Replace(",",".") ); sb.Append(",");
                    sb.Append(item.high.ToString().Replace(",", ".")); sb.Append(",");
                    sb.Append(item.low.ToString().Replace(",", ".")); sb.Append(",");
                    sb.Append(item.close.ToString().Replace(",", ".")); sb.Append(",");
                    sb.Append(item.volume); sb.Append(",");
                    sb.Append(item.open_int.ToString().Replace(",", "."));

                    //Gravar linha no Arquivo
                    sw.WriteLine(sb);

                    sb.Clear();
                }

                //fechar 
                sw.Close();

                return true;
            }
            catch (Exception)
            {
                if (MoverArquivoErro(pathfile, fullfilename) == true)
                {
                    throw new Exception("Arquivo não pode ser movido para a pasta de erro!");
                }

                throw;
            }
            
            
        }

    }
}
