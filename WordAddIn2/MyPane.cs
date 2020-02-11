using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace WordAddIn2

{
    public partial class MyPane : UserControl
    {
        public String mtl_path;
        public string reg_app_key = @"HKEY_CURRENT_USER\Software\VB and VBA Program Settings\openu-nir";
        public string addin_data_path;
        public string current_task_deffinition;

        public MyPane()
        {
            InitializeComponent();
        }
        
        public void Startup(string doc_name)
        {
            string studentid = "0000000";
            string courseid = "00000";
            string semester = "0000x";
            string taskid = "99";
            string student_name = "שם סטודנט";
            string kvutzat_limud = "קבוצת לימוד";
            string merkaz_limud = "מרכז לימוד";
            string tziun_shelot = "***";
            string tziun_desc = "000";

            mtl_path = (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\MTL", "AppPath", null);
            addin_data_path = (string)Registry.GetValue(reg_app_key + @"\settings", "Path", null);
            current_task_deffinition = (string)Registry.GetValue(reg_app_key + @"\last-state", "Filename", null);

            Regex rx = new Regex(@"(?<SEMESTER>\d{4}\D)-(?<COURSE>\d{5})-(?<TASKID>\d{2})-(?<STUDENT>\d{9})",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

            

            Match doc_match = rx.Match(doc_name);
            if (doc_match.Success)
            {
                // get parameters from filename
                GroupCollection groups = doc_match.Groups;
                studentid = groups["STUDENT"].Value;
                courseid = groups["COURSE"].Value;
                semester = groups["SEMESTER"].Value;
                taskid = groups["TASKID"].Value;

                // get parameters from xml course 
                XDocument xdoc = XDocument.Load(mtl_path + @"\Prod\tnir3\" + semester + "-" + courseid + "\\" + semester + "-" + courseid + ".xml");
                XElement student = xdoc.Root.Elements("student").Where(arg => 
                    ((string)arg.Element("mis_zehut_student") == studentid) & ((string)arg.Element("mis_matala") == taskid)).First();

                student_name = (string)student.Element("fname") + " " + (string)student.Element("lname");
                kvutzat_limud = (string)student.Element("kvutzat_limud");
                merkaz_limud = (string)student.Element("merkaz_limud");
                tziun_shelot = (string)student.Element("tziun_shelot");
                tziun_desc = (string)student.Element("tziun_desc");

            }
            this.lbl_studentname.Text = student_name;
            this.lbl_course.Text = courseid + "-" + semester;
            this.lbl_taskid.Text = taskid;
            this.lbl_merkaz_kvuza.Text = merkaz_limud + @"/" + kvutzat_limud;
            get_grades(tziun_shelot);
            this.lbl_tziun_desc.Text = tziun_desc;
            //get_sssignment_status();




        }

        private void get_sssignment_status()
        {
            string vertical_current = (string)Registry.GetValue(reg_app_key + @"\last_state", "Vertical", null);

            if (vertical_current != null)
            {
                lbl_current_question.Text = vertical_current;
            }
            else lbl_current_question.Text = "none";

        }

        private void get_grades(String gradesline)
        {
            System.Windows.Forms.TextBox txt;
            int right_base = this.lbl_tziunim.Right;
            int top_base = this.lbl_tziunim.Bottom;
            int end_string = gradesline.IndexOf('*');
            string tmp = "";

            if (end_string > 0)
            {
                tmp = gradesline.Substring(0, 3);
                txt = new System.Windows.Forms.TextBox();
                this.panel_tziunim.Controls.Add(txt);
                txt.Top = top_base;
                txt.Width = 25;
                txt.Left = right_base - txt.Width;
                txt.Anchor = AnchorStyles.Right;
                txt.Text = tmp;
                for (int i = 3; i < end_string; i+=2)
                {
                    tmp = gradesline.Substring(i, 2);
                    txt = new System.Windows.Forms.TextBox();
                    this.panel_tziunim.Controls.Add(txt);
                    txt.Top = top_base;
                    txt.Width = 25;
                    txt.Left = right_base - (txt.Width + 5) * (i-1);
                    txt.Anchor = AnchorStyles.Right;
                    txt.Text = tmp;
                }

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
