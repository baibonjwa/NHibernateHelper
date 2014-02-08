namespace NhibernateHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_entity = new System.Windows.Forms.DataGridView();
            this.chb_lazy = new System.Windows.Forms.CheckBox();
            this.tb_entityTableName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_addEntity = new System.Windows.Forms.Button();
            this.tb_entityName = new System.Windows.Forms.TextBox();
            this.lbEntityName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_assembly = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_assembly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_proDel = new System.Windows.Forms.Button();
            this.btn_name = new System.Windows.Forms.Button();
            this.btn_isStop = new System.Windows.Forms.Button();
            this.btn_id = new System.Windows.Forms.Button();
            this.dd_1 = new System.Windows.Forms.ComboBox();
            this.btn_proDetail = new System.Windows.Forms.Button();
            this.dgv_pro = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.dd_proType = new System.Windows.Forms.ComboBox();
            this.dd_3 = new System.Windows.Forms.ComboBox();
            this.btn_proDown = new System.Windows.Forms.Button();
            this.btn_proUp = new System.Windows.Forms.Button();
            this.btn_addAttr = new System.Windows.Forms.Button();
            this.tb_42 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_41 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chb_inverse = new System.Windows.Forms.CheckBox();
            this.chb_cascade = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dd_2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtn_1 = new System.Windows.Forms.RadioButton();
            this.rbtn_4 = new System.Windows.Forms.RadioButton();
            this.rbtn_3 = new System.Windows.Forms.RadioButton();
            this.rbtn_2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_proField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_proName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dd_entity = new System.Windows.Forms.ComboBox();
            this.btn_createEntity = new System.Windows.Forms.Button();
            this.btn_createAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成映射文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成数据库表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成数据仓储层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生成实体类文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重置界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_createRepository = new System.Windows.Forms.Button();
            this.btn_createDBTable = new System.Windows.Forms.Button();
            this.btn_createMappings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_entity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_entity);
            this.groupBox1.Controls.Add(this.chb_lazy);
            this.groupBox1.Controls.Add(this.tb_entityTableName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_addEntity);
            this.groupBox1.Controls.Add(this.tb_entityName);
            this.groupBox1.Controls.Add(this.lbEntityName);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "实体类区";
            // 
            // dgv_entity
            // 
            this.dgv_entity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_entity.Location = new System.Drawing.Point(10, 98);
            this.dgv_entity.Name = "dgv_entity";
            this.dgv_entity.RowTemplate.Height = 23;
            this.dgv_entity.Size = new System.Drawing.Size(310, 355);
            this.dgv_entity.TabIndex = 7;
            // 
            // chb_lazy
            // 
            this.chb_lazy.AutoSize = true;
            this.chb_lazy.Location = new System.Drawing.Point(12, 76);
            this.chb_lazy.Name = "chb_lazy";
            this.chb_lazy.Size = new System.Drawing.Size(120, 16);
            this.chb_lazy.TabIndex = 6;
            this.chb_lazy.Text = "是否启用Lazy模式";
            this.chb_lazy.UseVisualStyleBackColor = true;
            // 
            // tb_entityTableName
            // 
            this.tb_entityTableName.Location = new System.Drawing.Point(75, 52);
            this.tb_entityTableName.Name = "tb_entityTableName";
            this.tb_entityTableName.Size = new System.Drawing.Size(100, 21);
            this.tb_entityTableName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "数据表名:";
            // 
            // btn_addEntity
            // 
            this.btn_addEntity.Location = new System.Drawing.Point(189, 25);
            this.btn_addEntity.Name = "btn_addEntity";
            this.btn_addEntity.Size = new System.Drawing.Size(75, 23);
            this.btn_addEntity.TabIndex = 3;
            this.btn_addEntity.Text = "添加实体类";
            this.btn_addEntity.UseVisualStyleBackColor = true;
            this.btn_addEntity.Click += new System.EventHandler(this.btn_addEntity_Click);
            // 
            // tb_entityName
            // 
            this.tb_entityName.Location = new System.Drawing.Point(75, 25);
            this.tb_entityName.Name = "tb_entityName";
            this.tb_entityName.Size = new System.Drawing.Size(100, 21);
            this.tb_entityName.TabIndex = 2;
            this.tb_entityName.TextChanged += new System.EventHandler(this.tb_entityName_TextChanged);
            // 
            // lbEntityName
            // 
            this.lbEntityName.AutoSize = true;
            this.lbEntityName.Location = new System.Drawing.Point(10, 28);
            this.lbEntityName.Name = "lbEntityName";
            this.lbEntityName.Size = new System.Drawing.Size(59, 12);
            this.lbEntityName.TabIndex = 1;
            this.lbEntityName.Text = "实体类名:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_assembly);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_assembly);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "程序集及命名空间";
            // 
            // lb_assembly
            // 
            this.lb_assembly.AutoSize = true;
            this.lb_assembly.Location = new System.Drawing.Point(196, 59);
            this.lb_assembly.Name = "lb_assembly";
            this.lb_assembly.Size = new System.Drawing.Size(41, 12);
            this.lb_assembly.TabIndex = 2;
            this.lb_assembly.Text = "未设置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "当前特征程序集及命名空间名：";
            // 
            // tb_assembly
            // 
            this.tb_assembly.Location = new System.Drawing.Point(12, 35);
            this.tb_assembly.Name = "tb_assembly";
            this.tb_assembly.Size = new System.Drawing.Size(163, 21);
            this.tb_assembly.TabIndex = 8;
            this.tb_assembly.TextChanged += new System.EventHandler(this.tb_assembly_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "特征程序集及命名空间名:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_proDel);
            this.groupBox3.Controls.Add(this.btn_name);
            this.groupBox3.Controls.Add(this.btn_isStop);
            this.groupBox3.Controls.Add(this.btn_id);
            this.groupBox3.Controls.Add(this.dd_1);
            this.groupBox3.Controls.Add(this.btn_proDetail);
            this.groupBox3.Controls.Add(this.dgv_pro);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.dd_proType);
            this.groupBox3.Controls.Add(this.dd_3);
            this.groupBox3.Controls.Add(this.btn_proDown);
            this.groupBox3.Controls.Add(this.btn_proUp);
            this.groupBox3.Controls.Add(this.btn_addAttr);
            this.groupBox3.Controls.Add(this.tb_42);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tb_41);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tb_4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.chb_inverse);
            this.groupBox3.Controls.Add(this.chb_cascade);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dd_2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.rbtn_1);
            this.groupBox3.Controls.Add(this.rbtn_4);
            this.groupBox3.Controls.Add(this.rbtn_3);
            this.groupBox3.Controls.Add(this.rbtn_2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tb_proField);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tb_proName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dd_entity);
            this.groupBox3.Location = new System.Drawing.Point(344, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 498);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "s";
            // 
            // btn_proDel
            // 
            this.btn_proDel.Location = new System.Drawing.Point(178, 460);
            this.btn_proDel.Name = "btn_proDel";
            this.btn_proDel.Size = new System.Drawing.Size(75, 23);
            this.btn_proDel.TabIndex = 44;
            this.btn_proDel.Text = "属性删除";
            this.btn_proDel.UseVisualStyleBackColor = true;
            this.btn_proDel.Click += new System.EventHandler(this.btn_proDel_Click);
            // 
            // btn_name
            // 
            this.btn_name.Location = new System.Drawing.Point(349, 112);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(75, 23);
            this.btn_name.TabIndex = 43;
            this.btn_name.Text = "添加Name";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // btn_isStop
            // 
            this.btn_isStop.Location = new System.Drawing.Point(349, 137);
            this.btn_isStop.Name = "btn_isStop";
            this.btn_isStop.Size = new System.Drawing.Size(75, 23);
            this.btn_isStop.TabIndex = 42;
            this.btn_isStop.Text = "添加IsStop";
            this.btn_isStop.UseVisualStyleBackColor = true;
            this.btn_isStop.Click += new System.EventHandler(this.btn_isStop_Click);
            // 
            // btn_id
            // 
            this.btn_id.Location = new System.Drawing.Point(349, 86);
            this.btn_id.Name = "btn_id";
            this.btn_id.Size = new System.Drawing.Size(75, 23);
            this.btn_id.TabIndex = 41;
            this.btn_id.Text = "添加自增id";
            this.btn_id.UseVisualStyleBackColor = true;
            this.btn_id.Click += new System.EventHandler(this.btn_id_Click);
            // 
            // dd_1
            // 
            this.dd_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_1.Enabled = false;
            this.dd_1.FormattingEnabled = true;
            this.dd_1.Items.AddRange(new object[] {
            "String",
            "int",
            "DateTime",
            "double",
            "bool",
            "byte"});
            this.dd_1.Location = new System.Drawing.Point(156, 88);
            this.dd_1.Name = "dd_1";
            this.dd_1.Size = new System.Drawing.Size(100, 20);
            this.dd_1.TabIndex = 40;
            // 
            // btn_proDetail
            // 
            this.btn_proDetail.Location = new System.Drawing.Point(303, 216);
            this.btn_proDetail.Name = "btn_proDetail";
            this.btn_proDetail.Size = new System.Drawing.Size(107, 23);
            this.btn_proDetail.TabIndex = 39;
            this.btn_proDetail.Text = "查看属性列表";
            this.btn_proDetail.UseVisualStyleBackColor = true;
            // 
            // dgv_pro
            // 
            this.dgv_pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pro.Location = new System.Drawing.Point(20, 244);
            this.dgv_pro.Name = "dgv_pro";
            this.dgv_pro.RowTemplate.Height = 23;
            this.dgv_pro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pro.Size = new System.Drawing.Size(404, 210);
            this.dgv_pro.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(121, 221);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 12);
            this.label15.TabIndex = 37;
            this.label15.Text = "属性类型:";
            // 
            // dd_proType
            // 
            this.dd_proType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_proType.FormattingEnabled = true;
            this.dd_proType.Items.AddRange(new object[] {
            "普通属性",
            "主键",
            "多对一",
            "一对多",
            "全部"});
            this.dd_proType.Location = new System.Drawing.Point(186, 217);
            this.dd_proType.Name = "dd_proType";
            this.dd_proType.Size = new System.Drawing.Size(100, 20);
            this.dd_proType.TabIndex = 36;
            this.dd_proType.SelectedIndexChanged += new System.EventHandler(this.dd_proType_SelectedIndexChanged);
            // 
            // dd_3
            // 
            this.dd_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_3.Enabled = false;
            this.dd_3.FormattingEnabled = true;
            this.dd_3.Location = new System.Drawing.Point(156, 139);
            this.dd_3.Name = "dd_3";
            this.dd_3.Size = new System.Drawing.Size(100, 20);
            this.dd_3.TabIndex = 35;
            // 
            // btn_proDown
            // 
            this.btn_proDown.Location = new System.Drawing.Point(97, 460);
            this.btn_proDown.Name = "btn_proDown";
            this.btn_proDown.Size = new System.Drawing.Size(75, 23);
            this.btn_proDown.TabIndex = 34;
            this.btn_proDown.Text = "属性下移";
            this.btn_proDown.UseVisualStyleBackColor = true;
            this.btn_proDown.Click += new System.EventHandler(this.btn_proDown_Click);
            // 
            // btn_proUp
            // 
            this.btn_proUp.Location = new System.Drawing.Point(16, 460);
            this.btn_proUp.Name = "btn_proUp";
            this.btn_proUp.Size = new System.Drawing.Size(75, 23);
            this.btn_proUp.TabIndex = 33;
            this.btn_proUp.Text = "属性上移";
            this.btn_proUp.UseVisualStyleBackColor = true;
            this.btn_proUp.Click += new System.EventHandler(this.btn_proUp_Click);
            // 
            // btn_addAttr
            // 
            this.btn_addAttr.Location = new System.Drawing.Point(21, 215);
            this.btn_addAttr.Name = "btn_addAttr";
            this.btn_addAttr.Size = new System.Drawing.Size(75, 23);
            this.btn_addAttr.TabIndex = 32;
            this.btn_addAttr.Text = "添加属性";
            this.btn_addAttr.UseVisualStyleBackColor = true;
            this.btn_addAttr.Click += new System.EventHandler(this.btn_addAttr_Click);
            // 
            // tb_42
            // 
            this.tb_42.Enabled = false;
            this.tb_42.Location = new System.Drawing.Point(326, 193);
            this.tb_42.Name = "tb_42";
            this.tb_42.Size = new System.Drawing.Size(100, 21);
            this.tb_42.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(261, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 12);
            this.label14.TabIndex = 29;
            this.label14.Text = "对应实体:";
            // 
            // tb_41
            // 
            this.tb_41.Enabled = false;
            this.tb_41.Location = new System.Drawing.Point(326, 166);
            this.tb_41.Name = "tb_41";
            this.tb_41.Size = new System.Drawing.Size(100, 21);
            this.tb_41.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(261, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 27;
            this.label13.Text = "主键列名:";
            // 
            // tb_4
            // 
            this.tb_4.Enabled = false;
            this.tb_4.Location = new System.Drawing.Point(156, 165);
            this.tb_4.Name = "tb_4";
            this.tb_4.Size = new System.Drawing.Size(100, 21);
            this.tb_4.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 25;
            this.label12.Text = "对应表名:";
            // 
            // chb_inverse
            // 
            this.chb_inverse.AutoSize = true;
            this.chb_inverse.Enabled = false;
            this.chb_inverse.Location = new System.Drawing.Point(190, 194);
            this.chb_inverse.Name = "chb_inverse";
            this.chb_inverse.Size = new System.Drawing.Size(72, 16);
            this.chb_inverse.TabIndex = 24;
            this.chb_inverse.Text = "控制反转";
            this.chb_inverse.UseVisualStyleBackColor = true;
            // 
            // chb_cascade
            // 
            this.chb_cascade.AutoSize = true;
            this.chb_cascade.Enabled = false;
            this.chb_cascade.Location = new System.Drawing.Point(91, 193);
            this.chb_cascade.Name = "chb_cascade";
            this.chb_cascade.Size = new System.Drawing.Size(96, 16);
            this.chb_cascade.TabIndex = 23;
            this.chb_cascade.Text = "级联保存更新";
            this.chb_cascade.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "主键类型:";
            // 
            // dd_2
            // 
            this.dd_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_2.Enabled = false;
            this.dd_2.FormattingEnabled = true;
            this.dd_2.Items.AddRange(new object[] {
            "自增型",
            "字符型"});
            this.dd_2.Location = new System.Drawing.Point(156, 112);
            this.dd_2.Name = "dd_2";
            this.dd_2.Size = new System.Drawing.Size(100, 20);
            this.dd_2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "属性类型:";
            // 
            // rbtn_1
            // 
            this.rbtn_1.AutoSize = true;
            this.rbtn_1.Location = new System.Drawing.Point(20, 89);
            this.rbtn_1.Name = "rbtn_1";
            this.rbtn_1.Size = new System.Drawing.Size(71, 16);
            this.rbtn_1.TabIndex = 18;
            this.rbtn_1.TabStop = true;
            this.rbtn_1.Text = "普通属性";
            this.rbtn_1.UseVisualStyleBackColor = true;
            this.rbtn_1.CheckedChanged += new System.EventHandler(this.rbtn_1_CheckedChanged);
            // 
            // rbtn_4
            // 
            this.rbtn_4.AutoSize = true;
            this.rbtn_4.Location = new System.Drawing.Point(20, 167);
            this.rbtn_4.Name = "rbtn_4";
            this.rbtn_4.Size = new System.Drawing.Size(59, 16);
            this.rbtn_4.TabIndex = 17;
            this.rbtn_4.TabStop = true;
            this.rbtn_4.Text = "一对多";
            this.rbtn_4.UseVisualStyleBackColor = true;
            this.rbtn_4.CheckedChanged += new System.EventHandler(this.rbtn_4_CheckedChanged);
            // 
            // rbtn_3
            // 
            this.rbtn_3.AutoSize = true;
            this.rbtn_3.Location = new System.Drawing.Point(20, 140);
            this.rbtn_3.Name = "rbtn_3";
            this.rbtn_3.Size = new System.Drawing.Size(59, 16);
            this.rbtn_3.TabIndex = 16;
            this.rbtn_3.TabStop = true;
            this.rbtn_3.Text = "多对一";
            this.rbtn_3.UseVisualStyleBackColor = true;
            this.rbtn_3.CheckedChanged += new System.EventHandler(this.rbtn_3_CheckedChanged);
            // 
            // rbtn_2
            // 
            this.rbtn_2.AutoSize = true;
            this.rbtn_2.Location = new System.Drawing.Point(20, 114);
            this.rbtn_2.Name = "rbtn_2";
            this.rbtn_2.Size = new System.Drawing.Size(47, 16);
            this.rbtn_2.TabIndex = 15;
            this.rbtn_2.TabStop = true;
            this.rbtn_2.Text = "主键";
            this.rbtn_2.UseVisualStyleBackColor = true;
            this.rbtn_2.CheckedChanged += new System.EventHandler(this.rbtn_2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "属性类型:";
            // 
            // tb_proField
            // 
            this.tb_proField.Location = new System.Drawing.Point(292, 47);
            this.tb_proField.Name = "tb_proField";
            this.tb_proField.Size = new System.Drawing.Size(100, 21);
            this.tb_proField.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "对应数据字段名:";
            // 
            // tb_proName
            // 
            this.tb_proName.Location = new System.Drawing.Point(72, 47);
            this.tb_proName.Name = "tb_proName";
            this.tb_proName.Size = new System.Drawing.Size(100, 21);
            this.tb_proName.TabIndex = 4;
            this.tb_proName.TextChanged += new System.EventHandler(this.tb_proName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "属性名:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "实体类:";
            // 
            // dd_entity
            // 
            this.dd_entity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dd_entity.Location = new System.Drawing.Point(72, 20);
            this.dd_entity.Name = "dd_entity";
            this.dd_entity.Size = new System.Drawing.Size(135, 20);
            this.dd_entity.TabIndex = 0;
            this.dd_entity.SelectedIndexChanged += new System.EventHandler(this.dd_entity_SelectedIndexChanged);
            // 
            // btn_createEntity
            // 
            this.btn_createEntity.Location = new System.Drawing.Point(678, 531);
            this.btn_createEntity.Name = "btn_createEntity";
            this.btn_createEntity.Size = new System.Drawing.Size(102, 23);
            this.btn_createEntity.TabIndex = 38;
            this.btn_createEntity.Text = "生成实体类文件";
            this.btn_createEntity.UseVisualStyleBackColor = true;
            this.btn_createEntity.Click += new System.EventHandler(this.btn_createEntity_Click);
            // 
            // btn_createAll
            // 
            this.btn_createAll.Location = new System.Drawing.Point(343, 557);
            this.btn_createAll.Name = "btn_createAll";
            this.btn_createAll.Size = new System.Drawing.Size(437, 23);
            this.btn_createAll.TabIndex = 39;
            this.btn_createAll.Text = "全部生成";
            this.btn_createAll.UseVisualStyleBackColor = true;
            this.btn_createAll.Click += new System.EventHandler(this.btn_createAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.生成映射文件ToolStripMenuItem,
            this.生成数据库表ToolStripMenuItem,
            this.生成数据仓储层ToolStripMenuItem,
            this.生成实体类文件ToolStripMenuItem,
            this.全部生成ToolStripMenuItem,
            this.重置界面ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件ToolStripMenuItem.Text = "文件(F)";
            // 
            // 生成映射文件ToolStripMenuItem
            // 
            this.生成映射文件ToolStripMenuItem.Name = "生成映射文件ToolStripMenuItem";
            this.生成映射文件ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.生成映射文件ToolStripMenuItem.Text = "生成映射文件";
            // 
            // 生成数据库表ToolStripMenuItem
            // 
            this.生成数据库表ToolStripMenuItem.Name = "生成数据库表ToolStripMenuItem";
            this.生成数据库表ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.生成数据库表ToolStripMenuItem.Text = "生成数据库表";
            // 
            // 生成数据仓储层ToolStripMenuItem
            // 
            this.生成数据仓储层ToolStripMenuItem.Name = "生成数据仓储层ToolStripMenuItem";
            this.生成数据仓储层ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.生成数据仓储层ToolStripMenuItem.Text = "生成数据仓储层";
            // 
            // 生成实体类文件ToolStripMenuItem
            // 
            this.生成实体类文件ToolStripMenuItem.Name = "生成实体类文件ToolStripMenuItem";
            this.生成实体类文件ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.生成实体类文件ToolStripMenuItem.Text = "生成实体类文件";
            // 
            // 全部生成ToolStripMenuItem
            // 
            this.全部生成ToolStripMenuItem.Name = "全部生成ToolStripMenuItem";
            this.全部生成ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.全部生成ToolStripMenuItem.Text = "全部生成";
            // 
            // 重置界面ToolStripMenuItem
            // 
            this.重置界面ToolStripMenuItem.Name = "重置界面ToolStripMenuItem";
            this.重置界面ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.重置界面ToolStripMenuItem.Text = "重置界面";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助ToolStripMenuItem.Text = "帮助(H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.关于AToolStripMenuItem.Text = "关于(A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // btn_createRepository
            // 
            this.btn_createRepository.Location = new System.Drawing.Point(563, 531);
            this.btn_createRepository.Name = "btn_createRepository";
            this.btn_createRepository.Size = new System.Drawing.Size(102, 23);
            this.btn_createRepository.TabIndex = 37;
            this.btn_createRepository.Text = "生成数据仓储层";
            this.btn_createRepository.UseVisualStyleBackColor = true;
            this.btn_createRepository.Click += new System.EventHandler(this.btn_createRepository_Click);
            // 
            // btn_createDBTable
            // 
            this.btn_createDBTable.Location = new System.Drawing.Point(449, 531);
            this.btn_createDBTable.Name = "btn_createDBTable";
            this.btn_createDBTable.Size = new System.Drawing.Size(102, 23);
            this.btn_createDBTable.TabIndex = 36;
            this.btn_createDBTable.Text = "生成数据库表";
            this.btn_createDBTable.UseVisualStyleBackColor = true;
            this.btn_createDBTable.Click += new System.EventHandler(this.btn_createDBTable_Click);
            // 
            // btn_createMappings
            // 
            this.btn_createMappings.Location = new System.Drawing.Point(343, 531);
            this.btn_createMappings.Name = "btn_createMappings";
            this.btn_createMappings.Size = new System.Drawing.Size(94, 23);
            this.btn_createMappings.TabIndex = 35;
            this.btn_createMappings.Text = "生成映射文件";
            this.btn_createMappings.UseVisualStyleBackColor = true;
            this.btn_createMappings.Click += new System.EventHandler(this.btn_createMappings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 587);
            this.Controls.Add(this.btn_createAll);
            this.Controls.Add(this.btn_createEntity);
            this.Controls.Add(this.btn_createRepository);
            this.Controls.Add(this.btn_createDBTable);
            this.Controls.Add(this.btn_createMappings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Nhibernate开发体系辅助工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_entity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pro)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_entityName;
        private System.Windows.Forms.Label lbEntityName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_assembly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_assembly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addEntity;
        private System.Windows.Forms.TextBox tb_entityTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chb_lazy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_proName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox dd_entity;
        private System.Windows.Forms.TextBox tb_proField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtn_1;
        private System.Windows.Forms.RadioButton rbtn_4;
        private System.Windows.Forms.RadioButton rbtn_3;
        private System.Windows.Forms.RadioButton rbtn_2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox dd_2;
        private System.Windows.Forms.TextBox tb_4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chb_inverse;
        private System.Windows.Forms.CheckBox chb_cascade;
        private System.Windows.Forms.TextBox tb_41;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_proDown;
        private System.Windows.Forms.Button btn_proUp;
        private System.Windows.Forms.Button btn_addAttr;
        private System.Windows.Forms.TextBox tb_42;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_createEntity;
        private System.Windows.Forms.Button btn_createAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成映射文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成数据库表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成数据仓储层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生成实体类文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重置界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_entity;
        private System.Windows.Forms.ComboBox dd_3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox dd_proType;
        private System.Windows.Forms.DataGridView dgv_pro;
        private System.Windows.Forms.Button btn_proDetail;
        private System.Windows.Forms.ComboBox dd_1;
        private System.Windows.Forms.Button btn_createRepository;
        private System.Windows.Forms.Button btn_createDBTable;
        private System.Windows.Forms.Button btn_createMappings;
        private System.Windows.Forms.Button btn_isStop;
        private System.Windows.Forms.Button btn_id;
        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Button btn_proDel;
    }
}

