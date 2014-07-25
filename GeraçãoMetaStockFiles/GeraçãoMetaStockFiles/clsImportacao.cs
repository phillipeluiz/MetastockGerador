using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.AccessControl;

namespace GeraçãoMetaStockFiles
{

    class clsImportacao
    {

        
        /// <summary>
        /// Função para retornar lista com os valores da cotação
        /// </summary>
        /// <param name="pathfile">Nome do arquivo que contém a cotação a ser importada</param>
        /// <returns>Retorna LIsta do tipo Stock, com as informações necessárias para importar para o MetaStock</returns>
        public List<clsStock> ImportarArquivo(string pathfile)
        { 
            
            //Declarar LIsta
             List<clsStock> lstStock = new List<clsStock>();
            string strLine;
            string strDtaStock = "";
            try
            {
                //Abrir Arquivo
                StreamReader reader = new StreamReader(pathfile);

                //Ler arquivo
                while ((strLine = reader.ReadLine()) != null)
                {
                    if (strLine.Length > 2)
                    {

                        if (strLine.Substring(0, 17) == "00BDIN9999BOVESPA")
                            strDtaStock = strLine.Substring(30, 8).Trim();

                        //Armazena Indice IBOV
                        if (strLine.Substring(0, 12) == "0101IBOVESPA")
                        {
                            lstStock.Add(new clsStock("IBOV", //simbolo
                                                        strDtaStock, //data
                                                        strLine.Substring(34, 6)+"00" , //Abertura
                                                        strLine.Substring(46, 6)+"00", //Max
                                                        strLine.Substring(40, 6)+"00", //MIn
                                                        strLine.Substring(92, 6)+"00", //Fechamento
                                                        strLine.Substring(179, 15),//+"00",//Volume
                                                        strLine.Substring(52, 6)+"00")); //Open Int (Média)
                        }
                        

                        //TIPREG = 01 [Reistros do arquivo] e Codigo BDI = 02 (LOTE PADRAO) e  TPMERC = 010 (A VISTA)
                        if (strLine.Substring(0, 15) == "0202LOTE PADRAO"  && strLine.Substring(69, 3) == "010")// && strLine.Substring(24, 3) == "010")
                        {
                            //armazenar na lista
                            lstStock.Add(new clsStock(strLine.Substring(57, 11).Trim(), //simbolo
                                                        strDtaStock, //data
                                                        strLine.Substring(90, 11), //Abertura
                                                        strLine.Substring(101, 11), //Max
                                                        strLine.Substring(112, 11), //MIn
                                                        strLine.Substring(134, 11), //Fechamento
                                                        strLine.Substring(178, 15),//Volume
                                                        strLine.Substring(123, 11))); //Open Int (Média) 
                        }
                    }
                }

                reader.Close();

                //retornar a lista
                return lstStock;
            }
            catch (Exception)
            {
                throw ;       
            }
        }



    }
}
