
namespace Dem2._2
{
    partial class Servis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servis));
            this.___Dem2Skarredin2DataSet = new Dem2._2.@__Dem2Skarredin2DataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new Dem2._2.@__Dem2Skarredin2DataSetTableAdapters.ServiceTableAdapter();
            this.tableAdapterManager = new Dem2._2.@__Dem2Skarredin2DataSetTableAdapters.TableAdapterManager();
            this.serviceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.serviceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.serviceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazad = new System.Windows.Forms.Label();
            this.redaktirovanieIDobavlenieServis = new System.Windows.Forms.Button();
            this.Poisk = new System.Windows.Forms.TextBox();
            this.Kolvo = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.___Dem2Skarredin2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingNavigator)).BeginInit();
            this.serviceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ___Dem2Skarredin2DataSet
            // 
            this.___Dem2Skarredin2DataSet.DataSetName = "__Dem2Skarredin2DataSet";
            this.___Dem2Skarredin2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.___Dem2Skarredin2DataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttachedProductTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientServiceTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.DocumentByServiceTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductPhotoTableAdapter = null;
            this.tableAdapterManager.ProductSaleTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ServicePhotoTableAdapter = null;
            this.tableAdapterManager.ServiceTableAdapter = this.serviceTableAdapter;
            this.tableAdapterManager.TagOfClientTableAdapter = null;
            this.tableAdapterManager.TagTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Dem2._2.@__Dem2Skarredin2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // serviceBindingNavigator
            // 
            this.serviceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.serviceBindingNavigator.BindingSource = this.serviceBindingSource;
            this.serviceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.serviceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.serviceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.serviceBindingNavigatorSaveItem});
            this.serviceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.serviceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.serviceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.serviceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.serviceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.serviceBindingNavigator.Name = "serviceBindingNavigator";
            this.serviceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.serviceBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.serviceBindingNavigator.TabIndex = 0;
            this.serviceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // serviceBindingNavigatorSaveItem
            // 
            this.serviceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.serviceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("serviceBindingNavigatorSaveItem.Image")));
            this.serviceBindingNavigatorSaveItem.Name = "serviceBindingNavigatorSaveItem";
            this.serviceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.serviceBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.serviceBindingNavigatorSaveItem.Click += new System.EventHandler(this.serviceBindingNavigatorSaveItem_Click);
            // 
            // serviceDataGridView
            // 
            this.serviceDataGridView.AutoGenerateColumns = false;
            this.serviceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.serviceDataGridView.DataSource = this.serviceBindingSource;
            this.serviceDataGridView.Location = new System.Drawing.Point(12, 77);
            this.serviceDataGridView.Name = "serviceDataGridView";
            this.serviceDataGridView.Size = new System.Drawing.Size(776, 361);
            this.serviceDataGridView.TabIndex = 1;
            this.serviceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DurationInSeconds";
            this.dataGridViewTextBoxColumn4.HeaderText = "Время в секундах";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn6.HeaderText = "Скидка в %";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MainImagePath";
            this.dataGridViewTextBoxColumn7.HeaderText = "Путь к фото";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Nazad
            // 
            this.Nazad.AutoSize = true;
            this.Nazad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nazad.Location = new System.Drawing.Point(12, 37);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(25, 13);
            this.Nazad.TabIndex = 4;
            this.Nazad.Text = "<----";
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // redaktirovanieIDobavlenieServis
            // 
            this.redaktirovanieIDobavlenieServis.Location = new System.Drawing.Point(562, 48);
            this.redaktirovanieIDobavlenieServis.Name = "redaktirovanieIDobavlenieServis";
            this.redaktirovanieIDobavlenieServis.Size = new System.Drawing.Size(226, 23);
            this.redaktirovanieIDobavlenieServis.TabIndex = 5;
            this.redaktirovanieIDobavlenieServis.Text = "Добавление и редактирование";
            this.redaktirovanieIDobavlenieServis.UseVisualStyleBackColor = true;
            this.redaktirovanieIDobavlenieServis.Click += new System.EventHandler(this.redaktirovanieIDobavlenieServis_Click);
            // 
            // Poisk
            // 
            this.Poisk.Location = new System.Drawing.Point(357, 48);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(179, 20);
            this.Poisk.TabIndex = 6;
            this.Poisk.Text = "Поиск";
            this.Poisk.TextChanged += new System.EventHandler(this.Poisk_TextChanged);
            // 
            // Kolvo
            // 
            this.Kolvo.AutoSize = true;
            this.Kolvo.Location = new System.Drawing.Point(49, 457);
            this.Kolvo.Name = "Kolvo";
            this.Kolvo.Size = new System.Drawing.Size(0, 13);
            this.Kolvo.TabIndex = 7;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(312, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(39, 13);
            this.label.TabIndex = 19;
            this.label.Text = "Поиск";
            // 
            // Servis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Kolvo);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.redaktirovanieIDobavlenieServis);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.serviceDataGridView);
            this.Controls.Add(this.serviceBindingNavigator);
            this.Name = "Servis";
            this.Text = "Servis";
            this.Load += new System.EventHandler(this.Servis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.___Dem2Skarredin2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingNavigator)).EndInit();
            this.serviceBindingNavigator.ResumeLayout(false);
            this.serviceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private __Dem2Skarredin2DataSet ___Dem2Skarredin2DataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private __Dem2Skarredin2DataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private __Dem2Skarredin2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator serviceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton serviceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView serviceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label Nazad;
        private System.Windows.Forms.Button redaktirovanieIDobavlenieServis;
        private System.Windows.Forms.TextBox Poisk;
        private System.Windows.Forms.Label Kolvo;
        private System.Windows.Forms.Label label;
    }
}