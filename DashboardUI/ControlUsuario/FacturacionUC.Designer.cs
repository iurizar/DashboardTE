namespace DashboardUI.ControlUsuario
{
    partial class FacturacionUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartFct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Detalle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "FACTURACIÓN ANUAL POR EMPRESAS (miles de €)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartFct
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFct.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFct.Legends.Add(legend3);
            this.chartFct.Location = new System.Drawing.Point(22, 71);
            this.chartFct.Name = "chartFct";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFct.Series.Add(series3);
            this.chartFct.Size = new System.Drawing.Size(887, 438);
            this.chartFct.TabIndex = 2;
            this.chartFct.Text = "chart1";
            // 
            // Detalle
            // 
            this.Detalle.AutoSize = true;
            this.Detalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Detalle.Location = new System.Drawing.Point(815, 31);
            this.Detalle.Name = "Detalle";
            this.Detalle.Size = new System.Drawing.Size(72, 20);
            this.Detalle.TabIndex = 3;
            this.Detalle.Text = "Detalle ?";
            this.Detalle.Click += new System.EventHandler(this.Detalle_Click);
            // 
            // FacturacionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Detalle);
            this.Controls.Add(this.chartFct);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FacturacionUC";
            this.Size = new System.Drawing.Size(936, 535);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FacturacionUC_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.chartFct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFct;
        private System.Windows.Forms.Label Detalle;
    }
}
