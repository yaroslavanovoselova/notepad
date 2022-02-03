
namespace Notepad__Peer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GetLastVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.italicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlinedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikedOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.AutoFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSavingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer5SecMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer10SecMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer30SecMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1MinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2MinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startCopyingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyEvery30SecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyEvery1MinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyEvery2MinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyEvery5MinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyEvery10MinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OffCopyingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerForAutoSaving = new System.Windows.Forms.Timer(this.components);
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllContextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.copyContextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.cutContextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.styleContextTool = new System.Windows.Forms.ToolStripMenuItem();
            this.timerForMakingCopies = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1013, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newInNewWindowToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.GetLastVersionToolStripMenuItem,
            this.toolStripSeparator10,
            this.closeToolStripMenuItem,
            this.closeFormToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.newToolStripMenuItem.Text = "&Новый";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.New_CLick);
            // 
            // newInNewWindowToolStripMenuItem
            // 
            this.newInNewWindowToolStripMenuItem.Name = "newInNewWindowToolStripMenuItem";
            this.newInNewWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.newInNewWindowToolStripMenuItem.Text = "&Создать в новом окне";
            this.newInNewWindowToolStripMenuItem.Click += new System.EventHandler(this.NewInNewWindow_CLick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.openToolStripMenuItem.Text = "&Открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.Open_CLick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(356, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.saveToolStripMenuItem.Text = "&Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save_CLick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.saveAsToolStripMenuItem.Text = "&Сохранить как...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAs_CLick);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.saveAllToolStripMenuItem.Text = "&Сохранить все";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.SaveAll_CLick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(356, 6);
            // 
            // GetLastVersionToolStripMenuItem
            // 
            this.GetLastVersionToolStripMenuItem.Name = "GetLastVersionToolStripMenuItem";
            this.GetLastVersionToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.GetLastVersionToolStripMenuItem.Text = "&Загрузить предыдущую версию файла";
            this.GetLastVersionToolStripMenuItem.Click += new System.EventHandler(this.GetLastVersion_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(356, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.closeToolStripMenuItem.Text = "&Закрыть вкладку";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseTab_CLick);
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(359, 26);
            this.closeFormToolStripMenuItem.Text = "&Закрыть приложение";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.CLoseForm_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.repeatToolStripMenuItem,
            this.toolStripSeparator5,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator6,
            this.selectAllToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.editToolStripMenuItem.Text = "&Правка";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.cancelToolStripMenuItem.Text = "&Отменить";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.Undo_Click);
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.repeatToolStripMenuItem.Text = "Повторить";
            this.repeatToolStripMenuItem.Click += new System.EventHandler(this.Redo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(263, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.cutToolStripMenuItem.Text = "&Вырезать";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.Cut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.copyToolStripMenuItem.Text = "&Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.pasteToolStripMenuItem.Text = "&Вставить";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.Paste_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(263, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            this.selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            this.selectAllToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem1.Size = new System.Drawing.Size(266, 26);
            this.selectAllToolStripMenuItem1.Text = "Выделить все";
            this.selectAllToolStripMenuItem1.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.toolStripSeparator4,
            this.italicsToolStripMenuItem,
            this.boldToolStripMenuItem,
            this.underlinedToolStripMenuItem,
            this.strikedOutToolStripMenuItem,
            this.toolStripSeparator9,
            this.AutoFormatToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.formatToolStripMenuItem.Text = "&Формат";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(419, 26);
            this.fontToolStripMenuItem.Text = "&Шрифт...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.Font_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(416, 6);
            // 
            // italicsToolStripMenuItem
            // 
            this.italicsToolStripMenuItem.Name = "italicsToolStripMenuItem";
            this.italicsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicsToolStripMenuItem.Size = new System.Drawing.Size(419, 26);
            this.italicsToolStripMenuItem.Text = "&Курсив";
            this.italicsToolStripMenuItem.Click += new System.EventHandler(this.Italic_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(419, 26);
            this.boldToolStripMenuItem.Text = "&Жирный";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.Bold_Click);
            // 
            // underlinedToolStripMenuItem
            // 
            this.underlinedToolStripMenuItem.Name = "underlinedToolStripMenuItem";
            this.underlinedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlinedToolStripMenuItem.Size = new System.Drawing.Size(419, 26);
            this.underlinedToolStripMenuItem.Text = "&Подчеркнутый";
            this.underlinedToolStripMenuItem.Click += new System.EventHandler(this.Underline_Click);
            // 
            // strikedOutToolStripMenuItem
            // 
            this.strikedOutToolStripMenuItem.Name = "strikedOutToolStripMenuItem";
            this.strikedOutToolStripMenuItem.Size = new System.Drawing.Size(419, 26);
            this.strikedOutToolStripMenuItem.Text = "&Зачеркнутый";
            this.strikedOutToolStripMenuItem.Click += new System.EventHandler(this.StrikeOut_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(416, 6);
            // 
            // AutoFormatToolStripMenuItem
            // 
            this.AutoFormatToolStripMenuItem.Name = "AutoFormatToolStripMenuItem";
            this.AutoFormatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.AutoFormatToolStripMenuItem.Size = new System.Drawing.Size(419, 26);
            this.AutoFormatToolStripMenuItem.Text = "Автоматическое форматирование кода";
            this.AutoFormatToolStripMenuItem.Click += new System.EventHandler(this.AutoFormat_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoSavingToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.startCopyingToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.settingsToolStripMenuItem.Text = "&Настройки";
            // 
            // autoSavingToolStripMenuItem
            // 
            this.autoSavingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timer5SecMenuItem,
            this.timer10SecMenuItem,
            this.timer30SecMenuItem,
            this.timer1MinMenuItem,
            this.timer2MinMenuItem,
            this.offTimerToolStripMenuItem});
            this.autoSavingToolStripMenuItem.Name = "autoSavingToolStripMenuItem";
            this.autoSavingToolStripMenuItem.Size = new System.Drawing.Size(356, 26);
            this.autoSavingToolStripMenuItem.Text = "&Частота автоматического сохранения";
            // 
            // timer5SecMenuItem
            // 
            this.timer5SecMenuItem.Name = "timer5SecMenuItem";
            this.timer5SecMenuItem.Size = new System.Drawing.Size(170, 26);
            this.timer5SecMenuItem.Text = "5 сек";
            this.timer5SecMenuItem.Click += new System.EventHandler(this.Timer5Sec_Click);
            // 
            // timer10SecMenuItem
            // 
            this.timer10SecMenuItem.Name = "timer10SecMenuItem";
            this.timer10SecMenuItem.Size = new System.Drawing.Size(170, 26);
            this.timer10SecMenuItem.Text = "10 сек";
            this.timer10SecMenuItem.Click += new System.EventHandler(this.Timer10Sec_Click);
            // 
            // timer30SecMenuItem
            // 
            this.timer30SecMenuItem.Name = "timer30SecMenuItem";
            this.timer30SecMenuItem.Size = new System.Drawing.Size(170, 26);
            this.timer30SecMenuItem.Text = "30 сек";
            this.timer30SecMenuItem.Click += new System.EventHandler(this.Timer30Sec_Click);
            // 
            // timer1MinMenuItem
            // 
            this.timer1MinMenuItem.Name = "timer1MinMenuItem";
            this.timer1MinMenuItem.Size = new System.Drawing.Size(170, 26);
            this.timer1MinMenuItem.Text = "1 мин";
            this.timer1MinMenuItem.Click += new System.EventHandler(this.Timer1Min_Click);
            // 
            // timer2MinMenuItem
            // 
            this.timer2MinMenuItem.Name = "timer2MinMenuItem";
            this.timer2MinMenuItem.Size = new System.Drawing.Size(170, 26);
            this.timer2MinMenuItem.Text = "2 мин";
            this.timer2MinMenuItem.Click += new System.EventHandler(this.Timer2Min_Click);
            // 
            // offTimerToolStripMenuItem
            // 
            this.offTimerToolStripMenuItem.Name = "offTimerToolStripMenuItem";
            this.offTimerToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.offTimerToolStripMenuItem.Text = "Выключить";
            this.offTimerToolStripMenuItem.Click += new System.EventHandler(this.TimerOff_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightThemeToolStripMenuItem,
            this.darkThemeToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(356, 26);
            this.themeToolStripMenuItem.Text = "&Цветовая схема";
            // 
            // lightThemeToolStripMenuItem
            // 
            this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.lightThemeToolStripMenuItem.Text = "Светлая";
            this.lightThemeToolStripMenuItem.Click += new System.EventHandler(this.LightTheme_CLick);
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.darkThemeToolStripMenuItem.Text = "Темная";
            this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.DarkTheme_CLick);
            // 
            // startCopyingToolStripMenuItem
            // 
            this.startCopyingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyEvery30SecToolStripMenuItem,
            this.CopyEvery1MinToolStripMenuItem,
            this.CopyEvery2MinToolStripMenuItem,
            this.CopyEvery5MinToolStripMenuItem,
            this.CopyEvery10MinToolStripMenuItem,
            this.OffCopyingToolStripMenuItem});
            this.startCopyingToolStripMenuItem.Name = "startCopyingToolStripMenuItem";
            this.startCopyingToolStripMenuItem.Size = new System.Drawing.Size(356, 26);
            this.startCopyingToolStripMenuItem.Text = "Частота журналирования";
            // 
            // CopyEvery30SecToolStripMenuItem
            // 
            this.CopyEvery30SecToolStripMenuItem.Name = "CopyEvery30SecToolStripMenuItem";
            this.CopyEvery30SecToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.CopyEvery30SecToolStripMenuItem.Text = "30 сек";
            this.CopyEvery30SecToolStripMenuItem.Click += new System.EventHandler(this.CopyEvery30Sec_Click);
            // 
            // CopyEvery1MinToolStripMenuItem
            // 
            this.CopyEvery1MinToolStripMenuItem.Name = "CopyEvery1MinToolStripMenuItem";
            this.CopyEvery1MinToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.CopyEvery1MinToolStripMenuItem.Text = "1 мин";
            this.CopyEvery1MinToolStripMenuItem.Click += new System.EventHandler(this.CopyEvery1Min_Click);
            // 
            // CopyEvery2MinToolStripMenuItem
            // 
            this.CopyEvery2MinToolStripMenuItem.Name = "CopyEvery2MinToolStripMenuItem";
            this.CopyEvery2MinToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.CopyEvery2MinToolStripMenuItem.Text = "2 мин";
            this.CopyEvery2MinToolStripMenuItem.Click += new System.EventHandler(this.CopyEvery2Min_Click);
            // 
            // CopyEvery5MinToolStripMenuItem
            // 
            this.CopyEvery5MinToolStripMenuItem.Name = "CopyEvery5MinToolStripMenuItem";
            this.CopyEvery5MinToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.CopyEvery5MinToolStripMenuItem.Text = "5 мин";
            this.CopyEvery5MinToolStripMenuItem.Click += new System.EventHandler(this.CopyEvery5Min_Click);
            // 
            // CopyEvery10MinToolStripMenuItem
            // 
            this.CopyEvery10MinToolStripMenuItem.Name = "CopyEvery10MinToolStripMenuItem";
            this.CopyEvery10MinToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.CopyEvery10MinToolStripMenuItem.Text = "10 мин";
            this.CopyEvery10MinToolStripMenuItem.Click += new System.EventHandler(this.CopyEvery10Min_Click);
            // 
            // OffCopyingToolStripMenuItem
            // 
            this.OffCopyingToolStripMenuItem.Name = "OffCopyingToolStripMenuItem";
            this.OffCopyingToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.OffCopyingToolStripMenuItem.Text = "Выключить";
            this.OffCopyingToolStripMenuItem.Click += new System.EventHandler(this.CopyOff_Click);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1013, 573);
            this.tabControl.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // timerForAutoSaving
            // 
            this.timerForAutoSaving.Tick += new System.EventHandler(this.timerForAutoSaving_Tick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllContextTool,
            this.toolStripSeparator7,
            this.copyContextTool,
            this.cutContextTool,
            this.pasteContextTool,
            this.toolStripSeparator8,
            this.styleContextTool});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(198, 136);
            // 
            // selectAllContextTool
            // 
            this.selectAllContextTool.Name = "selectAllContextTool";
            this.selectAllContextTool.Size = new System.Drawing.Size(197, 24);
            this.selectAllContextTool.Text = "Выделить все";
            this.selectAllContextTool.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(194, 6);
            // 
            // copyContextTool
            // 
            this.copyContextTool.Name = "copyContextTool";
            this.copyContextTool.Size = new System.Drawing.Size(197, 24);
            this.copyContextTool.Text = "Копировать";
            this.copyContextTool.Click += new System.EventHandler(this.Copy_Click);
            // 
            // cutContextTool
            // 
            this.cutContextTool.Name = "cutContextTool";
            this.cutContextTool.Size = new System.Drawing.Size(197, 24);
            this.cutContextTool.Text = "Вырезать";
            this.cutContextTool.Click += new System.EventHandler(this.Cut_Click);
            // 
            // pasteContextTool
            // 
            this.pasteContextTool.Name = "pasteContextTool";
            this.pasteContextTool.Size = new System.Drawing.Size(197, 24);
            this.pasteContextTool.Text = "Вставить";
            this.pasteContextTool.Click += new System.EventHandler(this.Paste_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(194, 6);
            // 
            // styleContextTool
            // 
            this.styleContextTool.Name = "styleContextTool";
            this.styleContextTool.Size = new System.Drawing.Size(197, 24);
            this.styleContextTool.Text = "Выбрать шрифт...";
            this.styleContextTool.Click += new System.EventHandler(this.Font_Click);
            // 
            // timerForMakingCopies
            // 
            this.timerForMakingCopies.Tick += new System.EventHandler(this.timerForMakingCopies_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 601);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem autoSavingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timer5SecMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timer10SecMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timer30SecMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timer1MinMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timer2MinMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.Timer timerForAutoSaving;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem italicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlinedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strikedOutToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectAllContextTool;
        private System.Windows.Forms.ToolStripMenuItem copyContextTool;
        private System.Windows.Forms.ToolStripMenuItem cutContextTool;
        private System.Windows.Forms.ToolStripMenuItem pasteContextTool;
        private System.Windows.Forms.ToolStripMenuItem styleContextTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem newInNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem AutoFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GetLastVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem startCopyingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyEvery30SecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyEvery1MinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyEvery2MinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyEvery5MinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyEvery10MinToolStripMenuItem;
        private System.Windows.Forms.Timer timerForMakingCopies;
        private System.Windows.Forms.ToolStripMenuItem OffCopyingToolStripMenuItem;
    }
}

