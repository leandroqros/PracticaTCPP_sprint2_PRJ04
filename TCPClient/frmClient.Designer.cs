﻿namespace TCPClient
{
    partial class frmClient
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_desconnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_message = new System.Windows.Forms.TextBox();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.txb_ip = new System.Windows.Forms.TextBox();
            this.gbx_comprovacions = new System.Windows.Forms.GroupBox();
            this.lb_statusInfo = new System.Windows.Forms.Label();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.btn_comprovarXarxa = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.gbx_comprovacions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(452, 247);
            this.btn_config.Margin = new System.Windows.Forms.Padding(2);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(136, 29);
            this.btn_config.TabIndex = 11;
            this.btn_config.Text = "Configuracion";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_desconnect
            // 
            this.btn_desconnect.Location = new System.Drawing.Point(599, 247);
            this.btn_desconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_desconnect.Name = "btn_desconnect";
            this.btn_desconnect.Size = new System.Drawing.Size(137, 29);
            this.btn_desconnect.TabIndex = 12;
            this.btn_desconnect.Text = "Desconectar";
            this.btn_desconnect.UseVisualStyleBackColor = true;
            this.btn_desconnect.Click += new System.EventHandler(this.btn_desconnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_sendMessage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txb_message);
            this.groupBox2.Controls.Add(this.txb_port);
            this.groupBox2.Controls.Add(this.txb_ip);
            this.groupBox2.Location = new System.Drawing.Point(427, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(330, 213);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Envio de datos";
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.Location = new System.Drawing.Point(25, 148);
            this.btn_sendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(284, 27);
            this.btn_sendMessage.TabIndex = 6;
            this.btn_sendMessage.Text = "Enviar mensaje";
            this.btn_sendMessage.UseVisualStyleBackColor = true;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puerto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mensaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP";
            // 
            // txb_message
            // 
            this.txb_message.Location = new System.Drawing.Point(75, 75);
            this.txb_message.Margin = new System.Windows.Forms.Padding(2);
            this.txb_message.Multiline = true;
            this.txb_message.Name = "txb_message";
            this.txb_message.Size = new System.Drawing.Size(234, 55);
            this.txb_message.TabIndex = 2;
            // 
            // txb_port
            // 
            this.txb_port.Location = new System.Drawing.Point(241, 37);
            this.txb_port.Margin = new System.Windows.Forms.Padding(2);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(68, 20);
            this.txb_port.TabIndex = 1;
            // 
            // txb_ip
            // 
            this.txb_ip.Location = new System.Drawing.Point(43, 37);
            this.txb_ip.Margin = new System.Windows.Forms.Padding(2);
            this.txb_ip.Name = "txb_ip";
            this.txb_ip.Size = new System.Drawing.Size(154, 20);
            this.txb_ip.TabIndex = 0;
            // 
            // gbx_comprovacions
            // 
            this.gbx_comprovacions.Controls.Add(this.lb_statusInfo);
            this.gbx_comprovacions.Controls.Add(this.pnl_status);
            this.gbx_comprovacions.Controls.Add(this.label1);
            this.gbx_comprovacions.Controls.Add(this.lbx_console);
            this.gbx_comprovacions.Controls.Add(this.btn_comprovarXarxa);
            this.gbx_comprovacions.Location = new System.Drawing.Point(11, 11);
            this.gbx_comprovacions.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_comprovacions.Name = "gbx_comprovacions";
            this.gbx_comprovacions.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_comprovacions.Size = new System.Drawing.Size(386, 278);
            this.gbx_comprovacions.TabIndex = 9;
            this.gbx_comprovacions.TabStop = false;
            this.gbx_comprovacions.Text = "Comprovaciones";
            // 
            // lb_statusInfo
            // 
            this.lb_statusInfo.AutoSize = true;
            this.lb_statusInfo.Location = new System.Drawing.Point(20, 201);
            this.lb_statusInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_statusInfo.Name = "lb_statusInfo";
            this.lb_statusInfo.Size = new System.Drawing.Size(0, 13);
            this.lb_statusInfo.TabIndex = 4;
            // 
            // pnl_status
            // 
            this.pnl_status.BackColor = System.Drawing.Color.Red;
            this.pnl_status.Location = new System.Drawing.Point(22, 136);
            this.pnl_status.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(55, 57);
            this.pnl_status.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "status";
            // 
            // lbx_console
            // 
            this.lbx_console.BackColor = System.Drawing.Color.Black;
            this.lbx_console.ForeColor = System.Drawing.SystemColors.Info;
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.Location = new System.Drawing.Point(81, 89);
            this.lbx_console.Margin = new System.Windows.Forms.Padding(2);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(277, 160);
            this.lbx_console.TabIndex = 1;
            // 
            // btn_comprovarXarxa
            // 
            this.btn_comprovarXarxa.Location = new System.Drawing.Point(22, 34);
            this.btn_comprovarXarxa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_comprovarXarxa.Name = "btn_comprovarXarxa";
            this.btn_comprovarXarxa.Size = new System.Drawing.Size(336, 27);
            this.btn_comprovarXarxa.TabIndex = 0;
            this.btn_comprovarXarxa.Text = " Comprobar Conexion";
            this.btn_comprovarXarxa.UseVisualStyleBackColor = true;
            this.btn_comprovarXarxa.Click += new System.EventHandler(this.btn_comprovarXarxa_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 299);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_desconnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx_comprovacions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmClient";
            this.Text = "Client TCP-IP";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbx_comprovacions.ResumeLayout(false);
            this.gbx_comprovacions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_desconnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_sendMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_message;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.TextBox txb_ip;
        private System.Windows.Forms.GroupBox gbx_comprovacions;
        private System.Windows.Forms.Label lb_statusInfo;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Button btn_comprovarXarxa;
    }
}

