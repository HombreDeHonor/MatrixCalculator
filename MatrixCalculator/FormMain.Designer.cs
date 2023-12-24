namespace MatrixCalculator
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMatrixAandB = new System.Windows.Forms.Panel();
            this.groupBoxMatrixB = new System.Windows.Forms.GroupBox();
            this.dataGridMatrixB = new System.Windows.Forms.DataGridView();
            this.groupBoxMatrixA = new System.Windows.Forms.GroupBox();
            this.dataGridMatrixA = new System.Windows.Forms.DataGridView();
            this.panelMatrixFunctions = new System.Windows.Forms.Panel();
            this.groupBoxMatrixOperations = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonInverseMatrix = new System.Windows.Forms.Button();
            this.checkBoxInverseMatrixB = new System.Windows.Forms.CheckBox();
            this.checkBoxInverseMatrixA = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonDeterminantMatrix = new System.Windows.Forms.Button();
            this.checkBoxDeterminantMatrixB = new System.Windows.Forms.CheckBox();
            this.checkBoxDeterminantMatrixA = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxTransposeMatrixBEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxTransposeMatrixAEnabled = new System.Windows.Forms.CheckBox();
            this.buttonTransposeMatrix = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonMultiplyMatrix = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddMatrix = new System.Windows.Forms.Button();
            this.groupBoxMatrixCreate = new System.Windows.Forms.GroupBox();
            this.buttonGenerateMatrix = new System.Windows.Forms.Button();
            this.checkBoxRandomFilling = new System.Windows.Forms.CheckBox();
            this.groupBoxMatrixBSettings = new System.Windows.Forms.GroupBox();
            this.numericUpDownMatrixBColumnNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownMatrixBRowNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxMatrixBEnabled = new System.Windows.Forms.CheckBox();
            this.groupBoxMatrixASettings = new System.Windows.Forms.GroupBox();
            this.numericUpDownMatrixAColumnNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMatrixARowNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegistration = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonUserInformation = new System.Windows.Forms.Button();
            this.panelMatrixAandB.SuspendLayout();
            this.groupBoxMatrixB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrixB)).BeginInit();
            this.groupBoxMatrixA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrixA)).BeginInit();
            this.panelMatrixFunctions.SuspendLayout();
            this.groupBoxMatrixOperations.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxMatrixCreate.SuspendLayout();
            this.groupBoxMatrixBSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrixBColumnNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrixBRowNumber)).BeginInit();
            this.groupBoxMatrixASettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrixAColumnNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrixARowNumber)).BeginInit();
            this.panelRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMatrixAandB
            // 
            this.panelMatrixAandB.Controls.Add(this.groupBoxMatrixB);
            this.panelMatrixAandB.Controls.Add(this.groupBoxMatrixA);
            this.panelMatrixAandB.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMatrixAandB.Location = new System.Drawing.Point(0, 0);
            this.panelMatrixAandB.Name = "panelMatrixAandB";
            this.panelMatrixAandB.Size = new System.Drawing.Size(475, 634);
            this.panelMatrixAandB.TabIndex = 0;
            // 
            // groupBoxMatrixB
            // 
            this.groupBoxMatrixB.Controls.Add(this.dataGridMatrixB);
            this.groupBoxMatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMatrixB.Location = new System.Drawing.Point(0, 317);
            this.groupBoxMatrixB.Name = "groupBoxMatrixB";
            this.groupBoxMatrixB.Size = new System.Drawing.Size(475, 317);
            this.groupBoxMatrixB.TabIndex = 1;
            this.groupBoxMatrixB.TabStop = false;
            this.groupBoxMatrixB.Text = "Матриця B";
            // 
            // dataGridMatrixB
            // 
            this.dataGridMatrixB.AllowUserToAddRows = false;
            this.dataGridMatrixB.AllowUserToDeleteRows = false;
            this.dataGridMatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMatrixB.Location = new System.Drawing.Point(3, 16);
            this.dataGridMatrixB.Name = "dataGridMatrixB";
            this.dataGridMatrixB.Size = new System.Drawing.Size(469, 298);
            this.dataGridMatrixB.TabIndex = 0;
            this.dataGridMatrixB.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridMatrixB_CellValidating);
            // 
            // groupBoxMatrixA
            // 
            this.groupBoxMatrixA.Controls.Add(this.dataGridMatrixA);
            this.groupBoxMatrixA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMatrixA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMatrixA.Name = "groupBoxMatrixA";
            this.groupBoxMatrixA.Size = new System.Drawing.Size(475, 317);
            this.groupBoxMatrixA.TabIndex = 0;
            this.groupBoxMatrixA.TabStop = false;
            this.groupBoxMatrixA.Text = "Матриця А";
            // 
            // dataGridMatrixA
            // 
            this.dataGridMatrixA.AllowUserToAddRows = false;
            this.dataGridMatrixA.AllowUserToDeleteRows = false;
            this.dataGridMatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridMatrixA.Location = new System.Drawing.Point(3, 16);
            this.dataGridMatrixA.Name = "dataGridMatrixA";
            this.dataGridMatrixA.Size = new System.Drawing.Size(469, 298);
            this.dataGridMatrixA.TabIndex = 0;
            this.dataGridMatrixA.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridMatrixA_CellValidating);
            // 
            // panelMatrixFunctions
            // 
            this.panelMatrixFunctions.Controls.Add(this.groupBoxMatrixOperations);
            this.panelMatrixFunctions.Controls.Add(this.groupBoxMatrixCreate);
            this.panelMatrixFunctions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMatrixFunctions.Location = new System.Drawing.Point(475, 45);
            this.panelMatrixFunctions.Name = "panelMatrixFunctions";
            this.panelMatrixFunctions.Size = new System.Drawing.Size(333, 589);
            this.panelMatrixFunctions.TabIndex = 1;
            // 
            // groupBoxMatrixOperations
            // 
            this.groupBoxMatrixOperations.Controls.Add(this.groupBox5);
            this.groupBoxMatrixOperations.Controls.Add(this.groupBox4);
            this.groupBoxMatrixOperations.Controls.Add(this.groupBox3);
            this.groupBoxMatrixOperations.Controls.Add(this.groupBox2);
            this.groupBoxMatrixOperations.Controls.Add(this.groupBox1);
            this.groupBoxMatrixOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMatrixOperations.Location = new System.Drawing.Point(0, 235);
            this.groupBoxMatrixOperations.Name = "groupBoxMatrixOperations";
            this.groupBoxMatrixOperations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxMatrixOperations.Size = new System.Drawing.Size(333, 351);
            this.groupBoxMatrixOperations.TabIndex = 1;
            this.groupBoxMatrixOperations.TabStop = false;
            this.groupBoxMatrixOperations.Text = "Операції над матрицями";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonInverseMatrix);
            this.groupBox5.Controls.Add(this.checkBoxInverseMatrixB);
            this.groupBox5.Controls.Add(this.checkBoxInverseMatrixA);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 270);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(327, 75);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Обернена матриця";
            // 
            // buttonInverseMatrix
            // 
            this.buttonInverseMatrix.BackColor = System.Drawing.Color.Green;
            this.buttonInverseMatrix.Enabled = false;
            this.buttonInverseMatrix.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInverseMatrix.Location = new System.Drawing.Point(6, 38);
            this.buttonInverseMatrix.Name = "buttonInverseMatrix";
            this.buttonInverseMatrix.Size = new System.Drawing.Size(318, 31);
            this.buttonInverseMatrix.TabIndex = 13;
            this.buttonInverseMatrix.Text = "Знайти обернену матрицю";
            this.buttonInverseMatrix.UseVisualStyleBackColor = false;
            this.buttonInverseMatrix.Click += new System.EventHandler(this.buttonInverseMatrix_Click);
            // 
            // checkBoxInverseMatrixB
            // 
            this.checkBoxInverseMatrixB.AutoSize = true;
            this.checkBoxInverseMatrixB.Enabled = false;
            this.checkBoxInverseMatrixB.Location = new System.Drawing.Point(194, 19);
            this.checkBoxInverseMatrixB.Name = "checkBoxInverseMatrixB";
            this.checkBoxInverseMatrixB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxInverseMatrixB.Size = new System.Drawing.Size(80, 17);
            this.checkBoxInverseMatrixB.TabIndex = 12;
            this.checkBoxInverseMatrixB.Text = "Матриця B";
            this.checkBoxInverseMatrixB.UseVisualStyleBackColor = true;
            // 
            // checkBoxInverseMatrixA
            // 
            this.checkBoxInverseMatrixA.AutoSize = true;
            this.checkBoxInverseMatrixA.Enabled = false;
            this.checkBoxInverseMatrixA.Location = new System.Drawing.Point(41, 19);
            this.checkBoxInverseMatrixA.Name = "checkBoxInverseMatrixA";
            this.checkBoxInverseMatrixA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxInverseMatrixA.Size = new System.Drawing.Size(80, 17);
            this.checkBoxInverseMatrixA.TabIndex = 12;
            this.checkBoxInverseMatrixA.Text = "Матриця А";
            this.checkBoxInverseMatrixA.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonDeterminantMatrix);
            this.groupBox4.Controls.Add(this.checkBoxDeterminantMatrixB);
            this.groupBox4.Controls.Add(this.checkBoxDeterminantMatrixA);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 194);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(327, 76);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Визначення детермінанту";
            // 
            // buttonDeterminantMatrix
            // 
            this.buttonDeterminantMatrix.BackColor = System.Drawing.Color.Green;
            this.buttonDeterminantMatrix.Enabled = false;
            this.buttonDeterminantMatrix.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeterminantMatrix.Location = new System.Drawing.Point(3, 42);
            this.buttonDeterminantMatrix.Name = "buttonDeterminantMatrix";
            this.buttonDeterminantMatrix.Size = new System.Drawing.Size(318, 31);
            this.buttonDeterminantMatrix.TabIndex = 12;
            this.buttonDeterminantMatrix.Text = "Визначити детермінант";
            this.buttonDeterminantMatrix.UseVisualStyleBackColor = false;
            this.buttonDeterminantMatrix.Click += new System.EventHandler(this.buttonDeterminantMatrix_Click);
            // 
            // checkBoxDeterminantMatrixB
            // 
            this.checkBoxDeterminantMatrixB.AutoSize = true;
            this.checkBoxDeterminantMatrixB.Enabled = false;
            this.checkBoxDeterminantMatrixB.Location = new System.Drawing.Point(194, 19);
            this.checkBoxDeterminantMatrixB.Name = "checkBoxDeterminantMatrixB";
            this.checkBoxDeterminantMatrixB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxDeterminantMatrixB.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDeterminantMatrixB.TabIndex = 12;
            this.checkBoxDeterminantMatrixB.Text = "Матриця B";
            this.checkBoxDeterminantMatrixB.UseVisualStyleBackColor = true;
            // 
            // checkBoxDeterminantMatrixA
            // 
            this.checkBoxDeterminantMatrixA.AutoSize = true;
            this.checkBoxDeterminantMatrixA.Enabled = false;
            this.checkBoxDeterminantMatrixA.Location = new System.Drawing.Point(41, 19);
            this.checkBoxDeterminantMatrixA.Name = "checkBoxDeterminantMatrixA";
            this.checkBoxDeterminantMatrixA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxDeterminantMatrixA.Size = new System.Drawing.Size(80, 17);
            this.checkBoxDeterminantMatrixA.TabIndex = 12;
            this.checkBoxDeterminantMatrixA.Text = "Матриця А";
            this.checkBoxDeterminantMatrixA.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxTransposeMatrixBEnabled);
            this.groupBox3.Controls.Add(this.checkBoxTransposeMatrixAEnabled);
            this.groupBox3.Controls.Add(this.buttonTransposeMatrix);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(327, 76);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Транспонування матриць";
            // 
            // checkBoxTransposeMatrixBEnabled
            // 
            this.checkBoxTransposeMatrixBEnabled.AutoSize = true;
            this.checkBoxTransposeMatrixBEnabled.Enabled = false;
            this.checkBoxTransposeMatrixBEnabled.Location = new System.Drawing.Point(194, 19);
            this.checkBoxTransposeMatrixBEnabled.Name = "checkBoxTransposeMatrixBEnabled";
            this.checkBoxTransposeMatrixBEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxTransposeMatrixBEnabled.Size = new System.Drawing.Size(80, 17);
            this.checkBoxTransposeMatrixBEnabled.TabIndex = 11;
            this.checkBoxTransposeMatrixBEnabled.Text = "Матриця B";
            this.checkBoxTransposeMatrixBEnabled.UseVisualStyleBackColor = true;
            // 
            // checkBoxTransposeMatrixAEnabled
            // 
            this.checkBoxTransposeMatrixAEnabled.AutoSize = true;
            this.checkBoxTransposeMatrixAEnabled.Enabled = false;
            this.checkBoxTransposeMatrixAEnabled.Location = new System.Drawing.Point(41, 19);
            this.checkBoxTransposeMatrixAEnabled.Name = "checkBoxTransposeMatrixAEnabled";
            this.checkBoxTransposeMatrixAEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxTransposeMatrixAEnabled.Size = new System.Drawing.Size(80, 17);
            this.checkBoxTransposeMatrixAEnabled.TabIndex = 8;
            this.checkBoxTransposeMatrixAEnabled.Text = "Матриця А";
            this.checkBoxTransposeMatrixAEnabled.UseVisualStyleBackColor = true;
            // 
            // buttonTransposeMatrix
            // 
            this.buttonTransposeMatrix.BackColor = System.Drawing.Color.Green;
            this.buttonTransposeMatrix.Enabled = false;
            this.buttonTransposeMatrix.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTransposeMatrix.Location = new System.Drawing.Point(6, 42);
            this.buttonTransposeMatrix.Name = "buttonTransposeMatrix";
            this.buttonTransposeMatrix.Size = new System.Drawing.Size(318, 31);
            this.buttonTransposeMatrix.TabIndex = 10;
            this.buttonTransposeMatrix.Text = "Транспонувати матриці";
            this.buttonTransposeMatrix.UseVisualStyleBackColor = false;
            this.buttonTransposeMatrix.Click += new System.EventHandler(this.buttonTransposeMatrix_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonMultiplyMatrix);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(327, 51);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Множення матриць";
            // 
            // buttonMultiplyMatrix
            // 
            this.buttonMultiplyMatrix.BackColor = System.Drawing.Color.Green;
            this.buttonMultiplyMatrix.Enabled = false;
            this.buttonMultiplyMatrix.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMultiplyMatrix.Location = new System.Drawing.Point(6, 14);
            this.buttonMultiplyMatrix.Name = "buttonMultiplyMatrix";
            this.buttonMultiplyMatrix.Size = new System.Drawing.Size(318, 31);
            this.buttonMultiplyMatrix.TabIndex = 9;
            this.buttonMultiplyMatrix.Text = "Перемножити матриці";
            this.buttonMultiplyMatrix.UseVisualStyleBackColor = false;
            this.buttonMultiplyMatrix.Click += new System.EventHandler(this.buttonMultiplyMatrix_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddMatrix);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(327, 51);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додавання матриць";
            // 
            // buttonAddMatrix
            // 
            this.buttonAddMatrix.BackColor = System.Drawing.Color.Green;
            this.buttonAddMatrix.Enabled = false;
            this.buttonAddMatrix.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddMatrix.Location = new System.Drawing.Point(6, 14);
            this.buttonAddMatrix.Name = "buttonAddMatrix";
            this.buttonAddMatrix.Size = new System.Drawing.Size(318, 31);
            this.buttonAddMatrix.TabIndex = 8;
            this.buttonAddMatrix.Text = "Додати матриці";
            this.buttonAddMatrix.UseVisualStyleBackColor = false;
            this.buttonAddMatrix.Click += new System.EventHandler(this.buttonAddMatrix_Click);
            // 
            // groupBoxMatrixCreate
            // 
            this.groupBoxMatrixCreate.Controls.Add(this.buttonGenerateMatrix);
            this.groupBoxMatrixCreate.Controls.Add(this.checkBoxRandomFilling);
            this.groupBoxMatrixCreate.Controls.Add(this.groupBoxMatrixBSettings);
            this.groupBoxMatrixCreate.Controls.Add(this.groupBoxMatrixASettings);
            this.groupBoxMatrixCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMatrixCreate.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMatrixCreate.Name = "groupBoxMatrixCreate";
            this.groupBoxMatrixCreate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBoxMatrixCreate.Size = new System.Drawing.Size(333, 235);
            this.groupBoxMatrixCreate.TabIndex = 0;
            this.groupBoxMatrixCreate.TabStop = false;
            this.groupBoxMatrixCreate.Text = "Створення матриць";
            // 
            // buttonGenerateMatrix
            // 
            this.buttonGenerateMatrix.BackColor = System.Drawing.Color.Green;
            this.buttonGenerateMatrix.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGenerateMatrix.Location = new System.Drawing.Point(9, 199);
            this.buttonGenerateMatrix.Name = "buttonGenerateMatrix";
            this.buttonGenerateMatrix.Size = new System.Drawing.Size(318, 31);
            this.buttonGenerateMatrix.TabIndex = 7;
            this.buttonGenerateMatrix.Text = "Згенерувати";
            this.buttonGenerateMatrix.UseVisualStyleBackColor = false;
            this.buttonGenerateMatrix.Click += new System.EventHandler(this.buttonGenerateMatrix_Click);
            // 
            // checkBoxRandomFilling
            // 
            this.checkBoxRandomFilling.AutoSize = true;
            this.checkBoxRandomFilling.Location = new System.Drawing.Point(9, 175);
            this.checkBoxRandomFilling.Name = "checkBoxRandomFilling";
            this.checkBoxRandomFilling.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxRandomFilling.Size = new System.Drawing.Size(250, 17);
            this.checkBoxRandomFilling.TabIndex = 6;
            this.checkBoxRandomFilling.Text = "Автоматично генерувати значення  матриці.";
            this.checkBoxRandomFilling.UseVisualStyleBackColor = true;
            // 
            // groupBoxMatrixBSettings
            // 
            this.groupBoxMatrixBSettings.Controls.Add(this.numericUpDownMatrixBColumnNumber);
            this.groupBoxMatrixBSettings.Controls.Add(this.label4);
            this.groupBoxMatrixBSettings.Controls.Add(this.numericUpDownMatrixBRowNumber);
            this.groupBoxMatrixBSettings.Controls.Add(this.label3);
            this.groupBoxMatrixBSettings.Controls.Add(this.checkBoxMatrixBEnabled);
            this.groupBoxMatrixBSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMatrixBSettings.Location = new System.Drawing.Point(3, 84);
            this.groupBoxMatrixBSettings.Name = "groupBoxMatrixBSettings";
            this.groupBoxMatrixBSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxMatrixBSettings.Size = new System.Drawing.Size(327, 85);
            this.groupBoxMatrixBSettings.TabIndex = 1;
            this.groupBoxMatrixBSettings.TabStop = false;
            this.groupBoxMatrixBSettings.Text = "Налаштування матриці B";
            // 
            // numericUpDownMatrixBColumnNumber
            // 
            this.numericUpDownMatrixBColumnNumber.Enabled = false;
            this.numericUpDownMatrixBColumnNumber.Location = new System.Drawing.Point(125, 58);
            this.numericUpDownMatrixBColumnNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMatrixBColumnNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMatrixBColumnNumber.Name = "numericUpDownMatrixBColumnNumber";
            this.numericUpDownMatrixBColumnNumber.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownMatrixBColumnNumber.TabIndex = 5;
            this.numericUpDownMatrixBColumnNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кількість стовпців :";
            // 
            // numericUpDownMatrixBRowNumber
            // 
            this.numericUpDownMatrixBRowNumber.Enabled = false;
            this.numericUpDownMatrixBRowNumber.Location = new System.Drawing.Point(125, 37);
            this.numericUpDownMatrixBRowNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMatrixBRowNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMatrixBRowNumber.Name = "numericUpDownMatrixBRowNumber";
            this.numericUpDownMatrixBRowNumber.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownMatrixBRowNumber.TabIndex = 4;
            this.numericUpDownMatrixBRowNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Кількість рядків :";
            // 
            // checkBoxMatrixBEnabled
            // 
            this.checkBoxMatrixBEnabled.AutoSize = true;
            this.checkBoxMatrixBEnabled.Location = new System.Drawing.Point(6, 19);
            this.checkBoxMatrixBEnabled.Name = "checkBoxMatrixBEnabled";
            this.checkBoxMatrixBEnabled.Size = new System.Drawing.Size(175, 17);
            this.checkBoxMatrixBEnabled.TabIndex = 0;
            this.checkBoxMatrixBEnabled.Text = "Використовувати матрицю B.";
            this.checkBoxMatrixBEnabled.UseVisualStyleBackColor = true;
            this.checkBoxMatrixBEnabled.CheckedChanged += new System.EventHandler(this.checkBoxMatrixBEnabled_CheckedChanged);
            // 
            // groupBoxMatrixASettings
            // 
            this.groupBoxMatrixASettings.Controls.Add(this.numericUpDownMatrixAColumnNumber);
            this.groupBoxMatrixASettings.Controls.Add(this.label2);
            this.groupBoxMatrixASettings.Controls.Add(this.numericUpDownMatrixARowNumber);
            this.groupBoxMatrixASettings.Controls.Add(this.label1);
            this.groupBoxMatrixASettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMatrixASettings.Location = new System.Drawing.Point(3, 16);
            this.groupBoxMatrixASettings.Name = "groupBoxMatrixASettings";
            this.groupBoxMatrixASettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxMatrixASettings.Size = new System.Drawing.Size(327, 68);
            this.groupBoxMatrixASettings.TabIndex = 0;
            this.groupBoxMatrixASettings.TabStop = false;
            this.groupBoxMatrixASettings.Text = "Налаштування матриці A";
            // 
            // numericUpDownMatrixAColumnNumber
            // 
            this.numericUpDownMatrixAColumnNumber.Location = new System.Drawing.Point(125, 39);
            this.numericUpDownMatrixAColumnNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMatrixAColumnNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMatrixAColumnNumber.Name = "numericUpDownMatrixAColumnNumber";
            this.numericUpDownMatrixAColumnNumber.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownMatrixAColumnNumber.TabIndex = 3;
            this.numericUpDownMatrixAColumnNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість стовпців :";
            // 
            // numericUpDownMatrixARowNumber
            // 
            this.numericUpDownMatrixARowNumber.Location = new System.Drawing.Point(125, 18);
            this.numericUpDownMatrixARowNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMatrixARowNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMatrixARowNumber.Name = "numericUpDownMatrixARowNumber";
            this.numericUpDownMatrixARowNumber.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownMatrixARowNumber.TabIndex = 1;
            this.numericUpDownMatrixARowNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість рядків :";
            // 
            // panelRegistration
            // 
            this.panelRegistration.Controls.Add(this.buttonRegister);
            this.panelRegistration.Controls.Add(this.buttonUserInformation);
            this.panelRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistration.Location = new System.Drawing.Point(475, 0);
            this.panelRegistration.Name = "panelRegistration";
            this.panelRegistration.Size = new System.Drawing.Size(333, 39);
            this.panelRegistration.TabIndex = 0;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.White;
            this.buttonRegister.BackgroundImage = global::MatrixCalculator.Properties.Resources.icons8_добавить_пользователя_64;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRegister.Location = new System.Drawing.Point(291, 3);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(33, 32);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonUserInformation
            // 
            this.buttonUserInformation.BackColor = System.Drawing.Color.Red;
            this.buttonUserInformation.BackgroundImage = global::MatrixCalculator.Properties.Resources.icons8_пользователь_мужчина_в_кружке_48;
            this.buttonUserInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUserInformation.Location = new System.Drawing.Point(252, 3);
            this.buttonUserInformation.Name = "buttonUserInformation";
            this.buttonUserInformation.Size = new System.Drawing.Size(33, 32);
            this.buttonUserInformation.TabIndex = 0;
            this.buttonUserInformation.UseVisualStyleBackColor = false;
            this.buttonUserInformation.Click += new System.EventHandler(this.buttonUserInformation_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 634);
            this.Controls.Add(this.panelRegistration);
            this.Controls.Add(this.panelMatrixFunctions);
            this.Controls.Add(this.panelMatrixAandB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор для обробки матриць";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panelMatrixAandB.ResumeLayout(false);
            this.groupBoxMatrixB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrixB)).EndInit();
            this.groupBoxMatrixA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrixA)).EndInit();
            this.panelMatrixFunctions.ResumeLayout(false);
            this.groupBoxMatrixOperations.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxMatrixCreate.ResumeLayout(false);
            this.groupBoxMatrixCreate.PerformLayout();
            this.groupBoxMatrixBSettings.ResumeLayout(false);
            this.groupBoxMatrixBSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrixBColumnNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrixBRowNumber)).EndInit();
            this.groupBoxMatrixASettings.ResumeLayout(false);
            this.groupBoxMatrixASettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrixAColumnNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMatrixARowNumber)).EndInit();
            this.panelRegistration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMatrixAandB;
        private System.Windows.Forms.Panel panelMatrixFunctions;
        private System.Windows.Forms.Panel panelRegistration;
        private System.Windows.Forms.GroupBox groupBoxMatrixB;
        private System.Windows.Forms.DataGridView dataGridMatrixB;
        private System.Windows.Forms.GroupBox groupBoxMatrixA;
        private System.Windows.Forms.DataGridView dataGridMatrixA;
        private System.Windows.Forms.GroupBox groupBoxMatrixCreate;
        private System.Windows.Forms.GroupBox groupBoxMatrixASettings;
        private System.Windows.Forms.NumericUpDown numericUpDownMatrixARowNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMatrixAColumnNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxMatrixBSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownMatrixBRowNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxMatrixBEnabled;
        private System.Windows.Forms.NumericUpDown numericUpDownMatrixBColumnNumber;
        private System.Windows.Forms.Button buttonGenerateMatrix;
        private System.Windows.Forms.CheckBox checkBoxRandomFilling;
        private System.Windows.Forms.GroupBox groupBoxMatrixOperations;
        private System.Windows.Forms.Button buttonAddMatrix;
        private System.Windows.Forms.Button buttonMultiplyMatrix;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxTransposeMatrixBEnabled;
        private System.Windows.Forms.CheckBox checkBoxTransposeMatrixAEnabled;
        private System.Windows.Forms.Button buttonTransposeMatrix;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonDeterminantMatrix;
        private System.Windows.Forms.CheckBox checkBoxDeterminantMatrixB;
        private System.Windows.Forms.CheckBox checkBoxDeterminantMatrixA;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonInverseMatrix;
        private System.Windows.Forms.CheckBox checkBoxInverseMatrixB;
        private System.Windows.Forms.CheckBox checkBoxInverseMatrixA;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonUserInformation;
    }
}

