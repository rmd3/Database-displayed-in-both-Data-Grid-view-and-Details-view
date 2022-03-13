
namespace D_Anjolell_cc3
{
    partial class DetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsForm));
            System.Windows.Forms.Label medIDLabel;
            System.Windows.Forms.Label mednameLabel;
            System.Windows.Forms.Label medsizeLabel;
            System.Windows.Forms.Label medqtyLabel;
            System.Windows.Forms.Label medeffectsLabel;
            this._D_AnjolellMedicalDataSet = new D_Anjolell_cc3._D_AnjolellMedicalDataSet();
            this.medicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicationsTableAdapter = new D_Anjolell_cc3._D_AnjolellMedicalDataSetTableAdapters.MedicationsTableAdapter();
            this.tableAdapterManager = new D_Anjolell_cc3._D_AnjolellMedicalDataSetTableAdapters.TableAdapterManager();
            this.medicationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.medicationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medIDTextBox = new System.Windows.Forms.TextBox();
            this.mednameTextBox = new System.Windows.Forms.TextBox();
            this.medsizeTextBox = new System.Windows.Forms.TextBox();
            this.medqtyTextBox = new System.Windows.Forms.TextBox();
            this.medeffectsTextBox = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            medIDLabel = new System.Windows.Forms.Label();
            mednameLabel = new System.Windows.Forms.Label();
            medsizeLabel = new System.Windows.Forms.Label();
            medqtyLabel = new System.Windows.Forms.Label();
            medeffectsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._D_AnjolellMedicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingNavigator)).BeginInit();
            this.medicationsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // _D_AnjolellMedicalDataSet
            // 
            this._D_AnjolellMedicalDataSet.DataSetName = "_D_AnjolellMedicalDataSet";
            this._D_AnjolellMedicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicationsBindingSource
            // 
            this.medicationsBindingSource.DataMember = "Medications";
            this.medicationsBindingSource.DataSource = this._D_AnjolellMedicalDataSet;
            // 
            // medicationsTableAdapter
            // 
            this.medicationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MedicationsTableAdapter = this.medicationsTableAdapter;
            this.tableAdapterManager.UpdateOrder = D_Anjolell_cc3._D_AnjolellMedicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicationsBindingNavigator
            // 
            this.medicationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicationsBindingNavigator.BindingSource = this.medicationsBindingSource;
            this.medicationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicationsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.medicationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medicationsBindingNavigatorSaveItem});
            this.medicationsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicationsBindingNavigator.Name = "medicationsBindingNavigator";
            this.medicationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicationsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.medicationsBindingNavigator.TabIndex = 0;
            this.medicationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // medicationsBindingNavigatorSaveItem
            // 
            this.medicationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicationsBindingNavigatorSaveItem.Image")));
            this.medicationsBindingNavigatorSaveItem.Name = "medicationsBindingNavigatorSaveItem";
            this.medicationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.medicationsBindingNavigatorSaveItem.Text = "Save Data";
            this.medicationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicationsBindingNavigatorSaveItem_Click);
            // 
            // medIDLabel
            // 
            medIDLabel.AutoSize = true;
            medIDLabel.Location = new System.Drawing.Point(74, 50);
            medIDLabel.Name = "medIDLabel";
            medIDLabel.Size = new System.Drawing.Size(56, 17);
            medIDLabel.TabIndex = 1;
            medIDLabel.Text = "med ID:";
            // 
            // medIDTextBox
            // 
            this.medIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationsBindingSource, "medID", true));
            this.medIDTextBox.Location = new System.Drawing.Point(161, 47);
            this.medIDTextBox.Name = "medIDTextBox";
            this.medIDTextBox.Size = new System.Drawing.Size(280, 22);
            this.medIDTextBox.TabIndex = 2;
            // 
            // mednameLabel
            // 
            mednameLabel.AutoSize = true;
            mednameLabel.Location = new System.Drawing.Point(74, 78);
            mednameLabel.Name = "mednameLabel";
            mednameLabel.Size = new System.Drawing.Size(74, 17);
            mednameLabel.TabIndex = 3;
            mednameLabel.Text = "medname:";
            // 
            // mednameTextBox
            // 
            this.mednameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationsBindingSource, "medname", true));
            this.mednameTextBox.Location = new System.Drawing.Point(161, 75);
            this.mednameTextBox.Name = "mednameTextBox";
            this.mednameTextBox.Size = new System.Drawing.Size(280, 22);
            this.mednameTextBox.TabIndex = 4;
            // 
            // medsizeLabel
            // 
            medsizeLabel.AutoSize = true;
            medsizeLabel.Location = new System.Drawing.Point(74, 106);
            medsizeLabel.Name = "medsizeLabel";
            medsizeLabel.Size = new System.Drawing.Size(64, 17);
            medsizeLabel.TabIndex = 5;
            medsizeLabel.Text = "medsize:";
            // 
            // medsizeTextBox
            // 
            this.medsizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationsBindingSource, "medsize", true));
            this.medsizeTextBox.Location = new System.Drawing.Point(161, 103);
            this.medsizeTextBox.Name = "medsizeTextBox";
            this.medsizeTextBox.Size = new System.Drawing.Size(280, 22);
            this.medsizeTextBox.TabIndex = 6;
            // 
            // medqtyLabel
            // 
            medqtyLabel.AutoSize = true;
            medqtyLabel.Location = new System.Drawing.Point(74, 134);
            medqtyLabel.Name = "medqtyLabel";
            medqtyLabel.Size = new System.Drawing.Size(58, 17);
            medqtyLabel.TabIndex = 7;
            medqtyLabel.Text = "medqty:";
            // 
            // medqtyTextBox
            // 
            this.medqtyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationsBindingSource, "medqty", true));
            this.medqtyTextBox.Location = new System.Drawing.Point(161, 131);
            this.medqtyTextBox.Name = "medqtyTextBox";
            this.medqtyTextBox.Size = new System.Drawing.Size(280, 22);
            this.medqtyTextBox.TabIndex = 8;
            // 
            // medeffectsLabel
            // 
            medeffectsLabel.AutoSize = true;
            medeffectsLabel.Location = new System.Drawing.Point(74, 162);
            medeffectsLabel.Name = "medeffectsLabel";
            medeffectsLabel.Size = new System.Drawing.Size(81, 17);
            medeffectsLabel.TabIndex = 9;
            medeffectsLabel.Text = "medeffects:";
            // 
            // medeffectsTextBox
            // 
            this.medeffectsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicationsBindingSource, "medeffects", true));
            this.medeffectsTextBox.Location = new System.Drawing.Point(161, 159);
            this.medeffectsTextBox.Name = "medeffectsTextBox";
            this.medeffectsTextBox.Size = new System.Drawing.Size(280, 22);
            this.medeffectsTextBox.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(237, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(medIDLabel);
            this.Controls.Add(this.medIDTextBox);
            this.Controls.Add(mednameLabel);
            this.Controls.Add(this.mednameTextBox);
            this.Controls.Add(medsizeLabel);
            this.Controls.Add(this.medsizeTextBox);
            this.Controls.Add(medqtyLabel);
            this.Controls.Add(this.medqtyTextBox);
            this.Controls.Add(medeffectsLabel);
            this.Controls.Add(this.medeffectsTextBox);
            this.Controls.Add(this.medicationsBindingNavigator);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._D_AnjolellMedicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicationsBindingNavigator)).EndInit();
            this.medicationsBindingNavigator.ResumeLayout(false);
            this.medicationsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _D_AnjolellMedicalDataSet _D_AnjolellMedicalDataSet;
        private System.Windows.Forms.BindingSource medicationsBindingSource;
        private _D_AnjolellMedicalDataSetTableAdapters.MedicationsTableAdapter medicationsTableAdapter;
        private _D_AnjolellMedicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicationsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton medicationsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox medIDTextBox;
        private System.Windows.Forms.TextBox mednameTextBox;
        private System.Windows.Forms.TextBox medsizeTextBox;
        private System.Windows.Forms.TextBox medqtyTextBox;
        private System.Windows.Forms.TextBox medeffectsTextBox;
        private System.Windows.Forms.Button btnExit;
    }
}