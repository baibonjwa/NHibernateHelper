using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NhibernateHelper
{
    public partial class Form1 : Form
    {
        static String createType = "";
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
            dd_proType.SelectedIndex = 4;

            DataTable dtEntity = new DataTable("Entity");
            ds.Tables.Add(dtEntity);
            dtEntity.Columns.Add("实体类名");
            dtEntity.Columns.Add("数据表名");
            dtEntity.Columns.Add("Lazy模式");

            DataTable dtProperty = new DataTable("Property");
            DataTable dtPropertyGeneral = new DataTable("PropertyGeneral");
            DataTable dtPropertyKey = new DataTable("PropertyKey");
            DataTable dtPropertyMoreToOne = new DataTable("PropertyMoreToOne");
            DataTable dtPropertyOneToMore = new DataTable("PropertyOneToMore");

            ds.Tables.Add(dtProperty);
            dtProperty.Columns.Add("实体类名");
            dtProperty.Columns.Add("属性名");
            dtProperty.Columns.Add("数据字段名");
            dtProperty.Columns.Add("属性类型");

            ds.Tables.Add(dtPropertyGeneral);
            dtPropertyGeneral.Columns.Add("实体类名");
            dtPropertyGeneral.Columns.Add("属性名");
            dtPropertyGeneral.Columns.Add("数据字段名");
            dtPropertyGeneral.Columns.Add("属性类型");

            ds.Tables.Add(dtPropertyKey);
            dtPropertyKey.Columns.Add("实体类名");
            dtPropertyKey.Columns.Add("属性名");
            dtPropertyKey.Columns.Add("数据字段名");
            dtPropertyKey.Columns.Add("主键类型");

            ds.Tables.Add(dtPropertyMoreToOne);
            dtPropertyMoreToOne.Columns.Add("实体类名");
            dtPropertyMoreToOne.Columns.Add("属性名");
            dtPropertyMoreToOne.Columns.Add("数据字段名");
            dtPropertyMoreToOne.Columns.Add("属性类型");

            ds.Tables.Add(dtPropertyOneToMore);
            dtPropertyOneToMore.Columns.Add("实体类名");
            dtPropertyOneToMore.Columns.Add("属性名");
            dtPropertyOneToMore.Columns.Add("数据字段名");
            dtPropertyOneToMore.Columns.Add("对应表名");
            dtPropertyOneToMore.Columns.Add("主键列名");
            dtPropertyOneToMore.Columns.Add("对应实体");
            dtPropertyOneToMore.Columns.Add("级联更新保存");
            dtPropertyOneToMore.Columns.Add("控制反转");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lb_assembly.Text = "";
            tb_assembly.Text = "";
        }

        private void btn_addEntity_Click(object sender, EventArgs e)
        {
            ds.Tables["Entity"].Rows.Add(tb_entityName.Text, tb_entityTableName.Text, chb_lazy.Checked.ToString().ToLower());
            dgv_entity.DataSource = ds.Tables["Entity"];
            BindCbEntity();
            tb_entityName.SelectAll();
        }
        private void BindCbEntity()
        {
            dd_entity.Items.Clear();
            dd_3.Items.Clear();
            foreach (DataRow dr in ds.Tables["Entity"].Rows)
            {
                dd_entity.Items.Add(dr["实体类名"]);
                dd_3.Items.Add(dr["实体类名"]);
                //cb_entity.Items = ds.Tables["Entity"].Columns["实体类名"];
            }
        }
        private void rbtn_1_CheckedChanged(object sender, EventArgs e)
        {
            dd_1.Enabled = true;
            dd_2.Enabled = false;
            dd_3.Enabled = false;
            tb_4.Enabled = false;
            tb_41.Enabled = false;
            tb_42.Enabled = false;
            chb_cascade.Enabled = false;
            chb_inverse.Enabled = false;
        }

        private void rbtn_2_CheckedChanged(object sender, EventArgs e)
        {
            dd_1.Enabled = false;
            dd_2.Enabled = true;
            dd_3.Enabled = false;
            tb_4.Enabled = false;
            tb_41.Enabled = false;
            tb_42.Enabled = false;
            chb_cascade.Enabled = false;
            chb_inverse.Enabled = false;
        }

        private void rbtn_3_CheckedChanged(object sender, EventArgs e)
        {
            dd_1.Enabled = false;
            dd_2.Enabled = false;
            dd_3.Enabled = true;
            tb_4.Enabled = false;
            tb_41.Enabled = false;
            tb_42.Enabled = false;
            chb_cascade.Enabled = false;
            chb_inverse.Enabled = false;
        }

        private void rbtn_4_CheckedChanged(object sender, EventArgs e)
        {
            dd_1.Enabled = false;
            dd_2.Enabled = false;
            dd_3.Enabled = false;
            tb_4.Enabled = true;
            tb_41.Enabled = true;
            tb_42.Enabled = true;
            chb_cascade.Enabled = true;
            chb_inverse.Enabled = true;
        }

        private void btn_addAttr_Click(object sender, EventArgs e)
        {
            if (rbtn_1.Checked == true)
            {
                PropertyGeneral pro = new PropertyGeneral();
                pro.Entity = dd_entity.SelectedItem.ToString();
                pro.Name = tb_proName.Text;
                pro.Field = tb_proField.Text;
                pro.ProType = dd_1.SelectedItem.ToString();
                AddProperty(pro, "普通属性");

                ds.Tables["PropertyGeneral"].Rows.Add(pro.Entity, pro.Name, pro.Field, pro.ProType);

            }
            else if (rbtn_2.Checked == true)
            {
                PropertyKey pro = new PropertyKey();
                pro.Entity = dd_entity.SelectedItem.ToString();
                pro.Name = tb_proName.Text;
                pro.Field = tb_proField.Text;
                pro.KeyType = dd_2.SelectedItem.ToString();
                AddProperty(pro, "主键");

                ds.Tables["PropertyKey"].Rows.Add(pro.Entity, pro.Name, pro.Field, pro.KeyType);
            }
            else if (rbtn_3.Checked == true)
            {
                PropertyMoreToOne pro = new PropertyMoreToOne();
                pro.Entity = dd_entity.SelectedItem.ToString();
                pro.Name = tb_proName.Text;
                pro.Field = tb_proField.Text;
                pro.ProType = dd_3.SelectedItem.ToString();
                AddProperty(pro, "多对一");

                ds.Tables["PropertyMoreToOne"].Rows.Add(pro.Entity, pro.Name, pro.Field, pro.ProType);
            }
            else if (rbtn_4.Checked == true)
            {
                PropertyOneToMore pro = new PropertyOneToMore();
                pro.Entity = dd_entity.SelectedItem.ToString();
                pro.Name = tb_proName.Text;
                pro.Field = tb_proField.Text;
                pro.TableName = tb_4.Text;
                pro.KeyColoumName = tb_41.Text;
                pro.EntityName = tb_42.Text;
                pro.Cascade = chb_cascade.Checked;
                pro.Inverse = chb_inverse.Checked;
                AddProperty(pro, "一对多");
                ds.Tables["PropertyOneToMore"].Rows.Add(pro.Entity, pro.Name, pro.Field, pro.TableName, pro.KeyColoumName, pro.EntityName, pro.Cascade.ToString().ToLower(), pro.Inverse.ToString().ToLower());
            }
            Bind();
            tb_proName.Focus();
            tb_proName.SelectAll();
        }

        private void AddProperty(Property pro, String type)
        {
            ds.Tables["Property"].Rows.Add(pro.Entity, pro.Name, pro.Field, type);
        }
        private void Bind()
        {
            //String str = "";
            if (dd_entity.SelectedItem != null)
            {
                if (dd_proType.SelectedItem.ToString() == "普通属性")
                {
                    dgv_pro.DataSource = Tools.ToDataTable(ds.Tables["PropertyGeneral"].Select("实体类名='" + dd_entity.SelectedItem.ToString() + "'"));
                }
                else if (dd_proType.SelectedItem.ToString() == "主键")
                {
                    dgv_pro.DataSource = Tools.ToDataTable(ds.Tables["PropertyKey"].Select("实体类名='" + dd_entity.SelectedItem.ToString() + "'"));
                }
                else if (dd_proType.SelectedItem.ToString() == "多对一")
                {
                    dgv_pro.DataSource = Tools.ToDataTable(ds.Tables["PropertyMoreToOne"].Select("实体类名='" + dd_entity.SelectedItem.ToString() + "'"));
                }
                else if (dd_proType.SelectedItem.ToString() == "一对多")
                {
                    dgv_pro.DataSource = Tools.ToDataTable(ds.Tables["PropertyOneToMore"].Select("实体类名='" + dd_entity.SelectedItem.ToString() + "'"));
                }
                else if (dd_proType.SelectedItem.ToString() == "全部")
                {
                    dgv_pro.DataSource = Tools.ToDataTable(ds.Tables["Property"].Select("实体类名='" + dd_entity.SelectedItem.ToString() + "'"));
                }
            }
        }

        private void dd_proType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind();
        }

        private void btn_proUp_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_pro.SelectedRows[0].Index;
                DataGridViewRow dgvr1 = dgv_pro.Rows[index]; //当前选中行;
                DataGridViewRow dgvr2 = dgv_pro.Rows[index - 1];//当前选中行的上一行
                dgv_pro.Rows.RemoveAt(index);//删除当前选中行的上一行
                dgv_pro.Rows.RemoveAt(index - 1);//删除当前选中行
                dgv_pro.Rows.Insert(index - 1, dgvr1);//将当前选中行添加
                dgv_pro.Rows.Insert(index, dgvr2);//添加选中行的上一行

                dgv_pro.ClearSelection();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
        }

        private void btn_proDown_Click(object sender, EventArgs e)
        {
            CurrencyManager lcm_temp = (CurrencyManager)this.BindingContext[dgv_pro];
            lcm_temp.Position++;
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void btn_createAll_Click(object sender, EventArgs e)
        {
            Path path = new Path("All", ds, lb_assembly.Text);
            path.Show();
        }

        private void btn_createMappings_Click(object sender, EventArgs e)
        {
            Path path = new Path("Mappings", ds, lb_assembly.Text);
            path.Show();
        }

        private void btn_createRepository_Click(object sender, EventArgs e)
        {
            Path path = new Path("Repository", ds, lb_assembly.Text);
            path.Show();
        }

        private void btn_createEntity_Click(object sender, EventArgs e)
        {
            Path path = new Path("Entity", ds, lb_assembly.Text);
            path.Show();
        }

        private void btn_createDBTable_Click(object sender, EventArgs e)
        {
            Path path = new Path("DBTable", ds, lb_assembly.Text);
            path.Show();
        }

        private void tb_entityName_TextChanged(object sender, EventArgs e)
        {
            tb_entityTableName.Text = "T_" + tb_entityName.Text;
        }

        private void tb_proName_TextChanged(object sender, EventArgs e)
        {
            tb_proField.Text = Tools.ToFirstLetterLower(tb_proName.Text);
        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            PropertyGeneral pro = new PropertyGeneral();
            pro.Entity = dd_entity.SelectedItem.ToString();
            pro.Name = "Name";
            pro.Field = "name";
            pro.ProType = "String";
            AddProperty(pro, "普通属性");

            ds.Tables["PropertyGeneral"].Rows.Add(pro.Entity, pro.Name, pro.Field, pro.ProType);
            Bind();
        }

        private void btn_isStop_Click(object sender, EventArgs e)
        {
            PropertyGeneral pro = new PropertyGeneral();
            pro.Entity = dd_entity.SelectedItem.ToString();
            pro.Name = "IsStop";
            pro.Field = "isStop";
            pro.ProType = "int";
            AddProperty(pro, "普通属性");

            ds.Tables["PropertyGeneral"].Rows.Add(pro.Entity, pro.Name, pro.Field, pro.ProType);
            Bind();
        }

        private void btn_id_Click(object sender, EventArgs e)
        {
            PropertyKey pro = new PropertyKey();
            pro.Entity = dd_entity.SelectedItem.ToString();
            pro.Name = "Id";
            pro.Field = "id";
            pro.KeyType = "自增型";
            AddProperty(pro, "主键");

            ds.Tables["PropertyKey"].Rows.Add(pro.Entity, pro.Name, pro.Field, pro.KeyType);
            Bind();
        }

        private void btn_proDel_Click(object sender, EventArgs e)
        {
            String str = dgv_pro.CurrentRow.Cells["属性名"].Value.ToString();
            DataRow[] dr_list = ds.Tables["Property"].Select("实体类名='" + dd_entity.SelectedItem.ToString() + "' and 属性名='" + str + "'");
            if (dr_list.Length > 0)
            {
                ds.Tables["Property"].Rows[ds.Tables["Property"].Rows.IndexOf(dr_list[0])].Delete();
            }
            Bind();
        }

        private void dd_entity_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind();
        }

        private void tb_assembly_TextChanged(object sender, EventArgs e)
        {
            lb_assembly.Text = this.tb_assembly.Text;
        }
    }
}
