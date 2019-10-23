using AMDManager.Models;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace AMDManager
{
    public partial class VerEncomenda : Form
    {
        Models.PlanoSemanal PlanoSemanal = null;

        public VerEncomenda(int idSemanal )
        {
            InitializeComponent();
            var context = new AMDModels();
            PlanoSemanal = context.PlanoSemanals.FirstOrDefault(x => x.NumeroCarga == idSemanal);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu Check = new Menu();
            Check.Show();
            this.Hide();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        Bitmap bmpPrint;

        private void copyAlltoClipboard()
        {
            grelhaImpressao.RowHeadersVisible = false;
            grelhaImpressao.SelectAll();
            DataObject dataObj = grelhaImpressao.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

            grelhaImpressao.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            grelhaImpressao.MultiSelect = true;
            grelhaImpressao.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // IMPRIMIR PARA IMAGEM
             
            // Set the bitmap object to the size of the screen
            Bitmap bmpScreenshot = new Bitmap(this.Bounds.Width, this.Bounds.Height,
                                       PixelFormat.Format32bppArgb);
            // Create a graphics object from the bitmap
            Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            // Take the screenshot from the upper left corner to the right bottom corner
            gfxScreenshot.CopyFromScreen(this.Bounds.X, this.Bounds.Y, 0, 0,
                                         this.Bounds.Size, CopyPixelOperation.SourceCopy);

            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "Select output file:";
            saveImageDialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            //saveImageDialog.FileName = printFileName;
            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the screenshot to the specified path that the user has chosen
                bmpScreenshot.Save(saveImageDialog.FileName, ImageFormat.Png);
            }

            

            // passar para excel
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;


            bool f1 = false;
            while (f1 == false)
            {
                try
                {
                    //Write Headers
                    for (j = 0; j < grelhaImpressao.Columns.Count; j++)
                    {
                        Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                        myRange.Value2 = grelhaImpressao.Columns[j].HeaderText;
                        f1 = true;
                    }
                }
                catch (Exception exception)
                {
                    f1 = false;
                }
                
            }
                StartRow++;

                //Write datagridview content
                for (i = 0; i < grelhaImpressao.Rows.Count; i++)
                {
                    for (j = 0; j < grelhaImpressao.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = grelhaImpressao[j, i].Value == null ? "" : grelhaImpressao[j, i].Value;
                        }
                        catch
                        {
                            //MessageBox.Show("Erro");
                        }
                    }
                }

                string folderPath = "C:\\PDFs\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                workbook.SaveAs(folderPath + "NumeroCarga" + textBox10.Text.Trim() + " Versao" + textBox11.Text.Trim() + ".xlsx");
                excel.Quit();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VerEncomenda_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'aMDDataSet.EncomendasFritas' table. You can move, or remove it, as needed.
                this.encomendasFritasTableAdapter.Fill(this.aMDDataSet.EncomendasFritas);
            }
            catch (Exception f)
            {
                MessageBox.Show("Não conseguimos carregar a tabela de encomendasFritas. Por favor tente mais tarde.");
            }

            Transportador.Text = PlanoSemanal.Transportador;
            DataBox.Text = PlanoSemanal.DiasDeCarga;
            int? totalPaletes = PlanoSemanal.EncomendasFritas.Sum(x => x.Paletes);
            int? totalRollis = PlanoSemanal.EncomendasFritas.Sum(x => x.Rolli);
            textBox9.Text = totalPaletes.ToString();
            textBox8.Text = totalRollis.ToString();
            textBox12.Text = PlanoSemanal.Zona;
            
            //int totalPeso = PlanoSemanal.EncomendasFritas.Where(x => x.Encomenda.GroupJoin(Encomenda)).Select(x => x.Income).Sum();

            var queryResults = PlanoSemanal.EncomendasFritas.Select(c => c.Peso).Distinct();

            var teamTotalScores =
                from encomenda in PlanoSemanal.EncomendasFritas
                group encomenda by encomendasFritasBindingSource into playerGroup
                select new
                {
                    encomenda = playerGroup.Key,
                    TotalScore = playerGroup.Sum(x => x.Peso),
                    
                };


            int? totalPeso = 0;
            foreach (var item in queryResults)
            {
                
                int vla = Convert.ToInt32(item);
                totalPeso = totalPeso + vla;
            }

            //int? totalPeso = PlanoSemanal.EncomendasFritas.Sum(x => x.Peso);


            textBox10.Text = PlanoSemanal.NumeroCarga.ToString();

            textBox1.Text = totalPeso.ToString();

            double? total = 0;

            if (PlanoSemanal.Transportador == "Girardet")       // caso em que nao interessa o numero de paragens
            {
                if (PlanoSemanal.EncomendasFritas != null)
                {
                    int extra = (PlanoSemanal.EncomendasFritas.GroupBy(x => x.Cliente).Count() - 1) * 0;
                    double? price = PlanoSemanal.Preco / PlanoSemanal.CapacidadePaletes * totalPaletes;

                    total += price + extra;

                    textBox4.Text = total.ToString();
                }
            }

            else        // casos em que interessa o numero de paragens
            {
                if (PlanoSemanal.EncomendasFritas != null)
                {
                    int extra = (PlanoSemanal.EncomendasFritas.GroupBy(x => x.Cliente).Count() - 1) * 50;
                    double? price = PlanoSemanal.Preco / PlanoSemanal.CapacidadePaletes * totalPaletes;

                    total += price + extra;

                    textBox4.Text = total.ToString();
                }

                textBox4.Text = total.ToString();


                var selc = PlanoSemanal.EncomendasFritas.GroupBy(x => x.Encomenda1.CodEncomenda).Select(x => new EncomendaListingItem
                {
                    Cod = x.Key,
                    ClienteMorada = x.Select(o => o.Cliente1.Nome + '\n' + o.Cliente1.Morada).First(),
                    HorarioDescarga = "",
                    Contacto = x.First().Cliente1.Telefone,
                    PalSec = x.Where(enc => enc.Tipo == "Secos").Sum(enc => enc.Paletes),
                    PalFresc = x.Where(enc => enc.Tipo == "Frescos").Sum(enc => enc.Paletes),
                    PalCong = x.Where(enc => enc.Tipo == "Congelados").Sum(enc => enc.Paletes),
                    RolliSec = x.Where(enc => enc.Tipo == "Secos").Sum(enc => enc.Rolli),
                    RolliFresc = x.Where(enc => enc.Tipo == "Frescos").Sum(enc => enc.Rolli),
                    RolliCong = x.Where(enc => enc.Tipo == "Congelados").Sum(enc => enc.Rolli),
                    Peso = x.Select(o => o.Encomenda1.Peso).First(),
                }).ToList();
                var source = new BindingSource
                {
                    DataSource = selc
                };
                this.grelhaImpressao.DataSource = source;
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Transportador_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
               Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();
               Microsoft.Office.Interop.Outlook._MailItem oMailItem = (Microsoft.Office.Interop.Outlook._MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
               oMailItem.To = "meter campo transportadora.email";

                oMailItem.HTMLBody = "Segue em anexo o pdf com os dados da encomenda. <br> Atentamente, AMD";

                //Add an attachment. 
                String sDisplayName = "Encomenda";
                int iPosition = (int)oMailItem.Body.Length + 1;
                int iAttachType = (int)Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue;

                //now attached the file
                Microsoft.Office.Interop.Outlook.Attachment oAttach = oMailItem.Attachments.Add(@"C:\\fileName.jpg", iAttachType, iPosition, sDisplayName);

                //Subject line
                oMailItem.Subject = "Encomenda AMD";

                // Add a recipient.
                Microsoft.Office.Interop.Outlook.Recipients oRecips = (Microsoft.Office.Interop.Outlook.Recipients)oMailItem.Recipients;

                // Change the recipient in the next line if necessary.
                Microsoft.Office.Interop.Outlook.Recipient oRecip = (Microsoft.Office.Interop.Outlook.Recipient)oRecips.Add("meter o campo da transportadora.email");
                oRecip.Resolve();

                oMailItem.Display(true);

                // Send.
                oMailItem.Send();

                // Clean up.
                oRecip = null;
                oRecips = null;
                oMailItem = null;
                oApp = null;
            }


            catch (Exception ex)
            {
                MessageBox.Show("Não conseguimos carregar a aplicação de email. Por favor tente mais tarde.");
            }



        }       // enviar email

        private void email_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();
                Microsoft.Office.Interop.Outlook._MailItem oMailItem = (Microsoft.Office.Interop.Outlook._MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                oMailItem.To = "meter campo transportadora.email";

                oMailItem.HTMLBody = "Segue em anexo o pdf com os dados da encomenda. <br> Atentamente, AMD";

                //Add an attachment. 
                String sDisplayName = "Encomenda";
                int iPosition = (int)oMailItem.Body.Length + 1;
                int iAttachType = (int)Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue;

                //now attached the file
                Microsoft.Office.Interop.Outlook.Attachment oAttach = oMailItem.Attachments.Add(@"C:\\fileName.jpg", iAttachType, iPosition, sDisplayName);

                //Subject line
                oMailItem.Subject = "Encomenda AMD";

                // Add a recipient.
                Microsoft.Office.Interop.Outlook.Recipients oRecips = (Microsoft.Office.Interop.Outlook.Recipients)oMailItem.Recipients;

                // Change the recipient in the next line if necessary.
                Microsoft.Office.Interop.Outlook.Recipient oRecip = (Microsoft.Office.Interop.Outlook.Recipient)oRecips.Add("meter o campo da transportadora.email");
                oRecip.Resolve();

                oMailItem.Display(true);

                // Send.
                oMailItem.Send();

                // Clean up.
                oRecip = null;
                oRecips = null;
                oMailItem = null;
                oApp = null;
            }


            catch (Exception ex)
            {
                MessageBox.Show("Não conseguimos carregar a aplicação de email. Por favor tente mais tarde.");
            }
        }

        private void email_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.email, "Enviar email desta encomenda.");
        }

        private void PrintButton_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.PrintButton, "Imprimir/Exportar para pdf.");
        }

        private void grelhaImpressao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
