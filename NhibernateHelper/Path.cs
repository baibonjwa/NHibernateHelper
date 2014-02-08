using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NhibernateHelper
{
    public partial class Path : Form
    {
        String type = "";
        DataSet ds = new DataSet();
        String assembly = "";
        public delegate void CreateFileDelegate(String path, int i);
        public Path(String createType, DataSet dsPara, String assemblyPara)
        {
            type = createType;
            ds = dsPara;
            assembly = assemblyPara;
            InitializeComponent();
        }

        private void btn_selectPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            tb_path.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            CreateFile(type, tb_path.Text);
        }
        private void CreateFile(String type, String path)
        {
            switch (type)
            {
                case "All":
                    {
                        CreateDir(path, "Mappings");
                        CreateFiles(path, "Mappings", "实体类名", ".hbm.xml", CreateMappingFile);

                        CreateDir(path, "Entity");
                        CreateFiles(path, "Entity", "实体类名", ".cs", CreateEntityFile);

                        CreateDir(path, "Repository");
                        CreateFiles(path, "Repository", "实体类名", ".cs", CreateRepositoryFile);

                        CreateDir(path, "DBTable");
                        CreateFiles(path, "DBTable", "实体类名", ".sql", CreateRepositoryFile);

                        CreateDir(path, "Operation");
                        CreateFiles(path, "Operation", "实体类名", ".cs", CreateDataOperationFile);

                        MessageBox.Show("全部文件生成成功");
                        break;
                    }
                case "Entity":
                    {
                        CreateDir(path, "Entity");
                        CreateFiles(path, "Entity", "实体类名", ".cs", CreateEntityFile);
                        MessageBox.Show("实体文件生成成功");
                        break;
                    }
                case "Mappings":
                    {
                        CreateDir(path, "Mappings");
                        CreateFiles(path, "Mappings", "实体类名", ".hbm.xml", CreateMappingFile);
                        MessageBox.Show("映射文件生成成功");
                        break;
                    }
                case "Repository":
                    {
                        CreateDir(path, "Repository");
                        CreateFiles(path, "Repository", "实体类名", ".cs", CreateRepositoryFile);
                        MessageBox.Show("数据仓储文件生成成功");
                        break;
                    }
                case "DBTable":
                    {
                        CreateDir(path, "DBTable");
                        CreateFiles(path, "DBTable", "实体类名", ".sql", CreateRepositoryFile);
                        MessageBox.Show("数据表文件生成成功");
                        break;
                    }
                case "Operation":
                    {
                        CreateDir(path, "Operation");
                        CreateFiles(path, "Operation", "实体类名", ".cs", CreateRepositoryFile);
                        MessageBox.Show("业务操作类文件生成成功");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("异常错误");
                        break;
                    }

            }
        }

        private void CreateFiles(String path, String dir, String type, String extension, CreateFileDelegate CreateFile)
        {
            for (int i = 0; i < ds.Tables["Entity"].Rows.Count; i++)
            {
                String pathName = "";
                if (dir == "Repository")
                    pathName = path + "\\" + dir + "\\" + ds.Tables["Entity"].Rows[i][type] + "Repository" + extension;
                else if (dir == "Operation")
                    pathName = path + "\\" + dir + "\\" + ds.Tables["Entity"].Rows[i][type] + "Operation" + extension;
                else
                    pathName = path + "\\" + dir + "\\" + ds.Tables["Entity"].Rows[i][type] + extension;
                FileInfo fi = new FileInfo(pathName);
                if (!fi.Exists)//如果文件不存在
                {
                    CreateFile(pathName, i);
                }
                else
                {
                    File.Delete(pathName);
                    CreateFile(pathName, i);
                }
            }
        }

        private void CreateMappingFile(String pathName, int i)
        {
            FileStream fs = new FileStream(pathName, FileMode.Create);
            StringBuilder str = new StringBuilder();
            str.AppendLine("<?xml version=\"1.0\" ?>");
            str.AppendLine("<hibernate-mapping xmlns=\"urn:nhibernate-mapping-2.2\" assembly=\"" + assembly + ".Entities\" namespace=\"" + assembly + ".Entities\" default-lazy=\"false\">");
            str.AppendLine("  <class name=\"" + assembly + ".Entities." + ds.Tables["Entity"].Rows[i]["实体类名"] + ", " + assembly + ".Entities\" table=\"" + ds.Tables["Entity"].Rows[i]["数据表名"] + "\" lazy=\"" + ds.Tables["Entity"].Rows[i]["Lazy模式"] + "\" discriminator-value=\"0\" >");
            DataRow[] dr_key = ds.Tables["PropertyKey"].Select("实体类名='" + ds.Tables["Entity"].Rows[i]["实体类名"] + "'");
            foreach (DataRow dr in dr_key)
            {
                if (dr["主键类型"].ToString() == "自增型")
                {
                    str.AppendLine("    <id name=\"" + dr["属性名"] + "\" column=\"" + dr["数据字段名"] + "\"	unsaved-value=\"0\" type=\"int\">");
                    str.AppendLine("      <generator class=\"native\" />");
                    str.AppendLine("    </id>");
                }
                else if (dr["主键类型"].ToString() == "字符型")
                {
                    str.AppendLine("    <id name=\"" + dr["属性名"] + "\" column=\"" + dr["数据字段名"] + "\"	unsaved-value=\"0\" type=\"String\">");
                    str.AppendLine("      <generator class=\"assigned\" />");
                    str.AppendLine("    </id>");
                }
            }

            DataRow[] dr_general = ds.Tables["PropertyGeneral"].Select("实体类名='" + ds.Tables["Entity"].Rows[i]["实体类名"] + "'");
            foreach (DataRow dr in dr_general)
            {
                str.AppendLine("    <property name=\"" + dr["属性名"] + "\" column=\"" + dr["数据字段名"] + "\" type=\"" + dr["属性类型"] + "\"/>");
            }

            DataRow[] dr_moretoone = ds.Tables["PropertyMoreToOne"].Select("实体类名='" + ds.Tables["Entity"].Rows[i]["实体类名"] + "'");
            foreach (DataRow dr in dr_moretoone)
            {
                str.AppendLine("    <many-to-one name=\"" + dr["属性名"] + "\" class=\"" + dr["属性类型"] + "\" not-null=\"false\" column=\"" + dr["数据字段名"] + "\"></many-to-one>");

            }

            DataRow[] dr_onetomore = ds.Tables["PropertyOneToMore"].Select("实体类名='" + ds.Tables["Entity"].Rows[i]["实体类名"] + "'");
            foreach (DataRow dr in dr_onetomore)
            {
                str.AppendLine("    <bag name=\"" + dr["属性名"] + "\" table=\"" + dr["对应表名"] + "\" cascade=\"" + dr["级联更新保存"] + "\" inverse=\"" + dr["控制反转"] + "\">");
                str.AppendLine("      <key column=\"" + dr["主键列名"] + "\" />");
                str.AppendLine("      <one-to-many class=\"" + dr["对应实体"] + "\"/>");
                str.AppendLine("    </bag>");
            }
            str.AppendLine("  </class>");
            str.AppendLine("</hibernate-mapping>");
            byte[] data = new UTF8Encoding().GetBytes(str.ToString());
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
        }
        private void CreateEntityFile(String pathName, int i)
        {
            FileStream fs = new FileStream(pathName, FileMode.Create);
            StringBuilder str = new StringBuilder();
            str.AppendLine("using System;");
            str.AppendLine("using System.Collections.Generic;");
            str.AppendLine();
            str.AppendLine("namespace " + assembly + ".Entities");
            str.AppendLine("{");
            str.AppendLine("    public class " + ds.Tables["Entity"].Rows[i]["实体类名"]);
            str.AppendLine("    {");
            DataRow[] dr_key = ds.Tables["PropertyKey"].Select("实体类名='" + ds.Tables["Entity"].Rows[i]["实体类名"] + "'");
            foreach (DataRow dr in dr_key)
            {
                String type = "";
                if (dr["主键类型"].ToString() == "自增型")
                {
                    type = "int";
                }
                else if (dr["主键类型"].ToString() == "字符型")
                {
                    type = "String";
                }
                String lower = Tools.ToFirstLetterLower(dr["属性名"].ToString());
                str.AppendLine("        private " + type + " " + lower + ";");
                str.AppendLine();
                str.AppendLine("        public virtual " + type + " " + dr["属性名"].ToString());
                str.AppendLine("        {");
                str.AppendLine("            get { return " + lower + "; }");
                str.AppendLine("            set { " + lower + " = value; }");
                str.AppendLine("        }");
                str.AppendLine();
            }

            DataRow[] dr_general = ds.Tables["PropertyGeneral"].Select("实体类名='" + ds.Tables["Entity"].Rows[i]["实体类名"] + "'");
            foreach (DataRow dr in dr_general)
            {
                String lower = Tools.ToFirstLetterLower(dr["属性名"].ToString());
                str.AppendLine("        private " + dr["属性类型"] + " " + lower + ";");
                str.AppendLine();
                str.AppendLine("        public virtual " + dr["属性类型"] + " " + dr["属性名"].ToString());
                str.AppendLine("        {");
                str.AppendLine("            get { return " + lower + "; }");
                str.AppendLine("            set { " + lower + " = value; }");
                str.AppendLine("        }");
                str.AppendLine();
            }

            DataRow[] dr_moretoone = ds.Tables["PropertyMoreToOne"].Select("实体类名='" + ds.Tables["Entity"].Rows[i]["实体类名"] + "'");
            foreach (DataRow dr in dr_moretoone)
            {
                String lower = Tools.ToFirstLetterLower(dr["属性名"].ToString());
                str.AppendLine("        private " + dr["属性类型"] + " " + lower + ";");
                str.AppendLine();
                str.AppendLine("        public virtual " + dr["属性类型"] + " " + dr["属性名"].ToString());
                str.AppendLine("        {");
                str.AppendLine("            get { return " + lower + "; }");
                str.AppendLine("            set { " + lower + " = value; }");
                str.AppendLine("        }");
                str.AppendLine();
            }

            DataRow[] dr_onetomore = ds.Tables["PropertyOneToMore"].Select("实体类名='" + ds.Tables["Entity"].Rows[i]["实体类名"] + "'");
            foreach (DataRow dr in dr_onetomore)
            {
                String lower = Tools.ToFirstLetterLower(dr["属性名"].ToString());
                str.AppendLine("        private List<" + dr["对应实体"] + "> " + lower + ";");
                str.AppendLine();
                str.AppendLine("        public virtual List<" + dr["对应实体"] + "> " + dr["属性名"].ToString());
                str.AppendLine("        {");
                str.AppendLine("            get { return " + lower + "; }");
                str.AppendLine("            set { " + lower + " = value; }");
                str.AppendLine("        }");
                str.AppendLine();
            }

            str.AppendLine("    }");
            str.AppendLine("}");
            byte[] data = new UTF8Encoding().GetBytes(str.ToString());
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();
        }
        private void CreateRepositoryFile(String pathName, int i)
        {
            String type = "";
            DataRow[] dr_key = ds.Tables["PropertyKey"].Select("实体类名='" + ds.Tables["Entity"].Rows[i]["实体类名"] + "'");
            foreach (DataRow dr in dr_key)
            {

                if (dr["主键类型"].ToString() == "自增型")
                {
                    type = "int";
                }
                else if (dr["主键类型"].ToString() == "字符型")
                {
                    type = "String";
                }
            }

            FileStream fs = new FileStream(pathName, FileMode.Create);
            StringBuilder str = new StringBuilder();
            str.AppendLine("using System;");
            str.AppendLine("using System.Collections.Generic;");
            str.AppendLine("using ChinaWit.GenericNhibernateDao;");
            str.AppendLine("using " + assembly + ".Entities;");
            str.AppendLine();
            str.AppendLine("namespace " + assembly + ".Repository");
            str.AppendLine("{");
            str.AppendLine("    public class " + ds.Tables["Entity"].Rows[i]["实体类名"] + "Repository" + " : GenericNHibernateDao<" + ds.Tables["Entity"].Rows[i]["实体类名"] + ", " + type + ">");
            str.AppendLine("    {");
            str.AppendLine("    }");
            str.AppendLine("}");

            byte[] data = new UTF8Encoding().GetBytes(str.ToString());
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();

        }
        private void CreateDataOperationFile(String pathName, int i)
        {
            String type = "";
            DataRow[] dr_key = ds.Tables["PropertyKey"].Select("实体类名='" + ds.Tables["Entity"].Rows[i]["实体类名"] + "'");
            foreach (DataRow dr in dr_key)
            {

                if (dr["主键类型"].ToString() == "自增型")
                {
                    type = "int";
                }
                else if (dr["主键类型"].ToString() == "字符型")
                {
                    type = "String";
                }
            }

            FileStream fs = new FileStream(pathName, FileMode.Create);
            StringBuilder str = new StringBuilder();
            str.AppendLine("using System;");
            str.AppendLine("using System.Collections.Generic;");
            str.AppendLine("using ChinaWit.GenericNhibernateDao;");
            str.AppendLine("using " + assembly + ".Entities;");
            str.AppendLine("using " + assembly + ".Repository;");
            str.AppendLine();
            str.AppendLine("namespace " + assembly + ".Bussiness.DataOperation");
            str.AppendLine("{");
            str.AppendLine("    public class " + ds.Tables["Entity"].Rows[i]["实体类名"] + "Operation" + " : " + ds.Tables["Entity"].Rows[i]["实体类名"] + "Repository");
            str.AppendLine("    {");
            str.AppendLine("    }");
            str.AppendLine("}");

            byte[] data = new UTF8Encoding().GetBytes(str.ToString());
            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();

        }
        private void CreateDBTableFile(String pathName, int i)
        {

        }
        private void CreateDir(String path, String dir)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path + "\\" + dir);
            try
            {
                if (di.Exists)
                {
                    di.Delete(true);
                    Directory.CreateDirectory(path + "\\" + dir);
                }
                else
                {
                    Directory.CreateDirectory(path + "\\" + dir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
