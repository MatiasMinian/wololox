﻿namespace WindowsFormsApplication1
{
    partial class Menu_Administradores
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
            this.botonUser = new System.Windows.Forms.Button();
            this.botonRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonVisibilidad = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visibilidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearVisibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarVisibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVisibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonUser
            // 
            this.botonUser.Location = new System.Drawing.Point(250, 67);
            this.botonUser.Name = "botonUser";
            this.botonUser.Size = new System.Drawing.Size(122, 27);
            this.botonUser.TabIndex = 4;
            this.botonUser.Text = "ABM de Usuario";
            this.botonUser.UseVisualStyleBackColor = true;
            this.botonUser.Click += new System.EventHandler(this.botonUser_Click);
            // 
            // botonRol
            // 
            this.botonRol.Location = new System.Drawing.Point(250, 34);
            this.botonRol.Name = "botonRol";
            this.botonRol.Size = new System.Drawing.Size(122, 27);
            this.botonRol.TabIndex = 3;
            this.botonRol.Text = "ABM de Rol";
            this.botonRol.UseVisualStyleBackColor = true;
            this.botonRol.Click += new System.EventHandler(this.botonRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bienvenido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(250, 133);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(122, 27);
            this.botonSalir.TabIndex = 10;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonVisibilidad
            // 
            this.botonVisibilidad.Location = new System.Drawing.Point(250, 100);
            this.botonVisibilidad.Name = "botonVisibilidad";
            this.botonVisibilidad.Size = new System.Drawing.Size(122, 27);
            this.botonVisibilidad.TabIndex = 5;
            this.botonVisibilidad.Text = "ABM de Visibilidad";
            this.botonVisibilidad.UseVisualStyleBackColor = true;
            this.botonVisibilidad.Click += new System.EventHandler(this.botonVisibilidad_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.visibilidadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearRolToolStripMenuItem,
            this.modificarRolToolStripMenuItem,
            this.eliminarRolToolStripMenuItem,
            this.habilitarRolToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // crearRolToolStripMenuItem
            // 
            this.crearRolToolStripMenuItem.Name = "crearRolToolStripMenuItem";
            this.crearRolToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.crearRolToolStripMenuItem.Text = "Crear Rol";
            this.crearRolToolStripMenuItem.Click += new System.EventHandler(this.crearRolToolStripMenuItem_Click);
            // 
            // modificarRolToolStripMenuItem
            // 
            this.modificarRolToolStripMenuItem.Name = "modificarRolToolStripMenuItem";
            this.modificarRolToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.modificarRolToolStripMenuItem.Text = "Modificar Rol";
            this.modificarRolToolStripMenuItem.Click += new System.EventHandler(this.modificarRolToolStripMenuItem_Click);
            // 
            // eliminarRolToolStripMenuItem
            // 
            this.eliminarRolToolStripMenuItem.Name = "eliminarRolToolStripMenuItem";
            this.eliminarRolToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.eliminarRolToolStripMenuItem.Text = "Eliminar Rol";
            this.eliminarRolToolStripMenuItem.Click += new System.EventHandler(this.eliminarRolToolStripMenuItem_Click);
            // 
            // habilitarRolToolStripMenuItem
            // 
            this.habilitarRolToolStripMenuItem.Name = "habilitarRolToolStripMenuItem";
            this.habilitarRolToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.habilitarRolToolStripMenuItem.Text = "Habilitar Rol";
            this.habilitarRolToolStripMenuItem.Click += new System.EventHandler(this.habilitarRolToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem,
            this.eliminarUsuarioToolStripMenuItem,
            this.habilitarUsuarioToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear usuario";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.empresaToolStripMenuItem1});
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar usuario";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click);
            // 
            // empresaToolStripMenuItem1
            // 
            this.empresaToolStripMenuItem1.Name = "empresaToolStripMenuItem1";
            this.empresaToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.empresaToolStripMenuItem1.Text = "Empresa";
            this.empresaToolStripMenuItem1.Click += new System.EventHandler(this.empresaToolStripMenuItem1_Click);
            // 
            // eliminarUsuarioToolStripMenuItem
            // 
            this.eliminarUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem2,
            this.empresaToolStripMenuItem2});
            this.eliminarUsuarioToolStripMenuItem.Name = "eliminarUsuarioToolStripMenuItem";
            this.eliminarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarUsuarioToolStripMenuItem.Text = "Eliminar usuario";
            // 
            // clienteToolStripMenuItem2
            // 
            this.clienteToolStripMenuItem2.Name = "clienteToolStripMenuItem2";
            this.clienteToolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.clienteToolStripMenuItem2.Text = "Cliente";
            this.clienteToolStripMenuItem2.Click += new System.EventHandler(this.clienteToolStripMenuItem2_Click);
            // 
            // empresaToolStripMenuItem2
            // 
            this.empresaToolStripMenuItem2.Name = "empresaToolStripMenuItem2";
            this.empresaToolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.empresaToolStripMenuItem2.Text = "Empresa";
            this.empresaToolStripMenuItem2.Click += new System.EventHandler(this.empresaToolStripMenuItem2_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // habilitarUsuarioToolStripMenuItem
            // 
            this.habilitarUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem3,
            this.empresaToolStripMenuItem3});
            this.habilitarUsuarioToolStripMenuItem.Name = "habilitarUsuarioToolStripMenuItem";
            this.habilitarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.habilitarUsuarioToolStripMenuItem.Text = "Habilitar usuario";
            // 
            // visibilidadesToolStripMenuItem
            // 
            this.visibilidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearVisibilidadToolStripMenuItem,
            this.modificarVisibilidadToolStripMenuItem,
            this.eliminarVisibilidadToolStripMenuItem});
            this.visibilidadesToolStripMenuItem.Name = "visibilidadesToolStripMenuItem";
            this.visibilidadesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.visibilidadesToolStripMenuItem.Text = "Visibilidades";
            // 
            // crearVisibilidadToolStripMenuItem
            // 
            this.crearVisibilidadToolStripMenuItem.Name = "crearVisibilidadToolStripMenuItem";
            this.crearVisibilidadToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.crearVisibilidadToolStripMenuItem.Text = "Crear visibilidad";
            // 
            // modificarVisibilidadToolStripMenuItem
            // 
            this.modificarVisibilidadToolStripMenuItem.Name = "modificarVisibilidadToolStripMenuItem";
            this.modificarVisibilidadToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.modificarVisibilidadToolStripMenuItem.Text = "Modificar visibilidad";
            // 
            // eliminarVisibilidadToolStripMenuItem
            // 
            this.eliminarVisibilidadToolStripMenuItem.Name = "eliminarVisibilidadToolStripMenuItem";
            this.eliminarVisibilidadToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.eliminarVisibilidadToolStripMenuItem.Text = "Eliminar visibilidad";
            // 
            // clienteToolStripMenuItem3
            // 
            this.clienteToolStripMenuItem3.Name = "clienteToolStripMenuItem3";
            this.clienteToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem3.Text = "Cliente";
            this.clienteToolStripMenuItem3.Click += new System.EventHandler(this.clienteToolStripMenuItem3_Click);
            // 
            // empresaToolStripMenuItem3
            // 
            this.empresaToolStripMenuItem3.Name = "empresaToolStripMenuItem3";
            this.empresaToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.empresaToolStripMenuItem3.Text = "Empresa";
            this.empresaToolStripMenuItem3.Click += new System.EventHandler(this.empresaToolStripMenuItem3_Click);
            // 
            // Menu_Administradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 172);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonVisibilidad);
            this.Controls.Add(this.botonUser);
            this.Controls.Add(this.botonRol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Administradores";
            this.ShowIcon = false;
            this.Text = "Menu de Administradores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonUser;
        private System.Windows.Forms.Button botonRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonVisibilidad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visibilidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearVisibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarVisibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVisibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem3;
    }
}