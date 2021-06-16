
namespace POWERUSER_ASSISTANT
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_send = new System.Windows.Forms.Button();
            this.AREA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LINE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODULE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPERATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AREA,
            this.LINE,
            this.STATION,
            this.MODULE,
            this.OPERATION,
            this.TYPE,
            this.ID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(78, 95);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(931, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_send.Location = new System.Drawing.Point(118, 512);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(125, 45);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "ENVIAR";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // AREA
            // 
            this.AREA.HeaderText = "Area";
            this.AREA.MinimumWidth = 6;
            this.AREA.Name = "AREA";
            this.AREA.Width = 125;
            // 
            // LINE
            // 
            this.LINE.HeaderText = "Linea";
            this.LINE.MinimumWidth = 6;
            this.LINE.Name = "LINE";
            this.LINE.Width = 125;
            // 
            // STATION
            // 
            this.STATION.HeaderText = "ESTACION";
            this.STATION.MinimumWidth = 6;
            this.STATION.Name = "STATION";
            this.STATION.Width = 125;
            // 
            // MODULE
            // 
            this.MODULE.HeaderText = "MODULO";
            this.MODULE.MinimumWidth = 6;
            this.MODULE.Name = "MODULE";
            this.MODULE.Width = 125;
            // 
            // OPERATION
            // 
            this.OPERATION.HeaderText = "AGREGAR O REMOVER";
            this.OPERATION.MinimumWidth = 6;
            this.OPERATION.Name = "OPERATION";
            this.OPERATION.Width = 125;
            // 
            // TYPE
            // 
            this.TYPE.HeaderText = "TIPO";
            this.TYPE.MinimumWidth = 6;
            this.TYPE.Name = "TYPE";
            this.TYPE.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 597);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "POWER ASSISTANT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LINE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODULE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPERATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

