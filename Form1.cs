using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Notepad__Peer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Восстанавливаем раннее выбранные настройки (интервал автоматического сохранения и цветовую схему).
            if (Properties.Settings.Default.TimerIntertval == 0)
                timerForAutoSaving.Enabled = false;
            else
            {
                timerForAutoSaving.Interval = Properties.Settings.Default.TimerIntertval;
                timerForAutoSaving.Enabled = true;
            }
            if (Properties.Settings.Default.CopyingInterval == 0)
                timerForMakingCopies.Enabled = false;
            else
            {
                timerForMakingCopies.Interval = Properties.Settings.Default.CopyingInterval;
                timerForMakingCopies.Enabled = true;
            }
            if (Properties.Settings.Default.LightTheme)
                MakeLightTheme();
            else
                MakeDarkTheme();
            // Восстанавливаем раннее открытые файлы.
            if (Properties.Settings.Default.ListOfPaths != null)
            {
                foreach (var path in Properties.Settings.Default.ListOfPaths)
                {
                    if (File.Exists(path))
                    {
                        var newTab = new TabPage($"{Path.GetFileName(path)}");
                        newTab.Name = path;
                        // Открытие cs файлов.
                        if (path.EndsWith(".cs"))
                        {
                            // Для cs файлов используем FastColoredTextBox.
                            var fctb = new FastColoredTextBoxNS.FastColoredTextBox();
                            fctb.Dock = DockStyle.Fill;
                            newTab.Controls.Add(fctb);
                            tabControl.TabPages.Add(newTab);
                            tabControl.SelectedTab = newTab;
                            // Подсветка синтаксиса кода.
                            GetFastColoredTextBox().Language = FastColoredTextBoxNS.Language.CSharp;
                            GetFastColoredTextBox().Text = File.ReadAllText(path);

                        }
                        // Открытие rtf и txt файлов.
                        else
                        {
                            // Для rtf и txt файлов используем RichTextBox.
                            var richTextBox = new RichTextBox();
                            richTextBox.Dock = DockStyle.Fill;
                            newTab.Controls.Add(richTextBox);
                            tabControl.TabPages.Add(newTab);
                            tabControl.SelectedTab = newTab;
                            if (path.EndsWith(".rtf"))
                                GetRichTextBox().LoadFile(path);
                            else
                            {
                                string fileText = File.ReadAllText(path);
                                GetRichTextBox().Text = fileText;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Определение активного RichTextBox и добавление необходимых параметров.
        /// </summary>
        /// <returns> RichTextBox из открытой вкладки. </returns>
        RichTextBox GetRichTextBox()
        {
            var selectedTab = tabControl.SelectedTab;
            // Проверям, что есть открытые вкладки.
            if (selectedTab != null)
            {
                RichTextBox rtb = selectedTab.Controls[0] as RichTextBox;
                // Добавляем контекстное меню.
                rtb.ContextMenuStrip = contextMenuStrip;
                // Устанавливаем цвета в зависимости от выбранной темы.
                if (themeIsLight)
                {
                    rtb.BackColor = SystemColors.Control;
                    rtb.ForeColor = SystemColors.ControlText;
                }
                else
                {
                    rtb.ForeColor = SystemColors.Window;
                    rtb.BackColor = SystemColors.WindowFrame;
                }
                return rtb;
            }
            return null;
        }

        /// <summary>
        /// Определение активного FastColoredTextBox и добавление необходимых параметров.
        /// </summary>
        /// <returns> FastColoredTextBox из открытой вкладки. </returns>
        FastColoredTextBoxNS.FastColoredTextBox GetFastColoredTextBox()
        {
            // Здесь все аналогично методу GetRichTextBox().
            // FastColoredTextBox нужен для автоматического форматирования кода и подсветки синтаксиса (эти методы встроены в него).
            var selectedTab = tabControl.SelectedTab;
            if (selectedTab != null)
            {
                FastColoredTextBoxNS.FastColoredTextBox fctb = selectedTab.Controls[0] as FastColoredTextBoxNS.FastColoredTextBox;
                fctb.ContextMenuStrip = contextMenuStrip;
                if (themeIsLight)
                {
                    fctb.BackColor = SystemColors.Control;
                    fctb.ForeColor = SystemColors.ControlText;
                }
                else
                {
                    fctb.ForeColor = SystemColors.Window;
                    fctb.BackColor = SystemColors.WindowFrame;
                }
                return fctb;
            }

            return null;
        }

        /// <summary>
        /// Счетчик созданных новых файлов. 
        /// </summary>
        int newDocumentCounter = 1;

        /// <summary>
        /// Создание нового файла с расширением txt в новой вкладке.
        /// </summary>
        private void New_CLick(object sender, EventArgs e)
        {
            // Создание новой вкладки.
            var newTab = new TabPage($"Новый документ {newDocumentCounter++}");
            // Создание нового RichTextBox и установление его свойств.
            var richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ContextMenuStrip = contextMenuStrip;
            if (themeIsLight)
            {
                richTextBox.BackColor = SystemColors.Control;
                richTextBox.ForeColor = SystemColors.ControlText;
            }
            else
            {
                richTextBox.ForeColor = SystemColors.Window;
                richTextBox.BackColor = SystemColors.WindowFrame;
            }
            // Добавление RichTextBox на вкладку.
            newTab.Controls.Add(richTextBox);
            tabControl.TabPages.Add(newTab);
        }

        /// <summary>
        /// Создание нового файла в новом окне (форме).
        /// </summary>
        private void NewInNewWindow_CLick(object sender, EventArgs e)
        {
            // Создание новой формы.
            var newForm = new Form1();
            newForm.Show();
            // Далее аналогично методу New_CLick(object sender, EventArgs e).
            var newTab = new TabPage($"Новый документ {newDocumentCounter++}");
            var richTextBox = new RichTextBox();
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.ContextMenuStrip = contextMenuStrip;
            if (themeIsLight)
            {
                richTextBox.BackColor = SystemColors.Control;
                richTextBox.ForeColor = SystemColors.ControlText;
            }
            else
            {
                richTextBox.ForeColor = SystemColors.Window;
                richTextBox.BackColor = SystemColors.WindowFrame;
            }
            newTab.Controls.Add(richTextBox);
            newForm.tabControl.TabPages.Add(newTab);
        }

        /// <summary>
        /// Открытие файла.
        /// </summary>
        private void Open_CLick(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = openFileDialog.FileName;
                // Создаем вкладку.
                var newTab = new TabPage($"{Path.GetFileName(filename)}");
                // В свойстве вкладки Name хранится путь к файлу.
                newTab.Name = filename;
                // Открытие cs файлов в FastColoredTextBox.
                if (filename.EndsWith(".cs"))
                {
                    var fctb = new FastColoredTextBoxNS.FastColoredTextBox();
                    fctb.Dock = DockStyle.Fill;
                    newTab.Controls.Add(fctb);
                    tabControl.TabPages.Add(newTab);
                    tabControl.SelectedTab = newTab;
                    GetFastColoredTextBox().Language = FastColoredTextBoxNS.Language.CSharp;
                    GetFastColoredTextBox().Text = File.ReadAllText(filename);
                }
                // Открытие rtf и txt файлов в RichTextBox.
                else
                {
                    var richTextBox = new RichTextBox();
                    richTextBox.Dock = DockStyle.Fill;
                    newTab.Controls.Add(richTextBox);
                    tabControl.TabPages.Add(newTab);
                    tabControl.SelectedTab = newTab;
                    if (filename.EndsWith(".rtf"))
                        GetRichTextBox().LoadFile(filename);
                    else
                    {
                        string fileText = File.ReadAllText(filename);
                        GetRichTextBox().Text = fileText;
                    }
                }
            }
            catch (Exception ex)
            {
                // Удаляем созданную вкладку.
                tabControl.TabPages.Remove(tabControl.SelectedTab);
                MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Сохранение файла.
        /// </summary>
        private void Save_CLick(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что открыт хотя бы один файл.
                if (tabControl.SelectedTab != null)
                {
                    // Проверка, что файл был раннее сохранен (в свойстве Name хранится путь к файлу).
                    if (tabControl.SelectedTab.Name == "")
                        SaveAs_CLick(sender, e);
                    else
                    {
                        var path = tabControl.SelectedTab.Name;
                        if (path.EndsWith(".rtf"))
                            GetRichTextBox().SaveFile(path);
                        else if (path.EndsWith(".cs"))
                            File.WriteAllText(path, GetFastColoredTextBox().Text);
                        else
                            File.WriteAllText(path, GetRichTextBox().Text);
                    }
                }
                else
                {
                    MessageBox.Show("Вы пока не открыли/создали ни один файл, поэтому нам нечего сохранять.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Сохранение файла как.
        /// </summary>
        private void SaveAs_CLick(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab != null)
                {
                    // Предоставляем возможность сохранить файл только в том расширении, в котором он был изначально.
                    if (tabControl.SelectedTab.Text.EndsWith("cs"))
                        saveFileDialog.Filter = "C# Source File |*.cs";
                    else if (tabControl.SelectedTab.Text.EndsWith("rtf"))
                        saveFileDialog.Filter = "RTF files |*.rtf";
                    else
                        saveFileDialog.Filter = "Текстовые файлы(*.txt)| *.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                        return;
                    string filename = saveFileDialog.FileName;
                    // Сохранение файлов.
                    if (filename.EndsWith("rtf"))
                        GetRichTextBox().SaveFile(filename);
                    else if (filename.EndsWith("cs"))
                        File.WriteAllText(filename, GetFastColoredTextBox().Text);
                    else
                    {
                        File.WriteAllText(filename, GetRichTextBox().Text);
                    }
                    tabControl.SelectedTab.Text = Path.GetFileName(filename);
                    tabControl.SelectedTab.Name = filename;
                }
                else
                {
                    MessageBox.Show("Вы пока не открыли/создали ни один файл, поэтому нам нечего сохранять.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Сохранение всех открытых файлов.
        /// </summary>
        private void SaveAll_CLick(object sender, EventArgs e)
        {
            try
            {
                foreach (TabPage tab in tabControl.TabPages)
                {
                    if (tab != null)
                    {
                        // Если файл "новый", то даем возможность выбрать его путь и сохранить.
                        if (tab.Name == "")
                        {
                            saveFileDialog.Filter = "Текстовые файлы(*.txt)| *.txt";
                            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                                return;
                            string filename = saveFileDialog.FileName;
                            File.WriteAllText(filename, ((RichTextBox)tab.Controls[0]).Text);
                            tab.Text = Path.GetFileName(filename);
                            tab.Name = filename;
                        }
                        else
                        {
                            // Сохраняем файлы.
                            var path = tab.Name;
                            if (path.EndsWith(".rtf"))
                                ((RichTextBox)tab.Controls[0]).SaveFile(path);
                            else if (path.EndsWith(".cs"))
                                File.WriteAllText(path, ((FastColoredTextBoxNS.FastColoredTextBox)tab.Controls[0]).Text);
                            else
                                File.WriteAllText(path, ((RichTextBox)tab.Controls[0]).Text);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Закрытие вкладки.
        /// </summary>
        private void CloseTab_CLick(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab != null)
                {
                    // Флаг показывает нужно ли высвечивать диалоговое окно с вопросом о сохранении.
                    bool flag = false;
                    var filename = tabControl.SelectedTab.Name;
                    // Пустые несохраненные файлы просто удаляем.
                    if (tabControl.SelectedTab.Name == "" && GetRichTextBox().Text != "")
                        flag = true;
                    //Проверяем, есть ли несохраненные изменения.
                    if (File.Exists(tabControl.SelectedTab.Name))
                    {
                        if (tabControl.SelectedTab.Text.EndsWith("rtf"))
                        {
                            var rtb = new RichTextBox();
                            rtb.LoadFile(tabControl.SelectedTab.Name);
                            if (!rtb.Rtf.Equals(GetRichTextBox()))
                                flag = true;
                        }
                        else if (tabControl.SelectedTab.Text.EndsWith("cs"))
                        {
                            if (GetFastColoredTextBox().Text != File.ReadAllText(tabControl.SelectedTab.Name))
                                flag = true;
                        }
                        else
                        {
                            if (GetRichTextBox().Text != File.ReadAllText(tabControl.SelectedTab.Name))
                                flag = true;
                        }
                    }
                    if (flag)
                    {
                        // Показываем MessageBox.
                        var answer = MessageBox.Show($"Вы хотите сохранить изменения в файле {tabControl.SelectedTab.Text}?", Text, MessageBoxButtons.YesNoCancel);
                        // Сохраняем файл при ответе "да".
                        if (answer == DialogResult.Yes)
                        {
                            if (tabControl.SelectedTab.Name == "")
                            {
                                SaveAs_CLick(sender, e);
                                filename = tabControl.SelectedTab.Name;
                            }
                            else
                            {
                                var path = tabControl.SelectedTab.Name;
                                if (path.EndsWith(".rtf"))
                                    GetRichTextBox().SaveFile(path);
                                else if (path.EndsWith(".cs"))
                                    File.WriteAllText(path, GetFastColoredTextBox().Text);
                                else
                                    File.WriteAllText(path, GetRichTextBox().Text);
                            }
                            tabControl.TabPages.Remove(tabControl.SelectedTab);
                        }
                        else if (answer == DialogResult.No)
                            tabControl.TabPages.Remove(tabControl.SelectedTab);
                        if (answer != DialogResult.Cancel)
                        {
                            // Удаляем папку с предыдущими версиями файла.
                            var directoryPath = Path.ChangeExtension(filename, null);
                            if (Directory.Exists(directoryPath))
                                Directory.Delete(directoryPath, true);

                        }

                    }
                    else
                    {
                        tabControl.TabPages.Remove(tabControl.SelectedTab);
                        // Удаляем папку с предыдущими версиями файла.
                        var directoryPath = Path.ChangeExtension(filename, null);
                        if (Directory.Exists(directoryPath))
                            Directory.Delete(directoryPath, true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Автоматическое сохранение каждые 5 секунд.
        /// </summary>
        private void Timer5Sec_Click(object sender, EventArgs e)
        {
            timerForAutoSaving.Interval = 5000;
            // Сохраняем все файлы перед включением таймера.
            SaveAll_CLick(sender, e);
            timerForAutoSaving.Enabled = true;
            // Сохраняем интервал таймера для следущего запуска приложения.
            Properties.Settings.Default.TimerIntertval = 5000;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Автоматическое сохранение каждые 10 секунд.
        /// </summary>
        private void Timer10Sec_Click(object sender, EventArgs e)
        {
            timerForAutoSaving.Interval = 10000;
            SaveAll_CLick(sender, e);
            timerForAutoSaving.Enabled = true;
            // Сохраняем интервал таймера для следущего запуска приложения.
            Properties.Settings.Default.TimerIntertval = 10000;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Автоматическое сохранение каждые 30 секунд.
        /// </summary>
        private void Timer30Sec_Click(object sender, EventArgs e)
        {
            timerForAutoSaving.Interval = 30000;
            SaveAll_CLick(sender, e);
            timerForAutoSaving.Enabled = true;
            // Сохраняем интервал таймера для следущего запуска приложения.
            Properties.Settings.Default.TimerIntertval = 30000;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Автоматическое сохранение каждую минуту.
        /// </summary>
        private void Timer1Min_Click(object sender, EventArgs e)
        {
            timerForAutoSaving.Interval = 60000;
            SaveAll_CLick(sender, e);
            timerForAutoSaving.Enabled = true;
            // Сохраняем интервал таймера для следущего запуска приложения.
            Properties.Settings.Default.TimerIntertval = 60000;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Автоматическое сохранение каждые 2 минуты.
        /// </summary>
        private void Timer2Min_Click(object sender, EventArgs e)
        {
            timerForAutoSaving.Interval = 120000;
            SaveAll_CLick(sender, e);
            timerForAutoSaving.Enabled = true;
            // Сохраняем интервал таймера для следущего запуска приложения.
            Properties.Settings.Default.TimerIntertval = 120000;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Отключение автоматического сохранения.
        /// </summary>
        private void TimerOff_Click(object sender, EventArgs e)
        {
            timerForAutoSaving.Enabled = false;
            // Сохраняем параметр таймера для следущего запуска приложения.
            Properties.Settings.Default.TimerIntertval = 0;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Каждый тик таймера сохраняем все файлы.
        /// </summary>
        private void timerForAutoSaving_Tick(object sender, EventArgs e)
        {
            SaveAll_CLick(sender, e);
        }

        /// <summary>
        /// True - если светлая тема, false - темная.
        /// </summary>
        bool themeIsLight = true;

        /// <summary>
        /// Вызов метода для установки светлой цветовой схемы.
        /// </summary>
        private void LightTheme_CLick(object sender, EventArgs e)
        {
            MakeLightTheme();
        }

        /// <summary>
        /// Установка светлой цветовой схемы.
        /// </summary>
        private void MakeLightTheme()
        {
            themeIsLight = true;
            BackColor = SystemColors.Control;
            ForeColor = SystemColors.ControlText;
            foreach (TabPage tab in tabControl.TabPages)
            {
                if (tab.Name.EndsWith(".cs"))
                {
                    ((FastColoredTextBoxNS.FastColoredTextBox)tab.Controls[0]).BackColor = SystemColors.Control;
                    ((FastColoredTextBoxNS.FastColoredTextBox)tab.Controls[0]).ForeColor = SystemColors.ControlText;
                }
                else
                {

                    ((RichTextBox)tab.Controls[0]).BackColor = SystemColors.Control;
                    ((RichTextBox)tab.Controls[0]).ForeColor = SystemColors.ControlText;
                }
                tab.BackColor = SystemColors.Control;
                tab.ForeColor = SystemColors.ControlText;
            }
            menuStrip.BackColor = SystemColors.ControlLight;
            menuStrip.ForeColor = SystemColors.ControlText;
            // Сохраняем информацию для последующего запуска приложения.
            Properties.Settings.Default.LightTheme = true;
            Properties.Settings.Default.Save();

        }

        /// <summary>
        /// Вызов метода для установки темной цветовой схемы.
        /// </summary>
        private void DarkTheme_CLick(object sender, EventArgs e)
        {
            MakeDarkTheme();
        }

        /// <summary>
        /// Установка темной цветовой схемы.
        /// </summary>
        private void MakeDarkTheme()
        {
            themeIsLight = false;
            ForeColor = SystemColors.Control;
            BackColor = SystemColors.ControlDarkDark;
            foreach (TabPage tab in tabControl.TabPages)
            {
                if (tab.Name.EndsWith(".cs"))
                {
                    ((FastColoredTextBoxNS.FastColoredTextBox)tab.Controls[0]).BackColor = SystemColors.WindowFrame;
                    ((FastColoredTextBoxNS.FastColoredTextBox)tab.Controls[0]).ForeColor = SystemColors.Window;
                }
                else
                {
                    ((RichTextBox)tab.Controls[0]).ForeColor = SystemColors.Window;
                    ((RichTextBox)tab.Controls[0]).BackColor = SystemColors.WindowFrame;
                }
                tab.ForeColor = SystemColors.Control;
                tab.BackColor = SystemColors.ControlDarkDark;
            }
            menuStrip.ForeColor = SystemColors.Control;
            menuStrip.BackColor = SystemColors.ControlDarkDark;
            // Сохраняем информацию для последующего запуска приложения.
            Properties.Settings.Default.LightTheme = false;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Выбор шрифта для выделенного текста.
        /// </summary>
        private void Font_Click(object sender, EventArgs e)
        {
            try
            {
                // В файлах формата cs не меняем шрифт.
                if (tabControl.SelectedTab.Name.EndsWith("cs"))
                {
                    MessageBox.Show("Файлы с расширением \".cs\" нельзя форматировать.");
                    return;
                }
                if (GetRichTextBox().SelectionLength > 0)
                {
                    fontDialog.ShowColor = true;
                    if (fontDialog.ShowDialog() == DialogResult.Cancel)
                        return;
                    GetRichTextBox().SelectionFont = fontDialog.Font;
                    GetRichTextBox().SelectionColor = fontDialog.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Выделение курсивом.
        /// </summary>
        private void Italic_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab.Name.EndsWith("cs"))
                {
                    MessageBox.Show("Файлы с расширением \".cs\" нельзя форматировать.");
                    return;
                }
                if (GetRichTextBox().SelectionLength > 0)
                {
                    var newStyle = GetRichTextBox().SelectionFont.Style ^ FontStyle.Italic;
                    GetRichTextBox().SelectionFont = new Font(GetRichTextBox().SelectionFont, newStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Выделение жирным.
        /// </summary>
        private void Bold_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab.Name.EndsWith("cs"))
                {
                    MessageBox.Show("Файлы с расширением \".cs\" нельзя форматировать.");
                    return;
                }
                if (GetRichTextBox().SelectionLength > 0)
                {
                    var newStyle = GetRichTextBox().SelectionFont.Style ^ FontStyle.Bold;
                    GetRichTextBox().SelectionFont = new Font(GetRichTextBox().SelectionFont, newStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Подчеркивание выделенного фрагмента.
        /// </summary>
        private void Underline_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab.Name.EndsWith("cs"))
                {
                    MessageBox.Show("Файлы с расширением \".cs\" нельзя форматировать.");
                    return;
                }
                if (GetRichTextBox().SelectionLength > 0)
                {
                    var newStyle = GetRichTextBox().SelectionFont.Style ^ FontStyle.Underline;
                    GetRichTextBox().SelectionFont = new Font(GetRichTextBox().SelectionFont, newStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Зачеркивание выделенного фрагмента.
        /// </summary>
        private void StrikeOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab.Name.EndsWith("cs"))
                {
                    MessageBox.Show("Файлы с расширением \".cs\" нельзя форматировать.");
                    return;
                }
                if (GetRichTextBox().SelectionLength > 0)
                {
                    var newStyle = GetRichTextBox().SelectionFont.Style ^ FontStyle.Strikeout;
                    GetRichTextBox().SelectionFont = new Font(GetRichTextBox().SelectionFont, newStyle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Копирование выделенного фрагмента.
        /// </summary>
        private void Copy_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.EndsWith("cs") && GetFastColoredTextBox().SelectionLength > 0)
                GetFastColoredTextBox().Copy();
            else if (!tabControl.SelectedTab.Name.EndsWith("cs") && GetRichTextBox().SelectionLength > 0)
                GetRichTextBox().Copy();
        }

        /// <summary>
        /// Вырезание выделенного фрагмента.
        /// </summary>
        private void Cut_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.EndsWith("cs") && GetFastColoredTextBox().SelectionLength > 0)
                GetFastColoredTextBox().Cut();
            else if (!tabControl.SelectedTab.Name.EndsWith("cs") && GetRichTextBox().SelectionLength > 0)
                GetRichTextBox().Cut();
        }

        /// <summary>
        /// Вставка раннее скопированного фрагмента.
        /// </summary>
        private void Paste_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.EndsWith("cs"))
                GetFastColoredTextBox().Paste();
            else
                GetRichTextBox().Paste();
        }

        /// <summary>
        /// Выделение всего текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAll_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.EndsWith("cs"))
                GetFastColoredTextBox().SelectAll();
            else
                GetRichTextBox().SelectAll();
        }

        /// <summary>
        /// Здесь хранятся пути ко всем открытым файлам (для их открытия при повторном запуске программы).
        /// </summary>
        System.Collections.Specialized.StringCollection openedTabs = new System.Collections.Specialized.StringCollection();

        /// <summary>
        /// Сохранение всех путей к открытым файлам и изменений в них перед закрытием формы.
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.ListOfPaths != null)
                    Properties.Settings.Default.ListOfPaths.Clear();
                foreach (TabPage tab in tabControl.TabPages)
                {
                    // Флаг показывает, нужно ли отображать диалоговое окно.
                    bool flag = false;
                    if (tab.Name == "" && ((RichTextBox)tab.Controls[0]).Text != "")
                        flag = true;
                    // Проверяем, есть ли несохраненные изменения.
                    if (File.Exists(tab.Name))
                    {
                        if (tab.Text.EndsWith("rtf"))
                        {
                            var rtb = new RichTextBox();
                            rtb.LoadFile(tab.Name);
                            if (!rtb.Rtf.Equals((RichTextBox)tab.Controls[0]))
                                flag = true;
                        }
                        else if (tab.Text.EndsWith("cs"))
                        {
                            if (((FastColoredTextBoxNS.FastColoredTextBox)tab.Controls[0]).Text != File.ReadAllText(tab.Name))
                                flag = true;
                        }
                        else
                        {
                            if (((RichTextBox)tab.Controls[0]).Text != File.ReadAllText(tab.Name))
                                flag = true;
                        }
                    }
                    // Высвечиваем MessageBox при необходимости.
                    if (flag)
                    {
                        var answer = MessageBox.Show($"Вы хотите сохранить изменения в файле {tab.Text}?", Text, MessageBoxButtons.YesNoCancel);
                        if (answer == DialogResult.Yes)
                        {
                            if (tab.Name == "")
                                SaveAs_CLick(sender, e);
                            else
                            {
                                var path = tab.Name;
                                if (path.EndsWith(".rtf"))
                                    ((RichTextBox)tab.Controls[0]).SaveFile(path);
                                else if (path.EndsWith(".cs"))
                                    File.WriteAllText(path, ((FastColoredTextBoxNS.FastColoredTextBox)tab.Controls[0]).Text);
                                else
                                    File.WriteAllText(path, ((RichTextBox)tab.Controls[0]).Text);
                            }

                        }
                        else if (answer == DialogResult.Cancel)
                        {
                            e.Cancel = true;
                            return;
                        }
                    }
                    // Добавляем путь к файлу в список.
                    openedTabs.Add(tab.Name);
                }
                Properties.Settings.Default.ListOfPaths = openedTabs;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Закрытие формы.
        /// </summary>
        private void CLoseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Отмена последних действий (Ctrl+Z).
        /// </summary>
        private void Undo_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.EndsWith("cs"))
                GetFastColoredTextBox().Undo();
            else
                GetRichTextBox().Undo();
        }

        /// <summary>
        /// Возврат отмененных действий (Ctrl+Shift+Z).
        /// </summary>
        private void Redo_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name.EndsWith("cs"))
                GetFastColoredTextBox().Redo();
            else
                GetRichTextBox().Redo();
        }

        /// <summary>
        /// Автоматическое форматирование кода на языке C#.
        /// </summary>
        private void AutoFormat_Click(object sender, EventArgs e)
        {
            if (!tabControl.SelectedTab.Name.EndsWith("cs"))
            {
                MessageBox.Show("Автоматическое форматирование кода можно применять только к файлам с расширением \".cs\".");
                return;
            }
            // Построчно проходим по файлу и форматируем его.
            for (var i = 0; i < GetFastColoredTextBox().LinesCount; i++)
                GetFastColoredTextBox().DoAutoIndent(i);
        }

        /// <summary>
        /// Создание версий файла.
        /// </summary>
        private void MakeCopy_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TabPage tab in tabControl.TabPages)
                {
                    // Проверяем, сохранен ли файл.
                    if (tabControl.SelectedTab.Name == "")
                    {
                        MessageBox.Show("Для журналирования сначала необходимо сохранить новый файл.");
                        SaveAs_CLick(sender, e);
                        // Проверяем, что файл точно был сохранен.
                        if (tabControl.SelectedTab.Name == "")
                            return;
                    }
                    var directoryPath = Path.ChangeExtension(tab.Name, null);
                    // При необходимости создаем папку с копиями.
                    if (!Directory.Exists(directoryPath))
                    {
                        DirectoryInfo dirForCopies = Directory.CreateDirectory(directoryPath);
                        dirForCopies.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                    }
                    var fileCount = Directory.GetFiles(directoryPath).Length;
                    var fileExtention = Path.GetExtension(tab.Name);
                    var copyPath = $"{directoryPath}{Path.DirectorySeparatorChar}{Path.GetFileNameWithoutExtension(tab.Name)}{fileCount + 1}{fileExtention}";
                    var path = tab.Name;
                    // Сохраняем файл.
                    if (path.EndsWith(".rtf"))
                        ((RichTextBox)tab.Controls[0]).SaveFile(copyPath);
                    else if (path.EndsWith(".cs"))
                        File.WriteAllText(copyPath, ((FastColoredTextBoxNS.FastColoredTextBox)tab.Controls[0]).Text);
                    else
                        File.WriteAllText(copyPath, ((RichTextBox)tab.Controls[0]).Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Загрузка предыдущей версии файла.
        /// </summary>
        private void GetLastVersion_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab != null && tabControl.SelectedTab.Name != "")
                {
                    var filename = tabControl.SelectedTab.Name;
                    var fileExtention = Path.GetExtension(filename);
                    var directoryPath = Path.ChangeExtension(filename, null);
                    var fileCount = Directory.GetFiles(directoryPath).Length;
                    // Проверяем есть ли сохраненные версии.
                    if (fileCount > 0)
                    {
                        // Составляем путь к необходимому файлу.
                        var copyPath = $"{directoryPath}{Path.DirectorySeparatorChar}{Path.GetFileNameWithoutExtension(filename)}{fileCount}{fileExtention}";
                        if (filename.EndsWith(".cs"))
                            GetFastColoredTextBox().Text = File.ReadAllText(copyPath);
                        else if (filename.EndsWith(".rtf"))
                            GetRichTextBox().LoadFile(copyPath);
                        else
                        {
                            string fileText = File.ReadAllText(copyPath);
                            GetRichTextBox().Text = fileText;
                        }
                        File.Delete(copyPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Автоматическое создание версии файла каждые 30 секунд.
        /// </summary>
        private void CopyEvery30Sec_Click(object sender, EventArgs e)
        {
            timerForMakingCopies.Interval = 30000;
            timerForMakingCopies.Enabled = true;
            // Сохраняем интервал таймера для следущего запуска приложения.
            Properties.Settings.Default.CopyingInterval = 30000;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Автоматическое создание версии файла каждую минуту.
        /// </summary>
        private void CopyEvery1Min_Click(object sender, EventArgs e)
        {
            timerForMakingCopies.Interval = 60000;
            timerForMakingCopies.Enabled = true;
            // Сохраняем интервал таймера для следущего запуска приложения.
            Properties.Settings.Default.CopyingInterval = 60000;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Автоматическое создание версии файла каждые 2 минуты.
        /// </summary>
        private void CopyEvery2Min_Click(object sender, EventArgs e)
        {
            timerForMakingCopies.Interval = 120000;
            timerForMakingCopies.Enabled = true;
            // Сохраняем интервал таймера для следущего запуска приложения.
            Properties.Settings.Default.CopyingInterval = 120000;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Автоматическое создание версии файла каждые 5 минут.
        /// </summary>
        private void CopyEvery5Min_Click(object sender, EventArgs e)
        {
            timerForMakingCopies.Interval = 5 * 60 * 1000;
            timerForMakingCopies.Enabled = true;
            // Сохраняем интервал таймера для следущего запуска приложения.
            Properties.Settings.Default.CopyingInterval = 5 * 60 * 1000;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Автоматическое создание версии файла каждые 10 минут.
        /// </summary>
        private void CopyEvery10Min_Click(object sender, EventArgs e)
        {
            timerForMakingCopies.Interval = 10 * 60 * 1000;
            timerForMakingCopies.Enabled = true;
            // Сохраняем интервал таймера для следущего запуска приложения.
            Properties.Settings.Default.CopyingInterval = 10 * 60 * 1000;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Отключение журналирования.
        /// </summary>
        private void CopyOff_Click(object sender, EventArgs e)
        {
            timerForMakingCopies.Enabled = false;
            // Сохраняем параметр таймера для следущего запуска приложения.
            Properties.Settings.Default.CopyingInterval = 0;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Каждый тик таймера создаем копию.
        /// </summary>
        private void timerForMakingCopies_Tick(object sender, EventArgs e)
        {
            MakeCopy_Click(sender, e);
        }
    }
}
