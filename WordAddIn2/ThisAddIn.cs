using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Win32;

namespace WordAddIn2
{

    public partial class ThisAddIn 
    {
        private MyPane myUserControl1;
        private Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;

        public String mtl_path;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            myUserControl1 = new MyPane();
            myCustomTaskPane = this.CustomTaskPanes.Add(myUserControl1,  "בדיקת מטלות סטודנטים");
            myCustomTaskPane.Visible = false;

            mtl_path = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\MTL\AppPath", "Installed", null);
            this.Show_Pane();
            
        }


        public void Show_Pane()
        {

            myUserControl1.Startup(Application.ActiveDocument.Name);
            //myUserControl1.Startup(@"2020a-10136-14-316056233-20-1.docx");

            myCustomTaskPane.Visible = true;
        }

        public void Insert_Text(String t)
        {
            String doc_name = this.Application.ActiveDocument.Name;
            Word.Range rng = this.Application.ActiveDocument.Range(0, 0);
            rng.Text = doc_name;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            /*myCustomTaskPane.Visible = false;*/
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
