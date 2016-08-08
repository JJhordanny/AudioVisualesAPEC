namespace AudioVisualesAPEC
{
    partial class Reservacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dbAudiovisualesDataSet = new AudioVisualesAPEC.dbAudiovisualesDataSet();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter = new AudioVisualesAPEC.dbAudiovisualesDataSetTableAdapters.EquiposTableAdapter();
            this.equiposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tiposEquiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposEquiposTableAdapter = new AudioVisualesAPEC.dbAudiovisualesDataSetTableAdapters.TiposEquiposTableAdapter();
            this.tiposEquiposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbAudiovisualesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposEquiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposEquiposBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Pro Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservación de Equipos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 382);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección de Equipos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tiposEquiposBindingSource1;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // dbAudiovisualesDataSet
            // 
            this.dbAudiovisualesDataSet.DataSetName = "dbAudiovisualesDataSet";
            this.dbAudiovisualesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.dbAudiovisualesDataSet;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // equiposBindingSource1
            // 
            this.equiposBindingSource1.DataMember = "Equipos";
            this.equiposBindingSource1.DataSource = this.dbAudiovisualesDataSet;
            // 
            // tiposEquiposBindingSource
            // 
            this.tiposEquiposBindingSource.DataMember = "TiposEquipos";
            this.tiposEquiposBindingSource.DataSource = this.dbAudiovisualesDataSet;
            // 
            // tiposEquiposTableAdapter
            // 
            this.tiposEquiposTableAdapter.ClearBeforeFill = true;
            // 
            // tiposEquiposBindingSource1
            // 
            this.tiposEquiposBindingSource1.DataMember = "TiposEquipos";
            this.tiposEquiposBindingSource1.DataSource = this.dbAudiovisualesDataSet;
            // 
            // Reservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 449);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Reservacion";
            this.Text = "Reservacion / AudioVisuales JJ for APECion";
            this.Load += new System.EventHandler(this.Reservacion_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbAudiovisualesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposEquiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposEquiposBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private dbAudiovisualesDataSet dbAudiovisualesDataSet;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private dbAudiovisualesDataSetTableAdapters.EquiposTableAdapter equiposTableAdapter;
        private System.Windows.Forms.BindingSource equiposBindingSource1;
        private System.Windows.Forms.BindingSource tiposEquiposBindingSource;
        private dbAudiovisualesDataSetTableAdapters.TiposEquiposTableAdapter tiposEquiposTableAdapter;
        private System.Windows.Forms.BindingSource tiposEquiposBindingSource1;
    }
}